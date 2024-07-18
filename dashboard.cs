using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp46

{

    public partial class dashboard : Form
    {
        // Connection string to your SQL Server database
        private string connectionString = @"Data Source=DESKTOP-KRP578P;Initial Catalog=Car;Integrated Security=True";



        public dashboard()
        {
            InitializeComponent();
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            CarPannel.Visible = false;
            CarPartsDetail.Visible = false;
            CustomerOrder.Visible = false;
        }


        private void CarDatails_Click(object sender, EventArgs e)
        {
            {
                CarPannel.Visible = true;
                CarPartsDetail.Hide();
                CustomerOrder.Hide();
                LoadData();
            }




            void LoadData()
            {
                string connectionString = "Data Source=DESKTOP-KRP578P;Initial Catalog=Car;Integrated Security=True;TrustServerCertificate=True";

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
                                if (CarDetails.Columns.Count == 0)
                                {
                                    CarDetails.Columns.Add("CarId", "CarId");
                                    CarDetails.Columns.Add("Make and Model", "Make and Model");
                                    CarDetails.Columns.Add("Year", "Year");
                                    CarDetails.Columns.Add("Engine Specifications", "Engine Specifications");
                                    CarDetails.Columns.Add("Transmission", "Transmission");
                                    CarDetails.Columns.Add("Dimensions", "Dimensions");
                                    CarDetails.Columns.Add("Weight", "Weight");
                                    CarDetails.Columns.Add("Top Speed", "Top Speed");
                                    CarDetails.Columns.Add("Acceleration", "Acceleration");
                                    CarDetails.Columns.Add("Pricing", "Pricing");
                                }

                                while (reader.Read())
                                {
                                    CarDetails.Rows.Add(
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

                                reader.Close();
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
        }


        private void CarPartsDetails_Click(object sender, EventArgs e)
        {
            {
                CarPannel.Hide();
                CarPartsDetail.Visible = true;
                CustomerOrder.Hide();
                LoadCarPartsData();

            }
            void LoadCarPartsData()
            {
                string connectionString = "Data Source=DESKTOP-KRP578P;Initial Catalog=Car;Integrated Security=True;TrustServerCertificate=True";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        string selectQuery = "SELECT * FROM CarParts"; // Adjust the table name as per your database schema



                        using (SqlCommand command = new SqlCommand(selectQuery, con))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                // Add columns to the DataGridView if they are not already added
                                if (dataGridView1.Columns.Count == 0)
                                {
                                    dataGridView1.Columns.Add("CarPartId", "Car Part ID");
                                    dataGridView1.Columns.Add("PartsName", "Parts Name");
                                    dataGridView1.Columns.Add("ManufacturingCompany", "Manufacturing Company");
                                    dataGridView1.Columns.Add("Condition", "Condition");
                                    dataGridView1.Columns.Add("PartNumber", "Part Number");
                                    dataGridView1.Columns.Add("Price", "Price");
                                }

                                // Populate DataGridView with data from SqlDataReader
                                while (reader.Read())
                                {
                                    dataGridView1.Rows.Add(
                                        reader["CarPartId"],
                                        reader["PartsName"],
                                        reader["ManufacturingCompany"],
                                        reader["Condition"],
                                        reader["PartNumber"],
                                        reader["Price"]
                                    );
                                }

                                reader.Close();
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
        }

        private void button4_Click(object sender, EventArgs e)
        {

            CustomerOrder.Visible = true;
            CarPannel.Hide();
            CarPartsDetail.Hide();

            string connectionString = "Data Source=DESKTOP-KRP578P;Initial Catalog=Car;Integrated Security=True;TrustServerCertificate=True";

            LoadOrderDetails();

            void LoadOrderDetails()
            {
                dataGridView2.Rows.Clear();
                string selectQuery = "SELECT * FROM [Order]";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand(selectQuery, con))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (dataGridView2.Columns.Count == 0)
                                {
                                    dataGridView2.Columns.Add("OrderId", "Order ID");
                                    dataGridView2.Columns.Add("Username", "Username");
                                    dataGridView2.Columns.Add("CarPartsId", "Car/Parts ID");
                                    dataGridView2.Columns.Add("PhoneNumber", "Phone Number");
                                    dataGridView2.Columns.Add("LivingPlace", "Living Place");
                                    dataGridView2.Columns.Add("OrderDate", "Order Date");
                                }

                                while (reader.Read())
                                {
                                    dataGridView2.Rows.Add(
                                        reader["OrderId"],
                                        reader["Username"],
                                        reader["CarPartsId"],
                                        reader["PhoneNumber"],
                                        reader["LivingPlace"],
                                        reader["OrderDate"]
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
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CustomerOrder.Hide();
            Report report = new Report();
            report.Show();



        }

        private void DelectCar_Click(object sender, EventArgs e)
        {

            if (CarDetails.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = CarDetails.SelectedRows[0];

                // Get the CarID from the selected row
                int carId = Convert.ToInt32(selectedRow.Cells["Column11"].Value);

                // Remove the selected row from the DataGridView
                CarDetails.Rows.Remove(selectedRow);

                // Delete the corresponding record from the database
                DeleteCarFromDatabase(carId);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void DeleteCarFromDatabase(int carId)
        {
            string connectionString = "Data Source=DESKTOP-KRP578P;Initial Catalog=Car;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string deleteQuery = "DELETE FROM CarDetails WHERE CarId = @CarId";

                    using (SqlCommand command = new SqlCommand(deleteQuery, con))
                    {
                        command.Parameters.AddWithValue("@CarId", carId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Record not found or unable to delete.");
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

        private void button8_Click(object sender, EventArgs e)
        {

            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Get the CarPartId from the selected row
                    int carPartId = Convert.ToInt32(selectedRow.Cells["Column12"].Value);//CarId 11968

                    // Remove the selected row from the DataGridView
                    dataGridView1.Rows.Remove(selectedRow);

                    // Delete the corresponding record from the database
                    DeleteCarPartFromDatabase(carPartId);
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }

            void DeleteCarPartFromDatabase(int carPartId)
            {
                string connectionString = "Data Source=DESKTOP-KRP578P;Initial Catalog=Car;Integrated Security=True;TrustServerCertificate=True";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        string deleteQuery = "DELETE FROM CarParts WHERE CarPartId = @CarPartId";

                        using (SqlCommand command = new SqlCommand(deleteQuery, con))
                        {
                            command.Parameters.AddWithValue("@CarPartId", carPartId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Record not found or unable to delete.");
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

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}



