﻿namespace ViDu1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTienGui = new System.Windows.Forms.TextBox();
            this.cbbox = new System.Windows.Forms.ComboBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemVao = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoPhatLoc = new System.Windows.Forms.RadioButton();
            this.rdoThuong = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstKH = new System.Windows.Forms.ListBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTienGui);
            this.groupBox1.Controls.Add(this.cbbox);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemVao);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 259);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(153, 41);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(243, 27);
            this.txtMaKH.TabIndex = 14;
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChiNhapSo_KeyPess);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(153, 98);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(243, 27);
            this.txtHoTen.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(153, 156);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(243, 27);
            this.txtDiaChi.TabIndex = 12;
            // 
            // txtTienGui
            // 
            this.txtTienGui.Location = new System.Drawing.Point(153, 209);
            this.txtTienGui.Name = "txtTienGui";
            this.txtTienGui.Size = new System.Drawing.Size(243, 27);
            this.txtTienGui.TabIndex = 11;
            this.txtTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChiNhapSo_KeyPess);
            // 
            // cbbox
            // 
            this.cbbox.FormattingEnabled = true;
            this.cbbox.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12"});
            this.cbbox.Location = new System.Drawing.Point(151, 312);
            this.cbbox.Name = "cbbox";
            this.cbbox.Size = new System.Drawing.Size(245, 28);
            this.cbbox.TabIndex = 9;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(273, 462);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(123, 31);
            this.btnThemMoi.TabIndex = 8;
            this.btnThemMoi.Text = "Thêm &mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThemVao
            // 
            this.btnThemVao.Location = new System.Drawing.Point(16, 462);
            this.btnThemVao.Name = "btnThemVao";
            this.btnThemVao.Size = new System.Drawing.Size(123, 31);
            this.btnThemVao.TabIndex = 7;
            this.btnThemVao.Text = "Thêm vào";
            this.btnThemVao.UseVisualStyleBackColor = true;
            this.btnThemVao.Click += new System.EventHandler(this.btnThemVao_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoPhatLoc);
            this.groupBox3.Controls.Add(this.rdoThuong);
            this.groupBox3.Location = new System.Drawing.Point(16, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 70);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại tiết kiệm";
            // 
            // rdoPhatLoc
            // 
            this.rdoPhatLoc.AutoSize = true;
            this.rdoPhatLoc.Location = new System.Drawing.Point(196, 31);
            this.rdoPhatLoc.Name = "rdoPhatLoc";
            this.rdoPhatLoc.Size = new System.Drawing.Size(91, 24);
            this.rdoPhatLoc.TabIndex = 1;
            this.rdoPhatLoc.TabStop = true;
            this.rdoPhatLoc.Text = "Phát lộc";
            this.rdoPhatLoc.UseVisualStyleBackColor = true;
            // 
            // rdoThuong
            // 
            this.rdoThuong.AutoSize = true;
            this.rdoThuong.Location = new System.Drawing.Point(18, 31);
            this.rdoThuong.Name = "rdoThuong";
            this.rdoThuong.Size = new System.Drawing.Size(85, 24);
            this.rdoThuong.TabIndex = 0;
            this.rdoThuong.TabStop = true;
            this.rdoThuong.Text = "Thường";
            this.rdoThuong.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thời gian gửi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày gửi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiền gửi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstKH);
            this.groupBox2.Location = new System.Drawing.Point(417, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 457);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // lstKH
            // 
            this.lstKH.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lstKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstKH.ForeColor = System.Drawing.Color.Red;
            this.lstKH.FormattingEnabled = true;
            this.lstKH.ItemHeight = 20;
            this.lstKH.Location = new System.Drawing.Point(3, 23);
            this.lstKH.Name = "lstKH";
            this.lstKH.Size = new System.Drawing.Size(759, 431);
            this.lstKH.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(815, 481);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 31);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1007, 481);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 31);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1184, 533);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ví dụ 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTienGui;
        private System.Windows.Forms.ComboBox cbbox;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemVao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoPhatLoc;
        private System.Windows.Forms.RadioButton rdoThuong;
        private System.Windows.Forms.ListBox lstKH;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
    }
}

