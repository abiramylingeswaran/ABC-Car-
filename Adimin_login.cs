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
    public partial class Adimin_login : Form
    {
        public Adimin_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string predefinedName = "Hesini";
            int predefinedPin = 555;

            string enteredName = textBox1.Text;
            int enteredPin;

            if (int.TryParse(textBox2.Text, out enteredPin))
            {
                if (predefinedName == enteredName && predefinedPin == enteredPin)
                {
                    dashboard dash = new dashboard();
                    dash.Show();
                    this.Close();
                }
                else
                {
                    Clearbox();
                    MessageBox.Show("Enter Correct Username and PIN");

                }
            }
            else
            {   Clearbox();
                MessageBox.Show("Please enter a valid PIN.");
            }
             void Clearbox(){
                textBox1.Text = "";
                textBox2.Text = "";

            }
        }

    }
}
