using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    internal class ProductService
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                using (ConnectPOS_DB connect = new ConnectPOS_DB())
                {
                    using (SqlConnection connection = connect.GetConn())
                    {
                        string query = "SELECT Product_Id, Product_Name, Price, ProductImage FROM Products";

                        try
                        {
                            products.Clear();

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
                        catch (Exception ex)
                        {
                          
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        finally
                        {
                            if (connection.State == ConnectionState.Open)
                            {
                                connection.Close();
                            }
                        }

                    }
                }
                Console.WriteLine($"Retrieved {products.Count} products from the database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving products: {ex.Message}");
            }

            return products;
        }
    }
}
