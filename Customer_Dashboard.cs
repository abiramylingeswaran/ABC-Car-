using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp46
{
    public partial class Customer_Dashboard : Form
    {
        private string connectionString = "Data Source=DESKTOP-KRP578P;Initial Catalog=Car;Integrated Security=True;TrustServerCertificate=True";

        public Customer_Dashboard()
        {
            InitializeComponent();
        }

        private void Customer_Dashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
        }

        private void Car_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Hide();
            LoadCarData();

        }

        private void Parts_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            dataGridView1.Hide();
            LoadCarPartsData();
        }

        void LoadCarData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string selectQuery = "SELECT * FROM CarDetails";

                    using (SqlCommand command = new SqlCommand(selectQuery, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (dataGridView1.Columns.Count == 0)
                            {
                                dataGridView1.Columns.Add("CarId", "CarId");
                                dataGridView1.Columns.Add("MakeAndModel", "Make and Model");
                                dataGridView1.Columns.Add("Year", "Year");
                                dataGridView1.Columns.Add("EngineSpecifications", "Engine Specifications");
                                dataGridView1.Columns.Add("Transmission", "Transmission");
                                dataGridView1.Columns.Add("Dimensions", "Dimensions");
                                dataGridView1.Columns.Add("Weight", "Weight");
                                dataGridView1.Columns.Add("TopSpeed", "Top Speed");
                                dataGridView1.Columns.Add("Acceleration", "Acceleration");
                                dataGridView1.Columns.Add("Pricing", "Pricing");
                            }

                            while (reader.Read())
                            {
                                dataGridView1.Rows.Add(
                                    reader["CarId"],
                                    reader["Make and Model"],
                                    reader["Year"],
                                    reader["Engine Specifications"],
                                    reader["Transmission"],
                                    reader["Dimensions"],
                                    reader["Weight"],
                                    reader["Top Speed"],
                                    reader["Acceleration"],
                                    reader["Pricing"]
                                );
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL error occurred: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        void LoadCarPartsData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string selectQuery = "SELECT CarPartId, PartsName, ManufacturingCompany, Condition, PartNumber, Price FROM CarParts";

                    using (SqlCommand command = new SqlCommand(selectQuery, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridView2.Rows.Clear();
                            dataGridView2.Columns.Clear();

                            if (dataGridView2.Columns.Count == 0)
                            {
                                dataGridView2.Columns.Add("CarPartId", "Car Part ID");
                                dataGridView2.Columns.Add("PartsName", "Parts Name");
                                dataGridView2.Columns.Add("ManufacturingCompany", "Manufacturing Company");
                                dataGridView2.Columns.Add("Condition", "Condition");
                                dataGridView2.Columns.Add("PartNumber", "Part Number");
                                dataGridView2.Columns.Add("Price", "Price");
                            }

                            while (reader.Read())
                            {
                                dataGridView2.Rows.Add(
                                    reader["CarPartId"],
                                    reader["PartsName"],
                                    reader["ManufacturingCompany"],
                                    reader["Condition"],
                                    reader["PartNumber"],
                                    reader["Price"]
                                );
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL error occurred: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        /*private void Order_Click(object sender, EventArgs e)
        {

        }
        */
        private void Order_Click_1(object sender, EventArgs e)
        {
            Order_Form order_Form = new Order_Form();
            order_Form.ShowDialog();

        }
    }
}
