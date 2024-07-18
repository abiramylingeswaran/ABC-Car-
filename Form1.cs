namespace WinFormsApp46
{
    public partial class FrontPage : Form
    {
        string connectionString = "Data Source=DESKTOP-KRP578P;Initial Catalog=Car;Integrated Security=True";
        public FrontPage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            home.Show();
            

        }
    }
}