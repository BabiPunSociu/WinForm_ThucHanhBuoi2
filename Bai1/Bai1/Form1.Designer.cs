namespace Bai1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstMonHoc = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTongTinChi = new System.Windows.Forms.TextBox();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picAnh);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.txtSoTinChi);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 504);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstMonHoc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(458, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 314);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tín chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tin học đại cương",
            "Giải tích F1",
            "Tiếng Anh A0",
            "Triết học Mác - Lênin",
            "Vật lý F1"});
            this.comboBox1.Location = new System.Drawing.Point(29, 245);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(402, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.ForeColor = System.Drawing.Color.Red;
            this.txtSoTinChi.Location = new System.Drawing.Point(29, 323);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.ReadOnly = true;
            this.txtSoTinChi.Size = new System.Drawing.Size(402, 27);
            this.txtSoTinChi.TabIndex = 4;
            // 
            // txtDiem
            // 
            this.txtDiem.ForeColor = System.Drawing.Color.Red;
            this.txtDiem.Location = new System.Drawing.Point(29, 403);
            this.txtDiem.MaxLength = 3;
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(402, 27);
            this.txtDiem.TabIndex = 5;
            this.txtDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiem_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 452);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(400, 33);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm vào &DS";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstMonHoc
            // 
            this.lstMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMonHoc.ForeColor = System.Drawing.Color.Red;
            this.lstMonHoc.FormattingEnabled = true;
            this.lstMonHoc.ItemHeight = 20;
            this.lstMonHoc.Location = new System.Drawing.Point(3, 23);
            this.lstMonHoc.Name = "lstMonHoc";
            this.lstMonHoc.Size = new System.Drawing.Size(668, 288);
            this.lstMonHoc.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng số tín chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(804, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng số điểm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Điểm trung bình";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(488, 451);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(229, 33);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "&Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(880, 451);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(229, 33);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTongTinChi
            // 
            this.txtTongTinChi.ForeColor = System.Drawing.Color.Red;
            this.txtTongTinChi.Location = new System.Drawing.Point(621, 323);
            this.txtTongTinChi.Name = "txtTongTinChi";
            this.txtTongTinChi.ReadOnly = true;
            this.txtTongTinChi.Size = new System.Drawing.Size(177, 27);
            this.txtTongTinChi.TabIndex = 9;
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.ForeColor = System.Drawing.Color.Red;
            this.txtTongDiem.Location = new System.Drawing.Point(932, 323);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.ReadOnly = true;
            this.txtTongDiem.Size = new System.Drawing.Size(177, 27);
            this.txtTongDiem.TabIndex = 10;
            // 
            // txtDTB
            // 
            this.txtDTB.ForeColor = System.Drawing.Color.Red;
            this.txtDTB.Location = new System.Drawing.Point(649, 384);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.ReadOnly = true;
            this.txtDTB.Size = new System.Drawing.Size(460, 27);
            this.txtDTB.TabIndex = 11;
            // 
            // picAnh
            // 
            this.picAnh.Image = ((System.Drawing.Image)(resources.GetObject("picAnh.Image")));
            this.picAnh.Location = new System.Drawing.Point(29, 37);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(399, 164);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 7;
            this.picAnh.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1132, 504);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.txtTongTinChi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTongTinChi;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.TextBox txtDTB;
    }
}

