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
    public partial class Order_Form : Form
    {
        public Order_Form()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=DESKTOP-KRP578P;Initial Catalog=Car;Integrated Security=True;TrustServerCertificate=True";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Order_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            int carPartsId = Convert.ToInt32(textBox2.Text.Trim()); // Assuming carPartsId is an integer
            string phoneNumber = textBox3.Text.Trim();
            string livingPlace = textBox4.Text.Trim();

            // Validate input (you can add more validation as needed)

            // Insert into database
            InsertOrder(username, carPartsId, phoneNumber, livingPlace);
        }
        private void InsertOrder(string username, int carPartsId, string phoneNumber, string livingPlace)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string insertQuery = "INSERT INTO [Order] (Username, CarPartsId, PhoneNumber, LivingPlace, OrderDate) " +
                                         "VALUES (@Username, @CarPartsId, @PhoneNumber, @LivingPlace, GETDATE())"; // Assuming OrderDate is the current date/time

                    using (SqlCommand command = new SqlCommand(insertQuery, con))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@CarPartsId", carPartsId);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@LivingPlace", livingPlace);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order placed successfully!");
                            // Clear text boxes or perform any other actions after successful order
                            ClearTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Order failed to insert!");
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
            textBox3.Text = "";
            textBox4.Text = "";
        }

       
        
    }
}


