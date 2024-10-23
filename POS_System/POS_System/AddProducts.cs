using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace POS_System
{
    public partial class AddProducts : Form
    {
        private List<Product> products = new List<Product>();


        public AddProducts()
        {
            InitializeComponent();
            InitializeProductsFromDatabase();
        }

        private void InitializeProductsFromDatabase()
        {
            using (ConnectPOS_DB connect = new ConnectPOS_DB())
            {
                using (SqlConnection connection = connect.GetConn())
                {
                    string query = "SELECT Product_Id, Product_Name, Price, ProductImage FROM Products";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string productId = reader.GetString(0);
                                string productName = reader.GetString(1);
                                decimal price = reader.GetDecimal(2);

                                byte[] productImage = reader.IsDBNull(3) ? null : (byte[])reader["ProductImage"];

                                products.Add(new Product { Product_Id = productId, Product_Name = productName, Price = price, ProductImage = productImage });
                            }
                        }
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ManagementProduct managementProduct = new ManagementProduct();
            managementProduct.Show();
            this.Hide();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ConnectPOS_DB connect = new ConnectPOS_DB();

            try
            {
                if (textBoxProductId.Text != "" && textBoxProductName.Text != "" && textBoxProductPrice.Text != "")
                {
                    byte[] productImageBytes = ImageToByteArray(pictureBoxAddPicture.Image);

                    string sql = "INSERT INTO Products(Product_Id, Product_Name, Price, ProductImage) " +
                                 "VALUES(@ProductId, @ProductName, @Price, @ProductImage)";

                    using (SqlConnection connection = connect.GetConn())
                    {
                        using (SqlCommand cmnd = new SqlCommand(sql, connection))
                        {
                            cmnd.Parameters.AddWithValue("@ProductId", textBoxProductId.Text);
                            cmnd.Parameters.AddWithValue("@ProductName", textBoxProductName.Text);
                            cmnd.Parameters.AddWithValue("@Price", decimal.Parse(textBoxProductPrice.Text));
                            cmnd.Parameters.AddWithValue("@ProductImage", productImageBytes);

                            connect.OpenConnection();
                            cmnd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Product Added Successfully");

                    textBoxProductId.Text = "";
                    textBoxProductName.Text = "";
                    textBoxProductPrice.Text = "";
                    pictureBoxAddPicture.Image = null;

                    Menu menuForm = Application.OpenForms.OfType<Menu>().FirstOrDefault();
                    if (menuForm != null)
                    {
                        menuForm.UpdateMenuOnProductAdded();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connect.CloseConnection();
            }
        }


        private byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }
       

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxAddPicture.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Product
    {
        public string Product_Id { get; set; }
        public string Product_Name { get; set; }
        public decimal Price { get; set; }
        public byte[] ProductImage { get; set; }

    }
}
