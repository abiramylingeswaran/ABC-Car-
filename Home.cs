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
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
          
            Login__Register __Register = new Login__Register();
            __Register.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Adimin_login adimin_Login = new Adimin_login();
            adimin_Login.Show();

        }
    }
}
