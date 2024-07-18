using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp46
{
    public partial class Login__Register : Form
    {
        public Login__Register()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {


            string username = textBox1.Text;
            string pin = textBox2.Text;

            string connectionString = "Data Source=DESKTOP-KRP578P;Initial Catalog=Car;Integrated Security=True;TrustServerCertificate=True";

            string selectQuery = @"SELECT COUNT(*) FROM Customer WHERE Username = @Username AND Pin = @Pin";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand command = new SqlCommand(selectQuery, con))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Pin", pin);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!");
                            ClearTextBoxes();
                            Customer_Dashboard customer_Dashboard = new Customer_Dashboard();
                            customer_Dashboard.Show();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Invalid username or pin. Please try again.");
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

        private void ClearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }


        private void Register_Click(object sender, EventArgs e)
        {
        }
        

        private void Register_Click_1(object sender, EventArgs e)
        {
                string firstName = textBox3.Text;
                string lastName = textBox4.Text;
                string nationalId = textBox5.Text;
                string phoneNumber = textBox6.Text;
                string username = textBox7.Text;
                string pin = textBox8.Text;

                string connectionString = "Data Source=DESKTOP-KRP578P;Initial Catalog=Car;Integrated Security=True;TrustServerCertificate=True";

                string selectQuery = @"SELECT COUNT(*) FROM Customer WHERE Username = @Username";
                string insertQuery = @"INSERT INTO Customer (FirstName, LastName, NationalId, PhoneNumber, Username, Pin) 
                           VALUES (@FirstName, @LastName, @NationalId, @PhoneNumber, @Username, @Pin)";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // Check if the username already exists
                        using (SqlCommand checkCommand = new SqlCommand(selectQuery, con))
                        {
                            checkCommand.Parameters.AddWithValue("@Username", username);
                            int existingCount = (int)checkCommand.ExecuteScalar();

                            if (existingCount > 0)
                            {
                                MessageBox.Show("Username already exists. Please choose another username.");
                                return; // Exit registration process
                            }
                        }

                        // If username does not exist, proceed with registration
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, con))
                        {
                            insertCommand.Parameters.AddWithValue("@FirstName", firstName);
                            insertCommand.Parameters.AddWithValue("@LastName", lastName);
                            insertCommand.Parameters.AddWithValue("@NationalId", nationalId);
                            insertCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                            insertCommand.Parameters.AddWithValue("@Username", username);
                            insertCommand.Parameters.AddWithValue("@Pin", pin);

                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registration successful!");
                                ClearTextBoxes();
                            }
                            else
                            {
                                MessageBox.Show("Registration failed!");
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
    }




