namespace ViDu1
{
    partial class Form_TimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TimKiem));
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtMaKH1 = new System.Windows.Forms.TextBox();
            this.txtHoTen1 = new System.Windows.Forms.TextBox();
            this.txtDiaChi1 = new System.Windows.Forms.TextBox();
            this.txtTienGui1 = new System.Windows.Forms.TextBox();
            this.cbbox1 = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoPhatLoc1 = new System.Windows.Forms.RadioButton();
            this.rdoThuong1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(169, 230);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(245, 27);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // txtMaKH1
            // 
            this.txtMaKH1.Location = new System.Drawing.Point(171, 12);
            this.txtMaKH1.Name = "txtMaKH1";
            this.txtMaKH1.Size = new System.Drawing.Size(243, 27);
            this.txtMaKH1.TabIndex = 29;
            this.txtMaKH1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChiNhapSo_KeyPess);
            // 
            // txtHoTen1
            // 
            this.txtHoTen1.Location = new System.Drawing.Point(171, 69);
            this.txtHoTen1.Name = "txtHoTen1";
            this.txtHoTen1.Size = new System.Drawing.Size(243, 27);
            this.txtHoTen1.TabIndex = 28;
            // 
            // txtDiaChi1
            // 
            this.txtDiaChi1.Location = new System.Drawing.Point(171, 127);
            this.txtDiaChi1.Name = "txtDiaChi1";
            this.txtDiaChi1.Size = new System.Drawing.Size(243, 27);
            this.txtDiaChi1.TabIndex = 27;
            // 
            // txtTienGui1
            // 
            this.txtTienGui1.Location = new System.Drawing.Point(171, 180);
            this.txtTienGui1.Name = "txtTienGui1";
            this.txtTienGui1.Size = new System.Drawing.Size(243, 27);
            this.txtTienGui1.TabIndex = 26;
            // 
            // cbbox1
            // 
            this.cbbox1.FormattingEnabled = true;
            this.cbbox1.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12"});
            this.cbbox1.Location = new System.Drawing.Point(169, 283);
            this.cbbox1.Name = "cbbox1";
            this.cbbox1.Size = new System.Drawing.Size(245, 28);
            this.cbbox1.TabIndex = 25;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(291, 519);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 31);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(34, 519);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(123, 31);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoPhatLoc1);
            this.groupBox3.Controls.Add(this.rdoThuong1);
            this.groupBox3.Location = new System.Drawing.Point(34, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 70);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại tiết kiệm";
            // 
            // rdoPhatLoc1
            // 
            this.rdoPhatLoc1.AutoSize = true;
            this.rdoPhatLoc1.Location = new System.Drawing.Point(196, 31);
            this.rdoPhatLoc1.Name = "rdoPhatLoc1";
            this.rdoPhatLoc1.Size = new System.Drawing.Size(91, 24);
            this.rdoPhatLoc1.TabIndex = 1;
            this.rdoPhatLoc1.TabStop = true;
            this.rdoPhatLoc1.Text = "Phát lộc";
            this.rdoPhatLoc1.UseVisualStyleBackColor = true;
            // 
            // rdoThuong1
            // 
            this.rdoThuong1.AutoSize = true;
            this.rdoThuong1.Location = new System.Drawing.Point(18, 31);
            this.rdoThuong1.Name = "rdoThuong1";
            this.rdoThuong1.Size = new System.Drawing.Size(85, 24);
            this.rdoThuong1.TabIndex = 0;
            this.rdoThuong1.TabStop = true;
            this.rdoThuong1.Text = "Thường";
            this.rdoThuong1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Thời gian gửi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ngày gửi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số tiền gửi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Họ tên KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã KH";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(38, 423);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 20);
            this.lblKetQua.TabIndex = 30;
            // 
            // Form_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(445, 562);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txtMaKH1);
            this.Controls.Add(this.txtHoTen1);
            this.Controls.Add(this.txtDiaChi1);
            this.Controls.Add(this.txtTienGui1);
            this.Controls.Add(this.cbbox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_TimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtMaKH1;
        private System.Windows.Forms.TextBox txtHoTen1;
        private System.Windows.Forms.TextBox txtDiaChi1;
        private System.Windows.Forms.TextBox txtTienGui1;
        private System.Windows.Forms.ComboBox cbbox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoPhatLoc1;
        private System.Windows.Forms.RadioButton rdoThuong1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKetQua;
    }
}