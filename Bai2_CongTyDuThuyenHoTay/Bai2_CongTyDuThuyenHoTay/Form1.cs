using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_CongTyDuThuyenHoTay
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            rdoCaNgay.Checked = false;
            rdoNuaNgay.Checked = false;
            txtDuThuyen.Clear();
            txtTienNuoc.Clear();
            comboDoUong.SelectedIndex = -1;
            comboDoUong.Text = "";
            comboSoLuong.SelectedIndex = -1;
            comboSoLuong.Text = "";
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCaNgay.Checked)
                txtDuThuyen.Text = "200";
            if (rdoNuaNgay.Checked)
                txtDuThuyen.Text = "100";
        }
        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên");
                txtHoTen.Clear();
                txtHoTen.Focus();
                return;
            }    
            if(rdoCaNgay.Checked == false && rdoNuaNgay.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn dịch vụ du thuyền");
                return;
            }    
            if(comboDoUong.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn đồ uống");
                return;
            }
            if (comboSoLuong.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn số lượng đồ uống");
                return;
            }

            
            string str = string.Format("{0,25}|{1,8}|{2,3}$|Đồ uống {3,2}$|Tổng {4}$", txtHoTen.Text.Trim(),
                (rdoCaNgay.Checked == true ? "Cả Ngày" : "Nửa Ngày"),txtDuThuyen.Text.Trim()
                ,txtTienNuoc.Text.Trim(),
                (float.Parse(txtDuThuyen.Text.Trim())+float.Parse(txtTienNuoc.Text.Trim())).ToString());
            lstKQ.Items.Add(str);
        }
        void tien_nuoc(int x=1)
        {
            if (comboDoUong.SelectedIndex == 0)
                txtTienNuoc.Text = (0.5 * x).ToString();
            if (comboDoUong.SelectedIndex == 1)
                txtTienNuoc.Text = (0.8 * x).ToString();
            if (comboDoUong.SelectedIndex == 2)
                txtTienNuoc.Text = (1.0 * x).ToString();
        }
        private void comboDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            tien_nuoc();
        }

        private void comboSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboSoLuong.Text != "")
                tien_nuoc(int.Parse(comboSoLuong.Text));
        }
    }
}
