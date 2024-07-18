namespace WinFormsApp46
{
    partial class FrontPage


    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._1236836_beautiful_automotive_desktop_wallpaper_1920x1200_for_full_hd;
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1909, 1010);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.CausesValidation = false;
            label1.Cursor = Cursors.Hand;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Stencil", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(348, 0);
            label1.Name = "label1";
            label1.Size = new Size(1146, 142);
            label1.TabIndex = 1;
            label1.Text = " ABC Car Traders";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Orange_Make_Yourself_Proud_Quote_Your_Story__1_1;
            pictureBox2.Location = new Point(12, 343);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(496, 585);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(255, 128, 0);
            button3.Location = new Point(1535, 797);
            button3.Name = "button3";
            button3.Size = new Size(313, 73);
            button3.TabIndex = 5;
            button3.Text = "Go --->";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // FrontPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 953);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1000);
            MinimizeBox = false;
            MinimumSize = new Size(1918, 1000);
            Name = "FrontPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABC Car Traders";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button3;
    }
}