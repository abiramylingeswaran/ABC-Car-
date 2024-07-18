namespace WinFormsApp46
{
    partial class Order_Form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Order = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.car_buying_car_mechanic_car_purchase_car_sell_wallpaper_preview;
            pictureBox1.Location = new Point(-2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1039, 771);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(234, 40);
            label1.Name = "label1";
            label1.Size = new Size(522, 69);
            label1.TabIndex = 1;
            label1.Text = " Order Your Car";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(49, 217);
            label2.Name = "label2";
            label2.Size = new Size(204, 39);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(49, 320);
            label3.Name = "label3";
            label3.Size = new Size(292, 39);
            label3.TabIndex = 3;
            label3.Text = "Car/CarParts Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(49, 424);
            label4.Name = "label4";
            label4.Size = new Size(274, 39);
            label4.TabIndex = 4;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(49, 541);
            label5.Name = "label5";
            label5.Size = new Size(226, 39);
            label5.TabIndex = 5;
            label5.Text = "Living Place";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Navy;
            textBox1.Location = new Point(429, 223);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(415, 38);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Navy;
            textBox2.Location = new Point(429, 320);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(415, 38);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Navy;
            textBox3.Location = new Point(429, 413);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(415, 38);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.Navy;
            textBox4.Location = new Point(429, 541);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(415, 38);
            textBox4.TabIndex = 9;
            // 
            // Order
            // 
            Order.BackColor = Color.SteelBlue;
            Order.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Order.ForeColor = SystemColors.ButtonFace;
            Order.Location = new Point(451, 673);
            Order.Name = "Order";
            Order.Size = new Size(346, 54);
            Order.TabIndex = 10;
            Order.Text = "Order";
            Order.UseVisualStyleBackColor = false;
            Order.Click += Order_Click_1;
            // 
            // Order_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 771);
            Controls.Add(Order);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Order_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button Order;
    }
}