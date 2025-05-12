namespace GUI_PolyCafe
{
    partial class frmChiTietPhieu
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtPhanTram = new TextBox();
            txtThanhTien = new TextBox();
            txtGiamGia = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtDichVu = new TextBox();
            txtTong = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            btnThemChiTiet = new Guna.UI2.WinForms.Guna2Button();
            btnXoaChiTiet = new Guna.UI2.WinForms.Guna2Button();
            dgvSanPham = new DataGridView();
            lblNgayLap = new Label();
            label6 = new Label();
            lblMaPhieu = new Label();
            label4 = new Label();
            label2 = new Label();
            lblChuSoHuu = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvChiTiet = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // txtPhanTram
            // 
            txtPhanTram.Location = new Point(102, 75);
            txtPhanTram.Name = "txtPhanTram";
            txtPhanTram.Size = new Size(47, 34);
            txtPhanTram.TabIndex = 32;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(130, 116);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(331, 34);
            txtThanhTien.TabIndex = 31;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(198, 75);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(252, 34);
            txtGiamGia.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(192, 192, 0);
            label11.Location = new Point(6, 119);
            label11.Name = "label11";
            label11.Size = new Size(123, 28);
            label11.TabIndex = 29;
            label11.Text = "Thành Tiền:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(192, 192, 0);
            label10.Location = new Point(6, 77);
            label10.Name = "label10";
            label10.Size = new Size(98, 28);
            label10.TabIndex = 28;
            label10.Text = "Giảm Giá";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(192, 192, 0);
            label9.Location = new Point(155, 77);
            label9.Name = "label9";
            label9.Size = new Size(29, 28);
            label9.TabIndex = 27;
            label9.Text = "%";
            // 
            // txtDichVu
            // 
            txtDichVu.Location = new Point(337, 28);
            txtDichVu.Name = "txtDichVu";
            txtDichVu.Size = new Size(124, 34);
            txtDichVu.TabIndex = 26;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(85, 32);
            txtTong.Name = "txtTong";
            txtTong.Size = new Size(142, 34);
            txtTong.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(192, 192, 0);
            label8.Location = new Point(6, 32);
            label8.Name = "label8";
            label8.Size = new Size(65, 28);
            label8.TabIndex = 24;
            label8.Text = "Tổng:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPhanTram);
            groupBox1.Controls.Add(txtThanhTien);
            groupBox1.Controls.Add(txtGiamGia);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtDichVu);
            groupBox1.Controls.Add(txtTong);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DeepSkyBlue;
            groupBox1.Location = new Point(51, 464);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 172);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Thanh Toán";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(192, 192, 0);
            label7.Location = new Point(238, 31);
            label7.Name = "label7";
            label7.Size = new Size(91, 28);
            label7.TabIndex = 23;
            label7.Text = "Dịch Vụ:";
            // 
            // btnThemChiTiet
            // 
            btnThemChiTiet.BackColor = Color.Transparent;
            btnThemChiTiet.BackgroundImageLayout = ImageLayout.Zoom;
            btnThemChiTiet.BorderColor = Color.Gray;
            btnThemChiTiet.BorderRadius = 5;
            btnThemChiTiet.BorderThickness = 2;
            btnThemChiTiet.CustomizableEdges = customizableEdges1;
            btnThemChiTiet.DisabledState.BorderColor = Color.DarkGray;
            btnThemChiTiet.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThemChiTiet.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThemChiTiet.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThemChiTiet.FillColor = Color.White;
            btnThemChiTiet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemChiTiet.ForeColor = Color.DeepSkyBlue;
            btnThemChiTiet.Location = new Point(538, 285);
            btnThemChiTiet.Name = "btnThemChiTiet";
            btnThemChiTiet.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnThemChiTiet.Size = new Size(51, 29);
            btnThemChiTiet.TabIndex = 33;
            btnThemChiTiet.Text = ">>>";
            btnThemChiTiet.Click += btnThemChiTiet_Click;
            // 
            // btnXoaChiTiet
            // 
            btnXoaChiTiet.BackColor = Color.Transparent;
            btnXoaChiTiet.BackgroundImageLayout = ImageLayout.Zoom;
            btnXoaChiTiet.BorderColor = Color.Gray;
            btnXoaChiTiet.BorderRadius = 5;
            btnXoaChiTiet.BorderThickness = 2;
            btnXoaChiTiet.CustomizableEdges = customizableEdges3;
            btnXoaChiTiet.DisabledState.BorderColor = Color.DarkGray;
            btnXoaChiTiet.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoaChiTiet.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoaChiTiet.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoaChiTiet.FillColor = Color.White;
            btnXoaChiTiet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaChiTiet.ForeColor = Color.DeepSkyBlue;
            btnXoaChiTiet.Location = new Point(539, 363);
            btnXoaChiTiet.Name = "btnXoaChiTiet";
            btnXoaChiTiet.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnXoaChiTiet.Size = new Size(51, 29);
            btnXoaChiTiet.TabIndex = 32;
            btnXoaChiTiet.Text = "<<<";
            btnXoaChiTiet.Click += btnXoaChiTiet_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(602, 168);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(559, 465);
            dgvSanPham.TabIndex = 31;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNgayLap.ForeColor = Color.FromArgb(192, 192, 0);
            lblNgayLap.Location = new Point(818, 119);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(106, 28);
            lblNgayLap.TabIndex = 29;
            lblNgayLap.Text = "Ngày Lập:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(192, 192, 0);
            label6.Location = new Point(930, 119);
            label6.Name = "label6";
            label6.Size = new Size(101, 28);
            label6.TabIndex = 28;
            label6.Text = "Mã Phiếu";
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaPhieu.ForeColor = Color.FromArgb(192, 192, 0);
            lblMaPhieu.Location = new Point(453, 119);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(106, 28);
            lblMaPhieu.TabIndex = 27;
            lblMaPhieu.Text = "Mã Phiếu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 192, 0);
            label4.Location = new Point(555, 119);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 26;
            label4.Text = "Mã Phiếu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 192, 0);
            label2.Location = new Point(207, 119);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 25;
            label2.Text = "Mã Phiếu";
            // 
            // lblChuSoHuu
            // 
            lblChuSoHuu.AutoSize = true;
            lblChuSoHuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChuSoHuu.ForeColor = Color.FromArgb(192, 192, 0);
            lblChuSoHuu.Location = new Point(85, 119);
            lblChuSoHuu.Name = "lblChuSoHuu";
            lblChuSoHuu.Size = new Size(129, 28);
            lblChuSoHuu.TabIndex = 24;
            lblChuSoHuu.Text = "Chủ Sở Hữu:";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.DeepSkyBlue;
            guna2HtmlLabel1.Location = new Point(355, 15);
            guna2HtmlLabel1.Margin = new Padding(5, 3, 5, 3);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(595, 64);
            guna2HtmlLabel1.TabIndex = 23;
            guna2HtmlLabel1.Text = "CHI TIẾT PHIẾU BÁN HÀNG";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(51, 168);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.Size = new Size(467, 291);
            dgvChiTiet.TabIndex = 30;
            dgvChiTiet.CellEndEdit += dgvChiTiet_CellEndEdit;
            // 
            // frmChiTietPhieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1186, 648);
            Controls.Add(groupBox1);
            Controls.Add(btnThemChiTiet);
            Controls.Add(btnXoaChiTiet);
            Controls.Add(dgvSanPham);
            Controls.Add(lblNgayLap);
            Controls.Add(label6);
            Controls.Add(lblMaPhieu);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lblChuSoHuu);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dgvChiTiet);
            Name = "frmChiTietPhieu";
            Text = "frmChiTietPhieu";
            Load += frmChiTietPhieu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhanTram;
        private TextBox txtThanhTien;
        private TextBox txtGiamGia;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtDichVu;
        private TextBox txtTong;
        private Label label8;
        private GroupBox groupBox1;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Button btnThemChiTiet;
        private Guna.UI2.WinForms.Guna2Button btnXoaChiTiet;
        private DataGridView dgvSanPham;
        private Label lblNgayLap;
        private Label label6;
        private Label lblMaPhieu;
        private Label label4;
        private Label label2;
        private Label lblChuSoHuu;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DataGridView dgvChiTiet;
    }
}