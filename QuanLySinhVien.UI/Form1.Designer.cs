namespace QuanLySinhVien.UI_
{
    partial class Form1
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
            dgvSinhVien = new DataGridView();
            btnSua = new Button();
            btnLocDat = new Button();
            btnTaiLai = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtDiem = new TextBox();
            txtHoTen = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            lblTrangThai = new Label();
            lblKetqua = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(141, 293);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 82;
            dgvSinhVien.Size = new Size(1124, 392);
            dgvSinhVien.TabIndex = 30;
            dgvSinhVien.CellContentClick += dgvSinhVien_CellContentClick;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(325, 186);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 74);
            btnSua.TabIndex = 29;
            btnSua.Text = "sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLocDat
            // 
            btnLocDat.Location = new Point(1000, 186);
            btnLocDat.Name = "btnLocDat";
            btnLocDat.Size = new Size(244, 74);
            btnLocDat.TabIndex = 25;
            btnLocDat.Text = "Lọc SV đạt(LING)";
            btnLocDat.UseVisualStyleBackColor = true;
            btnLocDat.Click += btnLocDat_Click;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(704, 186);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(234, 74);
            btnTaiLai.TabIndex = 26;
            btnTaiLai.Text = "Tải lại danh";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(515, 186);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 74);
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(131, 186);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 74);
            btnThem.TabIndex = 28;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(793, 111);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(200, 39);
            txtDiem.TabIndex = 23;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(298, 111);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(334, 39);
            txtHoTen.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(417, 41);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(284, 30);
            label4.Name = "label4";
            label4.Size = new Size(812, 50);
            label4.TabIndex = 19;
            label4.Text = "Quản lý sinh viên - EF CORE (CRUD ĐẦY ĐỦ)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(704, 118);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 20;
            label2.Text = "Điểm";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(141, 716);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(101, 32);
            lblTrangThai.TabIndex = 21;
            lblTrangThai.Text = "Ket qua:";
            lblTrangThai.Click += lblTrangThai_Click;
            // 
            // lblKetqua
            // 
            lblKetqua.AutoSize = true;
            lblKetqua.Location = new Point(187, 118);
            lblKetqua.Name = "lblKetqua";
            lblKetqua.Size = new Size(87, 32);
            lblKetqua.TabIndex = 22;
            lblKetqua.Text = "Họ tên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 778);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnSua);
            Controls.Add(btnLocDat);
            Controls.Add(btnTaiLai);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtDiem);
            Controls.Add(txtHoTen);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lblTrangThai);
            Controls.Add(lblKetqua);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSinhVien;
        private Button btnSua;
        private Button btnLocDat;
        private Button btnTaiLai;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtDiem;
        private TextBox txtHoTen;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label lblTrangThai;
        private Label lblKetqua;
    }
}
