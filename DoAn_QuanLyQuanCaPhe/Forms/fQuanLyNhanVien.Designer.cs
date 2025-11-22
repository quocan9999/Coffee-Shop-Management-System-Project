namespace DoAn_QuanLyQuanCaPhe.Forms
{
    partial class fQuanLyNhanVien
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            grvNhanVien = new DataGridView();
            colIDNV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colLuong = new DataGridViewTextBoxColumn();
            colTrangThaiNV = new DataGridViewTextBoxColumn();
            colTenDangNhap = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnXem = new Button();
            btnXoa = new Button();
            Sửa = new Button();
            btnThem = new Button();
            panel4 = new Panel();
            mtxtDate = new MaskedTextBox();
            button1 = new Button();
            txtSDT = new TextBox();
            txtGioiTinh = new TextBox();
            txtTrangThai = new TextBox();
            txtTenDangNhap = new TextBox();
            txtLuong = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtHoTen = new TextBox();
            txtIDNV = new TextBox();
            label12 = new Label();
            txtTimKiemNV = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grvNhanVien).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 51);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(425, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 31);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhân Viên";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(grvNhanVien);
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(643, 607);
            panel2.TabIndex = 1;
            // 
            // grvNhanVien
            // 
            grvNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colIDNV, colHoTen, colGioiTinh, colNgaySinh, colSDT, colEmail, colDiaChi, colLuong, colTrangThaiNV, colTenDangNhap });
            grvNhanVien.Location = new Point(3, 0);
            grvNhanVien.Name = "grvNhanVien";
            grvNhanVien.RowHeadersWidth = 51;
            grvNhanVien.Size = new Size(637, 607);
            grvNhanVien.TabIndex = 0;
            // 
            // colIDNV
            // 
            colIDNV.HeaderText = "ID";
            colIDNV.MinimumWidth = 6;
            colIDNV.Name = "colIDNV";
            // 
            // colHoTen
            // 
            colHoTen.HeaderText = "Họ Tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            // 
            // colGioiTinh
            // 
            colGioiTinh.HeaderText = "Giới Tính ";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            // 
            // colNgaySinh
            // 
            colNgaySinh.HeaderText = "Ngày Sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            // 
            // colSDT
            // 
            colSDT.HeaderText = "SĐT";
            colSDT.MinimumWidth = 6;
            colSDT.Name = "colSDT";
            // 
            // colEmail
            // 
            colEmail.HeaderText = "EMail";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            // 
            // colDiaChi
            // 
            colDiaChi.HeaderText = "Địa Chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            // 
            // colLuong
            // 
            colLuong.HeaderText = "Lương";
            colLuong.MinimumWidth = 6;
            colLuong.Name = "colLuong";
            // 
            // colTrangThaiNV
            // 
            colTrangThaiNV.HeaderText = "Trạng Thái ";
            colTrangThaiNV.MinimumWidth = 6;
            colTrangThaiNV.Name = "colTrangThaiNV";
            // 
            // colTenDangNhap
            // 
            colTenDangNhap.HeaderText = "Tên Đăng Nhập";
            colTenDangNhap.MinimumWidth = 6;
            colTenDangNhap.Name = "colTenDangNhap";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnXem);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(Sửa);
            panel3.Controls.Add(btnThem);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 664);
            panel3.Name = "panel3";
            panel3.Size = new Size(1182, 89);
            panel3.TabIndex = 2;
            // 
            // btnXem
            // 
            btnXem.Anchor = AnchorStyles.Bottom;
            btnXem.Location = new Point(746, 12);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(106, 62);
            btnXem.TabIndex = 11;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.Location = new Point(482, 12);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(102, 62);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // Sửa
            // 
            Sửa.Anchor = AnchorStyles.Bottom;
            Sửa.Location = new Point(612, 12);
            Sửa.Name = "Sửa";
            Sửa.Size = new Size(106, 62);
            Sửa.TabIndex = 9;
            Sửa.Text = "Sửa";
            Sửa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.Location = new Point(352, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(101, 62);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.BackColor = SystemColors.InactiveCaption;
            panel4.Controls.Add(panel15);
            panel4.Controls.Add(panel14);
            panel4.Controls.Add(panel13);
            panel4.Controls.Add(panel12);
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(mtxtDate);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(txtSDT);
            panel4.Controls.Add(txtGioiTinh);
            panel4.Controls.Add(txtTrangThai);
            panel4.Controls.Add(txtTenDangNhap);
            panel4.Controls.Add(txtLuong);
            panel4.Controls.Add(txtDiaChi);
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(txtHoTen);
            panel4.Controls.Add(txtIDNV);
            panel4.Controls.Add(txtTimKiemNV);
            panel4.Location = new Point(642, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(540, 607);
            panel4.TabIndex = 3;
            // 
            // mtxtDate
            // 
            mtxtDate.Location = new Point(141, 215);
            mtxtDate.Mask = "00/00/0000";
            mtxtDate.Name = "mtxtDate";
            mtxtDate.Size = new Size(128, 27);
            mtxtDate.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(376, 11);
            button1.Name = "button1";
            button1.Size = new Size(112, 72);
            button1.TabIndex = 22;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(403, 215);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 21;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(403, 157);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(125, 27);
            txtGioiTinh.TabIndex = 20;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(403, 450);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(125, 27);
            txtTrangThai.TabIndex = 19;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(141, 450);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(125, 27);
            txtTenDangNhap.TabIndex = 18;
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(141, 387);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(125, 27);
            txtLuong.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(141, 330);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(286, 27);
            txtDiaChi.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 272);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(288, 27);
            txtEmail.TabIndex = 15;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(141, 157);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(128, 27);
            txtHoTen.TabIndex = 13;
            // 
            // txtIDNV
            // 
            txtIDNV.Location = new Point(141, 96);
            txtIDNV.Name = "txtIDNV";
            txtIDNV.Size = new Size(128, 27);
            txtIDNV.TabIndex = 12;
            txtIDNV.TextChanged += txtIDNV_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 3);
            label12.Name = "label12";
            label12.Size = new Size(112, 20);
            label12.TabIndex = 11;
            label12.Text = "Tên Đăng Nhập";
            label12.Click += label12_Click;
            // 
            // txtTimKiemNV
            // 
            txtTimKiemNV.Location = new Point(81, 34);
            txtTimKiemNV.Name = "txtTimKiemNV";
            txtTimKiemNV.Size = new Size(263, 27);
            txtTimKiemNV.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 3);
            label11.Name = "label11";
            label11.Size = new Size(51, 20);
            label11.TabIndex = 9;
            label11.Text = "Lương";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 3);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 8;
            label10.Text = "Trạng Thái";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 3);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 7;
            label9.Text = "Địa Chỉ ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 3);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 6;
            label8.Text = "Email";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 4);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 5;
            label7.Text = "SĐT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 3);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 4;
            label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 3);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 3;
            label5.Text = "Giới Tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 3);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(56, 20);
            label4.TabIndex = 2;
            label4.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 3);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 1;
            label3.Text = "ID";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonFace;
            panel5.Controls.Add(label10);
            panel5.Location = new Point(293, 450);
            panel5.Name = "panel5";
            panel5.Size = new Size(104, 27);
            panel5.TabIndex = 24;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonFace;
            panel6.Controls.Add(label2);
            panel6.Location = new Point(637, 473);
            panel6.Name = "panel6";
            panel6.Size = new Size(104, 27);
            panel6.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 3);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 8;
            label2.Text = "Trạng Thái";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonFace;
            panel7.Controls.Add(label12);
            panel7.Location = new Point(10, 450);
            panel7.Name = "panel7";
            panel7.Size = new Size(125, 27);
            panel7.TabIndex = 25;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ButtonFace;
            panel8.Controls.Add(label11);
            panel8.Location = new Point(10, 387);
            panel8.Name = "panel8";
            panel8.Size = new Size(125, 27);
            panel8.TabIndex = 26;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ButtonFace;
            panel9.Controls.Add(label9);
            panel9.Location = new Point(10, 330);
            panel9.Name = "panel9";
            panel9.Size = new Size(125, 27);
            panel9.TabIndex = 27;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ButtonFace;
            panel10.Controls.Add(label8);
            panel10.Location = new Point(10, 272);
            panel10.Name = "panel10";
            panel10.Size = new Size(125, 27);
            panel10.TabIndex = 28;
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.ButtonFace;
            panel11.Controls.Add(label6);
            panel11.Location = new Point(10, 215);
            panel11.Name = "panel11";
            panel11.Size = new Size(125, 27);
            panel11.TabIndex = 29;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.ButtonFace;
            panel12.Controls.Add(label4);
            panel12.Location = new Point(10, 157);
            panel12.Name = "panel12";
            panel12.Size = new Size(125, 27);
            panel12.TabIndex = 30;
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.ButtonFace;
            panel13.Controls.Add(label3);
            panel13.Location = new Point(10, 96);
            panel13.Name = "panel13";
            panel13.Size = new Size(125, 27);
            panel13.TabIndex = 31;
            // 
            // panel14
            // 
            panel14.BackColor = SystemColors.ButtonFace;
            panel14.Controls.Add(label7);
            panel14.Location = new Point(293, 215);
            panel14.Name = "panel14";
            panel14.Size = new Size(104, 27);
            panel14.TabIndex = 32;
            // 
            // panel15
            // 
            panel15.BackColor = SystemColors.ButtonFace;
            panel15.Controls.Add(label5);
            panel15.Location = new Point(293, 157);
            panel15.Name = "panel15";
            panel15.Size = new Size(104, 27);
            panel15.TabIndex = 33;
            // 
            // fQuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            MinimumSize = new Size(1200, 800);
            Name = "fQuanLyNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grvNhanVien).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView grvNhanVien;
        private DataGridViewTextBoxColumn colIDNV;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colLuong;
        private DataGridViewTextBoxColumn colTrangThaiNV;
        private DataGridViewTextBoxColumn colTenDangNhap;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtTimKiemNV;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox txtSDT;
        private TextBox txtGioiTinh;
        private TextBox txtTrangThai;
        private TextBox txtTenDangNhap;
        private TextBox txtLuong;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtHoTen;
        private TextBox txtIDNV;
        private Label label12;
        private Button btnXem;
        private Button btnXoa;
        private Button Sửa;
        private Button btnThem;
        private MaskedTextBox mtxtDate;
        private Panel panel6;
        private Label label2;
        private Panel panel7;
        private Panel panel5;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel11;
        private Panel panel15;
        private Panel panel14;
        private Panel panel13;
        private Panel panel12;
    }
}