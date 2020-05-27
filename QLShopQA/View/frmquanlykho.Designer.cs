namespace QLShopQA.View
{
    partial class frmquanlykho
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoPhieuX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLyDoXuat = new System.Windows.Forms.TextBox();
            this.btnDauTien = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnCuoiCung = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoPhieuX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SLXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChonPhieu = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phiếu xuất:";
            // 
            // txtSoPhieuX
            // 
            this.txtSoPhieuX.Location = new System.Drawing.Point(256, 37);
            this.txtSoPhieuX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoPhieuX.Name = "txtSoPhieuX";
            this.txtSoPhieuX.Size = new System.Drawing.Size(148, 26);
            this.txtSoPhieuX.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày xuất:";
            // 
            // txtNgayXuat
            // 
            this.txtNgayXuat.CustomFormat = "dd/MM/yyyy";
            this.txtNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayXuat.Location = new System.Drawing.Point(256, 106);
            this.txtNgayXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNgayXuat.Name = "txtNgayXuat";
            this.txtNgayXuat.Size = new System.Drawing.Size(146, 26);
            this.txtNgayXuat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khách hàng:";
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(256, 171);
            this.cboMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(296, 28);
            this.cboMaKH.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lý do xuất:";
            // 
            // txtLyDoXuat
            // 
            this.txtLyDoXuat.Location = new System.Drawing.Point(256, 240);
            this.txtLyDoXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLyDoXuat.Name = "txtLyDoXuat";
            this.txtLyDoXuat.Size = new System.Drawing.Size(296, 26);
            this.txtLyDoXuat.TabIndex = 7;
            // 
            // btnDauTien
            // 
            this.btnDauTien.Location = new System.Drawing.Point(176, 315);
            this.btnDauTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDauTien.Name = "btnDauTien";
            this.btnDauTien.Size = new System.Drawing.Size(112, 35);
            this.btnDauTien.TabIndex = 8;
            this.btnDauTien.Text = "Đầu tiên";
            this.btnDauTien.UseVisualStyleBackColor = true;
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(297, 315);
            this.btnTruoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(112, 35);
            this.btnTruoc.TabIndex = 9;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = true;
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(418, 315);
            this.btnSau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(112, 35);
            this.btnSau.TabIndex = 10;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            // 
            // btnCuoiCung
            // 
            this.btnCuoiCung.Location = new System.Drawing.Point(540, 315);
            this.btnCuoiCung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCuoiCung.Name = "btnCuoiCung";
            this.btnCuoiCung.Size = new System.Drawing.Size(112, 35);
            this.btnCuoiCung.TabIndex = 11;
            this.btnCuoiCung.Text = "Cuối cùng";
            this.btnCuoiCung.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(236, 360);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 35);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(357, 360);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 35);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(478, 360);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 35);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuX,
            this.STT,
            this.MaHang,
            this.SLXuat,
            this.DGXuat,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(75, 451);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1107, 268);
            this.dataGridView1.TabIndex = 15;
            // 
            // SoPhieuX
            // 
            this.SoPhieuX.DataPropertyName = "SoPhieuX";
            this.SoPhieuX.HeaderText = "Số phiếu X";
            this.SoPhieuX.Name = "SoPhieuX";
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "Số TT";
            this.STT.Name = "STT";
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.Name = "MaHang";
            this.MaHang.Width = 200;
            // 
            // SLXuat
            // 
            this.SLXuat.DataPropertyName = "SLXuat";
            this.SLXuat.HeaderText = "Số lượng bán";
            this.SLXuat.Name = "SLXuat";
            // 
            // DGXuat
            // 
            this.DGXuat.DataPropertyName = "DGXuat";
            this.DGXuat.HeaderText = "Đơn giá";
            this.DGXuat.Name = "DGXuat";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(984, 755);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(180, 26);
            this.txtTongTien.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(804, 766);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tổng Tiền Phiếu Xuất:";
            // 
            // btnChonPhieu
            // 
            this.btnChonPhieu.Location = new System.Drawing.Point(442, 34);
            this.btnChonPhieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonPhieu.Name = "btnChonPhieu";
            this.btnChonPhieu.Size = new System.Drawing.Size(112, 35);
            this.btnChonPhieu.TabIndex = 18;
            this.btnChonPhieu.Text = "Chọn phiếu";
            this.btnChonPhieu.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(674, 32);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(219, 35);
            this.btnIn.TabIndex = 19;
            this.btnIn.Text = "In phiếu bán hàng";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // frmquanlykho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 805);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnChonPhieu);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCuoiCung);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnDauTien);
            this.Controls.Add(this.txtLyDoXuat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMaKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNgayXuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoPhieuX);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmquanlykho";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoPhieuX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtNgayXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLyDoXuat;
        private System.Windows.Forms.Button btnDauTien;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnCuoiCung;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuX;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChonPhieu;
        private System.Windows.Forms.Button btnIn;
    }
}