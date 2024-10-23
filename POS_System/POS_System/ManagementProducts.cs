using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class ManagementProduct : Form
    {
        public ManagementProduct()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddProducts addProducts = new AddProducts();
            addProducts.Show();
            this.Hide();

        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            this.Show();

            ConnectPOS_DB connect=new ConnectPOS_DB();
            string sql = "select * from Products";
            SqlCommand cmnd = new SqlCommand(sql, connect.GetConn());
            SqlDataAdapter adapter = new SqlDataAdapter(cmnd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridViewProducts.DataSource = dataTable;
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            ManagementSales managementSales = new ManagementSales();
            managementSales.Show();
            this.Hide();
        }

        private void buttonSaleItems_Click(object sender, EventArgs e)
        {
            ManagementSaleItems managementSaleItems = new ManagementSaleItems();
            managementSaleItems.Show();
            this.Hide();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
                if (dataGridViewProducts.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewProducts.SelectedRows[0];

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        ConnectPOS_DB connect = new ConnectPOS_DB();

                        // Get the ProductId from the selected row
                        string productId = selectedRow.Cells["Product_Id"].Value.ToString();

                        string sqlDelete = "DELETE FROM Products WHERE Product_Id = @Product_Id";
                        SqlCommand cmdDelete = new SqlCommand(sqlDelete, connect.GetConn());
                        cmdDelete.Parameters.AddWithValue("@Product_Id", productId);

                        try
                        {
                            cmdDelete.ExecuteNonQuery();

                            dataGridViewProducts.Rows.Remove(selectedRow);

                            MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            

        }
    }
}
