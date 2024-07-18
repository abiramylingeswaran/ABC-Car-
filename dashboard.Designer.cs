namespace WinFormsApp46
{
    partial class dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            CarDatails = new Button();
            button3 = new Button();
            button4 = new Button();
            CarPartsDetails = new Button();
            CarPannel = new Panel();
            CarDetails = new DataGridView();
            Column11 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            DelectCar = new Button();
            CarPartsDetail = new Panel();
            button8 = new Button();
            dataGridView1 = new DataGridView();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            CustomerOrder = new Panel();
            dataGridView2 = new DataGridView();
            Column19 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column23 = new DataGridViewTextBoxColumn();
            Column20 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            CarPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CarDetails).BeginInit();
            CarPartsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            CustomerOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.thumb_1920_115387;
            pictureBox1.Location = new Point(-1, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2221, 1050);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CarDatails
            // 
            CarDatails.BackColor = Color.WhiteSmoke;
            CarDatails.FlatAppearance.MouseDownBackColor = Color.Blue;
            CarDatails.FlatStyle = FlatStyle.Popup;
            CarDatails.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CarDatails.ForeColor = Color.DarkBlue;
            CarDatails.Location = new Point(9, 130);
            CarDatails.Name = "CarDatails";
            CarDatails.Size = new Size(277, 55);
            CarDatails.TabIndex = 1;
            CarDatails.Text = "Car Details";
            CarDatails.UseVisualStyleBackColor = false;
            CarDatails.Click += CarDatails_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.FlatAppearance.MouseDownBackColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkBlue;
            button3.Location = new Point(9, 630);
            button3.Name = "button3";
            button3.Size = new Size(287, 55);
            button3.TabIndex = 3;
            button3.Text = "Reports";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.WhiteSmoke;
            button4.FlatAppearance.MouseDownBackColor = Color.Blue;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkBlue;
            button4.Location = new Point(9, 442);
            button4.Name = "button4";
            button4.Size = new Size(287, 82);
            button4.TabIndex = 4;
            button4.Text = "Customer Order Detail";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // CarPartsDetails
            // 
            CarPartsDetails.BackColor = Color.WhiteSmoke;
            CarPartsDetails.FlatAppearance.MouseDownBackColor = Color.Red;
            CarPartsDetails.FlatStyle = FlatStyle.Popup;
            CarPartsDetails.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CarPartsDetails.ForeColor = Color.DarkBlue;
            CarPartsDetails.Location = new Point(9, 320);
            CarPartsDetails.Name = "CarPartsDetails";
            CarPartsDetails.Size = new Size(287, 55);
            CarPartsDetails.TabIndex = 5;
            CarPartsDetails.Text = "Car  Parts Details";
            CarPartsDetails.UseVisualStyleBackColor = true;
            CarPartsDetails.Click += CarPartsDetails_Click;
            // 
            // CarPannel
            // 
            CarPannel.BackColor = Color.LightSkyBlue;
            CarPannel.Controls.Add(CarDetails);
            CarPannel.Controls.Add(DelectCar);
            CarPannel.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CarPannel.Location = new Point(373, 40);
            CarPannel.Name = "CarPannel";
            CarPannel.Size = new Size(1452, 873);
            CarPannel.TabIndex = 6;
            // 
            // CarDetails
            // 
            CarDetails.BorderStyle = BorderStyle.Fixed3D;
            CarDetails.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CarDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CarDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarDetails.Columns.AddRange(new DataGridViewColumn[] { Column11, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column10 });
            CarDetails.EditMode = DataGridViewEditMode.EditProgrammatically;
            CarDetails.GridColor = SystemColors.ActiveCaption;
            CarDetails.Location = new Point(3, 22);
            CarDetails.Name = "CarDetails";
            CarDetails.RowHeadersWidth = 51;
            CarDetails.RowTemplate.Height = 29;
            CarDetails.Size = new Size(1425, 786);
            CarDetails.TabIndex = 0;
            // 
            // Column11
            // 
            Column11.HeaderText = "CarId";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 125;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.DividerWidth = 2;
            Column1.HeaderText = "Make and Model";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 148;
            // 
            // Column2
            // 
            Column2.HeaderText = "Year";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Engine Specifications";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Transmission";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Dimensions";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.False;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Weight";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Resizable = DataGridViewTriState.False;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Top Speed";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Resizable = DataGridViewTriState.False;
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Acceleration";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Resizable = DataGridViewTriState.False;
            Column8.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Pricing";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Resizable = DataGridViewTriState.False;
            Column10.Width = 125;
            // 
            // DelectCar
            // 
            DelectCar.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DelectCar.ForeColor = SystemColors.ActiveCaptionText;
            DelectCar.Location = new Point(638, 814);
            DelectCar.Name = "DelectCar";
            DelectCar.Size = new Size(204, 38);
            DelectCar.TabIndex = 3;
            DelectCar.Text = "Delect";
            DelectCar.UseVisualStyleBackColor = true;
            DelectCar.Click += DelectCar_Click;
            // 
            // CarPartsDetail
            // 
            CarPartsDetail.BackColor = Color.SteelBlue;
            CarPartsDetail.Controls.Add(button8);
            CarPartsDetail.Controls.Add(dataGridView1);
            CarPartsDetail.Font = new Font("Cooper Black", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            CarPartsDetail.Location = new Point(413, 31);
            CarPartsDetail.Name = "CarPartsDetail";
            CarPartsDetail.Size = new Size(1128, 861);
            CarPartsDetail.TabIndex = 5;
            // 
            // button8
            // 
            button8.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(383, 758);
            button8.Name = "button8";
            button8.Size = new Size(204, 38);
            button8.TabIndex = 4;
            button8.Text = "Delect";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column12, Column13, Column14, Column15, Column16, Column17 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(107, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(881, 709);
            dataGridView1.TabIndex = 0;
            // 
            // Column12
            // 
            Column12.HeaderText = "CarPartId";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 125;
            // 
            // Column13
            // 
            Column13.HeaderText = "Parts Name";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.Width = 125;
            // 
            // Column14
            // 
            Column14.HeaderText = "Manufacturing Company";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.Width = 125;
            // 
            // Column15
            // 
            Column15.HeaderText = "Condition";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            Column15.Width = 125;
            // 
            // Column16
            // 
            Column16.HeaderText = "Part Number";
            Column16.MinimumWidth = 6;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            Column16.Width = 125;
            // 
            // Column17
            // 
            Column17.HeaderText = "Price";
            Column17.MinimumWidth = 6;
            Column17.Name = "Column17";
            Column17.ReadOnly = true;
            Column17.Width = 125;
            // 
            // CustomerOrder
            // 
            CustomerOrder.BackColor = Color.SteelBlue;
            CustomerOrder.Controls.Add(dataGridView2);
            CustomerOrder.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerOrder.Location = new Point(355, 62);
            CustomerOrder.Name = "CustomerOrder";
            CustomerOrder.Size = new Size(1161, 784);
            CustomerOrder.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column19, Column18, Column23, Column20 });
            dataGridView2.Cursor = Cursors.Hand;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView2.GridColor = SystemColors.ActiveCaption;
            dataGridView2.Location = new Point(258, 17);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(722, 733);
            dataGridView2.TabIndex = 0;
            // 
            // Column19
            // 
            Column19.HeaderText = "Order Id";
            Column19.MinimumWidth = 6;
            Column19.Name = "Column19";
            Column19.ReadOnly = true;
            Column19.Width = 125;
            // 
            // Column18
            // 
            Column18.HeaderText = "UserName";
            Column18.MinimumWidth = 9;
            Column18.Name = "Column18";
            Column18.ReadOnly = true;
            Column18.Width = 125;
            // 
            // Column23
            // 
            Column23.HeaderText = "Car/CarPartsID";
            Column23.MinimumWidth = 6;
            Column23.Name = "Column23";
            Column23.ReadOnly = true;
            Column23.Width = 125;
            // 
            // Column20
            // 
            Column20.HeaderText = "Phone Number";
            Column20.MinimumWidth = 6;
            Column20.Name = "Column20";
            Column20.ReadOnly = true;
            Column20.Width = 125;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1891, 963);
            Controls.Add(CustomerOrder);
            Controls.Add(CarPartsDetail);
            Controls.Add(CarPannel);
            Controls.Add(CarPartsDetails);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(CarDatails);
            Controls.Add(pictureBox1);
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            Load += dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            CarPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CarDetails).EndInit();
            CarPartsDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            CustomerOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button CarDatails;
        private Button button3;
        private Button button4;
        private Button CarPartsDetails;
        private Panel CarPannel;
        private DataGridView CarDetails;
        private Button DelectCar;
        private Panel CarPartsDetail;
        private DataGridView dataGridView1;
        private Button button8;
        private Panel CustomerOrder;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column23;
        private DataGridViewTextBoxColumn Column20;
    }
}