namespace GUI_PolyCafe
{
    partial class frmDoanhThuNhanVien
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvDanhSachThongKe = new DataGridView();
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cboNhanVien = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThongKe).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.DeepSkyBlue;
            guna2HtmlLabel1.Location = new Point(242, 16);
            guna2HtmlLabel1.Margin = new Padding(4, 3, 4, 3);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(751, 52);
            guna2HtmlLabel1.TabIndex = 16;
            guna2HtmlLabel1.Text = "THỐNG KÊ DOANH THU THEO NHÂN VIÊN";
            // 
            // dgvDanhSachThongKe
            // 
            dgvDanhSachThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachThongKe.Location = new Point(5, 25);
            dgvDanhSachThongKe.Margin = new Padding(3, 2, 3, 2);
            dgvDanhSachThongKe.Name = "dgvDanhSachThongKe";
            dgvDanhSachThongKe.RowHeadersWidth = 51;
            dgvDanhSachThongKe.Size = new Size(1169, 469);
            dgvDanhSachThongKe.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDanhSachThongKe);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.DeepSkyBlue;
            groupBox2.Location = new Point(39, 201);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1180, 498);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(192, 192, 0);
            label1.Location = new Point(16, 53);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 10;
            label1.Text = "Nhân viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnThongKe);
            groupBox1.Controls.Add(dtpDenNgay);
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DeepSkyBlue;
            groupBox1.Location = new Point(39, 69);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1180, 114);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(166, 52);
            cboNhanVien.Margin = new Padding(3, 2, 3, 2);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(162, 29);
            cboNhanVien.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(192, 192, 0);
            label3.Location = new Point(727, 53);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 30;
            label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(192, 192, 0);
            label2.Location = new Point(391, 53);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 29;
            label2.Text = "Từ ngày:";
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.Transparent;
            btnThongKe.BackgroundImageLayout = ImageLayout.Zoom;
            btnThongKe.BorderColor = Color.Gray;
            btnThongKe.BorderRadius = 5;
            btnThongKe.BorderThickness = 2;
            btnThongKe.CustomizableEdges = customizableEdges3;
            btnThongKe.DisabledState.BorderColor = Color.DarkGray;
            btnThongKe.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThongKe.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThongKe.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThongKe.FillColor = Color.White;
            btnThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.FromArgb(192, 192, 0);
            btnThongKe.Location = new Point(1048, 50);
            btnThongKe.Margin = new Padding(3, 2, 3, 2);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnThongKe.Size = new Size(115, 35);
            btnThongKe.TabIndex = 28;
            btnThongKe.Text = "Thống kê";
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(835, 54);
            dtpDenNgay.Margin = new Padding(3, 2, 3, 2);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(186, 29);
            dtpDenNgay.TabIndex = 27;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(489, 54);
            dtpTuNgay.Margin = new Padding(3, 2, 3, 2);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(186, 29);
            dtpTuNgay.TabIndex = 26;
            // 
            // frmDoanhThuNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1258, 715);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDoanhThuNhanVien";
            Text = "frmDoanhThuNhanVien";
            Load += frmDoanhThuNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThongKe).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DataGridView dgvDanhSachThongKe;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cboNhanVien;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
    }
}