using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS_System
{
    public partial class ManagementSaleItems : Form
    {
        private readonly ConnectPOS_DB connect;

        public ManagementSaleItems()
        {
            InitializeComponent();
            connect = new ConnectPOS_DB();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            ManagementProduct managementProduct = new ManagementProduct();
            managementProduct.Show();
            Hide();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            ManagementSales managementSales = new ManagementSales();
            managementSales.Show();
            Hide();
        }

        private void buttonSaleItems_Click(object sender, EventArgs e)
        {
            LoadSaleItems();
        }

        private void LoadSaleItems()
        {
            try
            {
                using (SqlConnection connection = connect.GetConn())
                {
                    string sql = "SELECT * FROM Sale_Items";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewSaleItems.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sale items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            Hide();
        }
    }
}
