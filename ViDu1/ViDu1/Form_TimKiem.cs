using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDu1
{
    public partial class Form_TimKiem : Form
    {
        public Form_TimKiem()
        {
            InitializeComponent();
        }

        List<GuiTien> guiTiens = DataBase.Data;

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            /*
            // reset các ô trạng thái
            txtMaKH1.Clear();
            txtHoTen1.Clear();
            txtDiaChi1.Clear();
            txtTienGui1.Clear();

            dateTimePicker2.Text = DateTime.Now.ToString();
            cbbox1.Text = "";
            cbbox1.SelectedIndex = -1;
            rdoThuong1.Checked = false;
            rdoPhatLoc1.Checked = false;

            lblKetQua.Text = "";

            txtMaKH1.Focus();
            */
            // Kiểm tra nhập mã KH
            if (txtMaKH1.Text.Trim().Length < 6)
            {
                MessageBox.Show("Nhập lại vì mã dưới 6 số");
                txtMaKH1.Text = " ";
                txtMaKH1.Focus();
                return;
            }
            foreach (GuiTien GT in guiTiens)
            {
                if(GT.get_MaKH() == Convert.ToInt32(txtMaKH1.Text.Trim()))
                {
                    txtHoTen1.Text = GT.get_Hoten();
                    txtDiaChi1.Text = GT.get_DiaChi();
                    txtTienGui1.Text = GT.get_SoTienGui().ToString();
                    dateTimePicker2.Value = GT.get_ngayGui();
                    cbbox1.Text = GT.get_thoiGianGui().ToString();
                    if (GT.get_loaiTK() == true)
                        rdoThuong1.Checked = true;
                    else
                        rdoPhatLoc1.Checked = true;
                    lblKetQua.Text = "Khách hàng " + GT.get_Hoten() + " phải trả " + GT.get_tienlai() + " tiền lãi";
                    return;
                }    
            }
            lblKetQua.Text = "Không tìm thấy mã khách hàng " + txtMaKH1.Text.Trim();
        }

        private void ChiNhapSo_KeyPess(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
