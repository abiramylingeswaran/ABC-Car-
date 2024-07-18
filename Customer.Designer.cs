namespace WinFormsApp46
{
    partial class CustomerLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Login = new Button();
            Register = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(53, 51);
            label1.Name = "label1";
            label1.Size = new Size(273, 33);
            label1.TabIndex = 0;
            label1.Text = "ABC Car Traders";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(12, 259);
            label3.Name = "label3";
            label3.Size = new Size(46, 28);
            label3.TabIndex = 2;
            label3.Text = "PIN";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(162, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 38);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.ActiveCaption;
            textBox2.Location = new Point(162, 249);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(213, 38);
            textBox2.TabIndex = 4;
            // 
            // Login
            // 
            Login.BackColor = SystemColors.ControlDarkDark;
            Login.Cursor = Cursors.Hand;
            Login.FlatStyle = FlatStyle.Popup;
            Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = SystemColors.ButtonHighlight;
            Login.Location = new Point(12, 376);
            Login.Name = "Login";
            Login.Size = new Size(156, 45);
            Login.TabIndex = 5;
            Login.Text = "Login ";
            Login.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            Register.BackColor = SystemColors.ControlLightLight;
            Register.Cursor = Cursors.Hand;
            Register.FlatStyle = FlatStyle.Popup;
            Register.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Register.ForeColor = Color.DimGray;
            Register.Location = new Point(219, 376);
            Register.Name = "Register";
            Register.Size = new Size(156, 45);
            Register.TabIndex = 6;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Register_Click;
            // 
            // CustomerLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(408, 551);
            Controls.Add(Register);
            Controls.Add(Login);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(426, 598);
            MinimizeBox = false;
            MinimumSize = new Size(426, 598);
            Name = "CustomerLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Login;
        private Button Register;
    }
}