namespace Bai2_CongTyDuThuyenHoTay
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoCaNgay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoNuaNgay = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuThuyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboDoUong = new System.Windows.Forms.ComboBox();
            this.comboSoLuong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTienNuoc = new System.Windows.Forms.TextBox();
            this.btnThemVaoDS = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstKQ = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemVaoDS);
            this.groupBox1.Controls.Add(this.txtTienNuoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboSoLuong);
            this.groupBox1.Controls.Add(this.comboDoUong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDuThuyen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.rdoNuaNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdoCaNgay);
            this.groupBox1.Location = new System.Drawing.Point(21, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstKQ);
            this.groupBox2.Location = new System.Drawing.Point(579, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 401);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Khách Hàng Đặt Tour";
            // 
            // rdoCaNgay
            // 
            this.rdoCaNgay.AutoSize = true;
            this.rdoCaNgay.Location = new System.Drawing.Point(33, 92);
            this.rdoCaNgay.Name = "rdoCaNgay";
            this.rdoCaNgay.Size = new System.Drawing.Size(91, 24);
            this.rdoCaNgay.TabIndex = 0;
            this.rdoCaNgay.TabStop = true;
            this.rdoCaNgay.Text = "Cả ngày";
            this.rdoCaNgay.UseVisualStyleBackColor = true;
            this.rdoCaNgay.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ Tên";
            // 
            // rdoNuaNgay
            // 
            this.rdoNuaNgay.AutoSize = true;
            this.rdoNuaNgay.Location = new System.Drawing.Point(231, 92);
            this.rdoNuaNgay.Name = "rdoNuaNgay";
            this.rdoNuaNgay.Size = new System.Drawing.Size(100, 24);
            this.rdoNuaNgay.TabIndex = 2;
            this.rdoNuaNgay.TabStop = true;
            this.rdoNuaNgay.Text = "Nửa ngày";
            this.rdoNuaNgay.UseVisualStyleBackColor = true;
            this.rdoNuaNgay.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(110, 44);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(411, 27);
            this.txtHoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá Du Thuyền";
            // 
            // txtDuThuyen
            // 
            this.txtDuThuyen.Location = new System.Drawing.Point(169, 142);
            this.txtDuThuyen.Name = "txtDuThuyen";
            this.txtDuThuyen.ReadOnly = true;
            this.txtDuThuyen.Size = new System.Drawing.Size(324, 27);
            this.txtDuThuyen.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chọn Đồ Uống";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tiền";
            // 
            // comboDoUong
            // 
            this.comboDoUong.FormattingEnabled = true;
            this.comboDoUong.Items.AddRange(new object[] {
            "Coca cola",
            "Pepsi",
            "Seven up"});
            this.comboDoUong.Location = new System.Drawing.Point(33, 240);
            this.comboDoUong.Name = "comboDoUong";
            this.comboDoUong.Size = new System.Drawing.Size(114, 28);
            this.comboDoUong.TabIndex = 10;
            this.comboDoUong.SelectedIndexChanged += new System.EventHandler(this.comboDoUong_SelectedIndexChanged);
            // 
            // comboSoLuong
            // 
            this.comboSoLuong.FormattingEnabled = true;
            this.comboSoLuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboSoLuong.Location = new System.Drawing.Point(199, 240);
            this.comboSoLuong.Name = "comboSoLuong";
            this.comboSoLuong.Size = new System.Drawing.Size(114, 28);
            this.comboSoLuong.TabIndex = 11;
            this.comboSoLuong.SelectedIndexChanged += new System.EventHandler(this.comboSoLuong_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "$";
            // 
            // txtTienNuoc
            // 
            this.txtTienNuoc.ForeColor = System.Drawing.Color.Red;
            this.txtTienNuoc.Location = new System.Drawing.Point(346, 240);
            this.txtTienNuoc.Name = "txtTienNuoc";
            this.txtTienNuoc.ReadOnly = true;
            this.txtTienNuoc.Size = new System.Drawing.Size(114, 27);
            this.txtTienNuoc.TabIndex = 14;
            // 
            // btnThemVaoDS
            // 
            this.btnThemVaoDS.Location = new System.Drawing.Point(33, 319);
            this.btnThemVaoDS.Name = "btnThemVaoDS";
            this.btnThemVaoDS.Size = new System.Drawing.Size(220, 37);
            this.btnThemVaoDS.TabIndex = 15;
            this.btnThemVaoDS.Text = "Thêm Vào DS";
            this.btnThemVaoDS.UseVisualStyleBackColor = true;
            this.btnThemVaoDS.Click += new System.EventHandler(this.btnThemVaoDS_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(301, 319);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(220, 37);
            this.btnThemMoi.TabIndex = 16;
            this.btnThemMoi.Text = "Thêm &Mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(942, 435);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(220, 37);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lstKQ
            // 
            this.lstKQ.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lstKQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstKQ.FormattingEnabled = true;
            this.lstKQ.ItemHeight = 20;
            this.lstKQ.Location = new System.Drawing.Point(3, 23);
            this.lstKQ.Name = "lstKQ";
            this.lstKQ.Size = new System.Drawing.Size(585, 375);
            this.lstKQ.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1174, 478);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 2: Công ty du thuyền Hồ Tây";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemVaoDS;
        private System.Windows.Forms.TextBox txtTienNuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboSoLuong;
        private System.Windows.Forms.ComboBox comboDoUong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDuThuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.RadioButton rdoNuaNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoCaNgay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstKQ;
        private System.Windows.Forms.Button btnThoat;
    }
}

