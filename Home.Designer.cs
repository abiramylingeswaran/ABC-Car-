namespace WinFormsApp46
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            Admin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Car_On_Road;
            pictureBox1.Location = new Point(-168, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2067, 978);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.is_buying_car_good_investment_jpg_optimal;
            pictureBox3.Location = new Point(308, 317);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(351, 273);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.istockphoto_1471845663_612x612;
            pictureBox2.Location = new Point(1234, 317);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(396, 273);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise;
            button1.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(266, 676);
            button1.Name = "button1";
            button1.Size = new Size(442, 68);
            button1.TabIndex = 4;
            button1.Text = "Customer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Admin
            // 
            Admin.BackColor = Color.PaleTurquoise;
            Admin.FlatAppearance.BorderColor = Color.Black;
            Admin.FlatAppearance.BorderSize = 3;
            Admin.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise;
            Admin.FlatAppearance.MouseOverBackColor = Color.DimGray;
            Admin.FlatStyle = FlatStyle.Flat;
            Admin.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Admin.Location = new Point(1234, 664);
            Admin.Name = "Admin";
            Admin.Size = new Size(396, 68);
            Admin.TabIndex = 7;
            Admin.Text = "Admin";
            Admin.UseVisualStyleBackColor = false;
            Admin.Click += Admin_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1891, 963);
            Controls.Add(Admin);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1909, 1010);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button button1;
        private Button Admin;
    }
}