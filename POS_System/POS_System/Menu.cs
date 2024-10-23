using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Menu : Form
    {
        private readonly SqlConnection sqlConnection;

        public Menu(SqlConnection connection)
        {
            InitializeComponent();
            InitializeMenu();
            sqlConnection = connection;
        }

        private void InitializeMenu()
        {
            panelMenu = new Panel
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(panelMenu);
            buttonAddOrder.Click += buttonAddOrder_Click;
            UpdateMenu();
        }

        private void UpdateMenu()
        {
            panelMenu.AutoScroll = true;
            panelMenu.Visible = true;

            try
            {
                List<Product> products = ProductService.GetProducts();

                panelMenu.Controls.Clear();

                int buttonWidth = 185;
                int buttonHeight = 169;
                int maxButtonsPerRow = panelMenu.Width / buttonWidth;
                int padding = 10;

                int buttonTop = 0;
                int buttonLeft = 0;

                for (int i = 0; i < products.Count; i++)
                {
                    Button productButton = new Button
                    {
                        Size = new Size(buttonWidth, buttonHeight),
                        Tag = products[i]
                    };

                    if (products[i].ProductImage != null)
                    {
                        productButton.BackgroundImage = ByteArrayToImage(products[i].ProductImage);
                        productButton.BackgroundImageLayout = ImageLayout.Stretch;
                    }

                    productButton.Click += ProductButton_Click;
                    productButton.Location = new Point(buttonLeft, buttonTop);
                    panelMenu.Controls.Add(productButton);
                    buttonLeft += buttonWidth + padding;

                    if ((i + 1) % maxButtonsPerRow == 0)
                    {
                        buttonTop += buttonHeight + padding;
                        buttonLeft = 0;
                    }

                    Console.WriteLine($"Added button for product: {products[i].Product_Name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating menu: {ex.Message}");
            }
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Product selectedProduct = (Product)clickedButton.Tag;
            int quantity = (int)numericQuantity.Value;
            decimal totalPrice = selectedProduct.Price * quantity;
            string productInfo = $"{selectedProduct.Product_Name} - Quantity: {quantity} - Price: {totalPrice:C}";
            listBoxSelectItems.Items.Add(productInfo);
            numericQuantity.Value = 1;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            Hide();
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        public void UpdateMenuOnProductAdded()
        {
            UpdateMenu();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            CalculateTotalOrderPrice();
        }

        private decimal CalculateTotalOrderPrice()
        {
            decimal totalOrderPrice = 0;

            try
            {
                foreach (var item in listBoxSelectItems.Items)
                {
                    Console.WriteLine($"Raw Item: {item}");
                    ParseAndCalculateTotalPrice(item.ToString(), out decimal totalPrice);
                    totalOrderPrice += totalPrice;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            listBoxPrice.Items.Clear();
            listBoxPrice.Items.Add($"Total Order Price: {totalOrderPrice:C}");

            return totalOrderPrice;
        }

        private void ParseAndCalculateTotalPrice(string item, out decimal totalPrice)
        {
            totalPrice = 0;

            string[] itemInfo = item.Split('-');

            if (itemInfo.Length >= 3)
            {
                string quantityStr = itemInfo[1].Replace("Quantity:", "").Trim();
                string priceStr = itemInfo[2].Replace("Price:", "").Replace("C", "").Trim();

                Console.WriteLine($"Quantity String: {quantityStr}, Price String: {priceStr}");

                if (int.TryParse(quantityStr, out int quantity) && decimal.TryParse(priceStr, out decimal price))
                {
                    Console.WriteLine($"Quantity: {quantity}, Price: {price}");
                    totalPrice = quantity * price;
                    Console.WriteLine($"Total Price: {totalPrice}");
                }
                else
                {
                    Console.WriteLine($"Failed to parse quantity or price from: {item}");
                }
            }
            else
            {
                Console.WriteLine($"Invalid item format: {item}");
            }
        }

        private void ShowOrderSummary(decimal totalOrderPrice)
        {
            MessageBox.Show($"Order Completed\n\nTotal Order Price: {totalOrderPrice:C}", "Order Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBoxSelectItems.Items.Clear();
            listBoxPrice.Items.Clear();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            decimal totalOrderPrice = CalculateTotalOrderPrice();

            if (listBoxSelectItems.Items.Count > 0)
            {
                ShowOrderSummary(totalOrderPrice);
                if (sqlConnection != null)
                {
                    try
                    {
                        sqlConnection.Open();
                        InsertIntoSalesTable(totalOrderPrice);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error opening connection or inserting into Sales table: {ex.Message}");
                    }
                    finally
                    {
                        if (sqlConnection.State == ConnectionState.Open)
                            sqlConnection.Close();
                    }
                }
              
                UpdateMenuOnProductAdded();
            }
            else
            {
                MessageBox.Show("Please add items to the order before completing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void InsertIntoSalesTable(decimal totalOrderPrice)
        {
            SqlTransaction transaction = null;

            try
            {
                string insertQuery = "INSERT INTO Sales(Total_Amount, Sale_Date) " +
                                     "VALUES(@TotalAmount, @SaleDate); SELECT SCOPE_IDENTITY();";

                sqlConnection.Open();
                transaction = sqlConnection.BeginTransaction();

                using (SqlCommand cmd = new SqlCommand(insertQuery, sqlConnection, transaction))
                {
                    cmd.Parameters.AddWithValue("@TotalAmount", totalOrderPrice);
                    cmd.Parameters.AddWithValue("@SaleDate", DateTime.Now);

                    object result = cmd.ExecuteScalar();
                    string saleId = result?.ToString();

                    if (!string.IsNullOrEmpty(saleId))
                    {
                        foreach (var item in listBoxSelectItems.Items)
                        {
                            string[] itemInfo = item.ToString().Split('-');

                            if (itemInfo.Length >= 3)
                            {
                                string productName = itemInfo[0].Trim();
                                string quantityStr = itemInfo[1].Replace("Quantity:", "").Trim();
                                string priceStr = itemInfo[2].Replace("Price:", "").Replace("C", "").Trim();

                                if (int.TryParse(quantityStr, out int quantity) && decimal.TryParse(priceStr, out decimal price))
                                {
                                    InsertIntoSaleItemsTable(transaction, sqlConnection, saleId, productName, quantity, price);
                                }
                            }

                        }
                    }

                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting into Sales table: {ex.Message}");
                transaction?.Rollback();
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void InsertIntoSaleItemsTable(SqlTransaction transaction, SqlConnection sqlConnection, string saleId, string productName, int quantity, decimal price)
        {
            try
            {
                string insertQuery = "INSERT INTO Sale_Items(SaleItem_Id, Sale_Id, Product_Id, Quantity, Sub_Total) " +
                                     "VALUES(@SaleItem_Id, @Sale_Id, @Product_Id, @Quantity, @Sub_Total)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, sqlConnection, transaction))
                {
                    cmd.Parameters.AddWithValue("@SaleItem_Id", Guid.NewGuid().ToString());
                    cmd.Parameters.AddWithValue("@Sale_Id", saleId);
                    cmd.Parameters.AddWithValue("@Product_Id", productName);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Sub_Total", price * quantity);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting into SaleItems table: {ex.Message}");
            }
        }

       
    }
}
