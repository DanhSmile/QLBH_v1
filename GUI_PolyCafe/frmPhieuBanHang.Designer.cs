namespace GUI_PolyCafe
{
    partial class frmPhieuBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuBanHang));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dtpNgayTao = new DateTimePicker();
            cboNhanVienBH = new ComboBox();
            btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            cboMaTheLuuDong = new ComboBox();
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            rdoDaThanhToan = new RadioButton();
            btnSua = new Guna.UI2.WinForms.Guna2Button();
            rdoChoXacNhan = new RadioButton();
            btnThem = new Guna.UI2.WinForms.Guna2Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMaPhieu = new TextBox();
            dgvDanhSachPhieu = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieu).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.Format = DateTimePickerFormat.Custom;
            dtpNgayTao.Location = new Point(518, 131);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(179, 34);
            dtpNgayTao.TabIndex = 25;
            // 
            // cboNhanVienBH
            // 
            cboNhanVienBH.FormattingEnabled = true;
            cboNhanVienBH.Location = new Point(199, 129);
            cboNhanVienBH.Name = "cboNhanVienBH";
            cboNhanVienBH.Size = new Size(177, 36);
            cboNhanVienBH.TabIndex = 24;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Transparent;
            btnLamMoi.BorderColor = Color.Gray;
            btnLamMoi.BorderRadius = 10;
            btnLamMoi.BorderThickness = 3;
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.CustomizableEdges = customizableEdges1;
            btnLamMoi.DisabledState.BorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLamMoi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLamMoi.FillColor = Color.White;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.DeepSkyBlue;
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.Location = new Point(1111, 151);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLamMoi.Size = new Size(122, 53);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // cboMaTheLuuDong
            // 
            cboMaTheLuuDong.FormattingEnabled = true;
            cboMaTheLuuDong.Location = new Point(520, 58);
            cboMaTheLuuDong.Name = "cboMaTheLuuDong";
            cboMaTheLuuDong.Size = new Size(177, 36);
            cboMaTheLuuDong.TabIndex = 22;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Transparent;
            btnXoa.BorderColor = Color.Gray;
            btnXoa.BorderRadius = 10;
            btnXoa.BorderThickness = 3;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.CustomizableEdges = customizableEdges3;
            btnXoa.DisabledState.BorderColor = Color.DarkGray;
            btnXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoa.FillColor = Color.White;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.DeepSkyBlue;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(835, 151);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnXoa.Size = new Size(122, 53);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // rdoDaThanhToan
            // 
            rdoDaThanhToan.AutoSize = true;
            rdoDaThanhToan.Location = new Point(491, 201);
            rdoDaThanhToan.Name = "rdoDaThanhToan";
            rdoDaThanhToan.Size = new Size(169, 32);
            rdoDaThanhToan.TabIndex = 19;
            rdoDaThanhToan.Text = "Đã thanh toán";
            rdoDaThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Transparent;
            btnSua.BorderColor = Color.Gray;
            btnSua.BorderRadius = 10;
            btnSua.BorderThickness = 3;
            btnSua.Cursor = Cursors.Hand;
            btnSua.CustomizableEdges = customizableEdges5;
            btnSua.DisabledState.BorderColor = Color.DarkGray;
            btnSua.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSua.FillColor = Color.White;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.DeepSkyBlue;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(1111, 57);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSua.Size = new Size(122, 53);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // rdoChoXacNhan
            // 
            rdoChoXacNhan.AutoSize = true;
            rdoChoXacNhan.Checked = true;
            rdoChoXacNhan.Location = new Point(215, 201);
            rdoChoXacNhan.Name = "rdoChoXacNhan";
            rdoChoXacNhan.Size = new Size(161, 32);
            rdoChoXacNhan.TabIndex = 18;
            rdoChoXacNhan.TabStop = true;
            rdoChoXacNhan.Text = "Chờ xác nhận";
            rdoChoXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Transparent;
            btnThem.BorderColor = Color.Gray;
            btnThem.BorderRadius = 10;
            btnThem.BorderThickness = 3;
            btnThem.Cursor = Cursors.Hand;
            btnThem.CustomizableEdges = customizableEdges7;
            btnThem.DisabledState.BorderColor = Color.DarkGray;
            btnThem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThem.FillColor = Color.White;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.DeepSkyBlue;
            btnThem.Image = Properties.Resources.addc;
            btnThem.Location = new Point(835, 57);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnThem.Size = new Size(122, 53);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(192, 192, 0);
            label6.Location = new Point(400, 137);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 15;
            label6.Text = "Ngày tạo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(192, 192, 0);
            label4.Location = new Point(400, 58);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 13;
            label4.Text = "Mã thẻ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(192, 192, 0);
            label3.Location = new Point(37, 201);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 12;
            label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(192, 192, 0);
            label2.Location = new Point(36, 131);
            label2.Name = "label2";
            label2.Size = new Size(141, 28);
            label2.TabIndex = 11;
            label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(192, 192, 0);
            label1.Location = new Point(36, 57);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 10;
            label1.Text = "Mã phiếu";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(199, 58);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(177, 34);
            txtMaPhieu.TabIndex = 3;
            // 
            // dgvDanhSachPhieu
            // 
            dgvDanhSachPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachPhieu.Location = new Point(6, 44);
            dgvDanhSachPhieu.Name = "dgvDanhSachPhieu";
            dgvDanhSachPhieu.RowHeadersWidth = 51;
            dgvDanhSachPhieu.Size = new Size(1435, 418);
            dgvDanhSachPhieu.TabIndex = 0;
            dgvDanhSachPhieu.CellClick += dgvDanhSachPhieu_CellClick;
            dgvDanhSachPhieu.CellDoubleClick += dgvDanhSachPhieu_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayTao);
            groupBox1.Controls.Add(cboNhanVienBH);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(cboMaTheLuuDong);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(rdoDaThanhToan);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(rdoChoXacNhan);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaPhieu);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DeepSkyBlue;
            groupBox1.Location = new Point(13, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1463, 274);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phiếu";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDanhSachPhieu);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.DeepSkyBlue;
            groupBox2.Location = new Point(12, 379);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1463, 468);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phiếu";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.DeepSkyBlue;
            guna2HtmlLabel1.Location = new Point(556, 7);
            guna2HtmlLabel1.Margin = new Padding(4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(397, 64);
            guna2HtmlLabel1.TabIndex = 13;
            guna2HtmlLabel1.Text = "PHIẾU BÁN HÀNG";
            // 
            // frmPhieuBanHang
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1502, 953);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(guna2HtmlLabel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmPhieuBanHang";
            Text = "frmPhieuBanHang";
            Load += frmPhieuBanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieu).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNgayTao;
        private ComboBox cboNhanVienBH;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private ComboBox cboMaTheLuuDong;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private RadioButton rdoDaThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private RadioButton rdoChoXacNhan;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMaPhieu;
        private DataGridView dgvDanhSachPhieu;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}