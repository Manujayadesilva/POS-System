using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS_System
{
    public partial class ManagementSales : Form
    {
        private readonly SqlConnection connection;

        public ManagementSales()
        {
            InitializeComponent();
            ConnectPOS_DB connect = new ConnectPOS_DB();
            connection = connect.GetConn();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            ManagementProduct managementProduct = new ManagementProduct();
            managementProduct.Show();
            Hide();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            RefreshSalesData();
        }

        private void RefreshSalesData()
        {
            try
            {
                string sql = "SELECT * FROM Sales";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewSales.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaleItems_Click(object sender, EventArgs e)
        {
            ManagementSaleItems managementSaleItems = new ManagementSaleItems();
            managementSaleItems.Show();
            Hide();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSales.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewSales.SelectedRows[0];

                DialogResult result = MessageBox.Show("Are you sure you want to delete this sale?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string saleId = selectedRow.Cells["Sale_Id"].Value.ToString();

                    try
                    {
                        DeleteSale(saleId);
                        dataGridViewSales.Rows.Remove(selectedRow);
                        MessageBox.Show("Sale deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                            connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteSale(string saleId)
        {
            string sqlDelete = "DELETE FROM Sales WHERE Sale_Id = @Sale_Id";

            using (SqlCommand cmdDelete = new SqlCommand(sqlDelete, connection))
            {
                cmdDelete.Parameters.AddWithValue("@Sale_Id", saleId);
                connection.Open();
                cmdDelete.ExecuteNonQuery();
            }
        }
    }
}
