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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChiNhapSo_KeyPess(object sender, KeyPressEventArgs e)
        {
            if( !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtTienGui.Clear();

            dateTimePicker1.Text = DateTime.Now.ToString();
            cbbox.Text = "";
            cbbox.SelectedIndex = -1;
            rdoThuong.Checked = false;
            rdoPhatLoc.Checked = false;

            txtMaKH.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnThemVao_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text.Trim().Length < 6)
            {
                MessageBox.Show("Nhập lại vì mã dưới 6 số");
                txtMaKH.Text = " ";
                txtMaKH.Focus();
                return;
            }    
            if(txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Không được để trống họ tên");
                txtHoTen.Text = " ";
                txtHoTen.Focus();
                return;
            }    
            if(txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Không được để trống địa chỉ");
                txtDiaChi.Text = " ";
                txtDiaChi.Focus();
                return;
            }

            if(double.Parse(txtTienGui.Text.Trim()) == 0)
            {
                MessageBox.Show("Nhập số tiền gửi");
                txtTienGui.Text = " ";
                txtTienGui.Focus();
                return;
            }    
            if(cbbox.Text == "" || !(cbbox.SelectedItem=="1" || cbbox.SelectedItem == "3" 
                || cbbox.SelectedItem == "6" || cbbox.SelectedItem == "12"))
            {
                MessageBox.Show("Nhập thời gian gửi 1-3-6-12 tháng");
                cbbox.Text = " ";
                return;
            }
            if(!rdoPhatLoc.Checked && !rdoThuong.Checked)
            {
                MessageBox.Show("Chưa chọn loại tiết kiệm");
                return;
            }
            double tienlai = 0;
            if(rdoThuong.Checked)
            {
                if (cbbox.SelectedItem == "1" || int.Parse(cbbox.Text.Trim()) == 1)
                    tienlai = int.Parse(txtTienGui.Text.Trim()) * 0.06;
                if (cbbox.SelectedItem == "3" || int.Parse(cbbox.Text.Trim()) == 3)
                    tienlai = int.Parse(txtTienGui.Text.Trim()) * 0.07;
                if (cbbox.SelectedItem == "6" || int.Parse(cbbox.Text.Trim()) == 6)
                    tienlai = int.Parse(txtTienGui.Text.Trim()) * 0.08;
                if (cbbox.SelectedItem == "12" || int.Parse(cbbox.Text.Trim()) == 12)
                    tienlai = int.Parse(txtTienGui.Text.Trim()) * 0.09;
            }    
            else
            {
                if (cbbox.SelectedItem == "1" || int.Parse(cbbox.Text.Trim()) == 1)
                    tienlai = int.Parse(txtTienGui.Text.Trim()) * 0.07;
                if (cbbox.SelectedItem == "3" || int.Parse(cbbox.Text.Trim()) == 3)
                    tienlai = int.Parse(txtTienGui.Text.Trim()) * 0.08;
                if (cbbox.SelectedItem == "6" || int.Parse(cbbox.Text.Trim()) == 6)
                    tienlai = int.Parse(txtTienGui.Text.Trim()) * 0.09;
                if (cbbox.SelectedItem == "12" || int.Parse(cbbox.Text.Trim()) == 12)
                    tienlai = int.Parse(txtTienGui.Text.Trim()) * 0.1;
            }
            DateTime dt = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            GuiTien GT = new GuiTien(int.Parse(txtMaKH.Text.Trim()), txtHoTen.Text.Trim(), txtDiaChi.Text.Trim(),int.Parse(txtTienGui.Text.Trim()),dt, int.Parse(cbbox.Text.Trim()),(rdoThuong.Checked==true? true:false),tienlai);
            
            // Kiem tra mã KH đã tồn tại -> không cho thêm
            foreach(GuiTien guiTien in DataBase.Data)
            {
                if(guiTien.get_MaKH() == GT.get_MaKH())
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại");
                    return;
                }    
            }    

            DataBase.Data.Add(GT);
            lstKH.Items.Add(GT.xuat());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form_TimKiem frm = new Form_TimKiem();
            frm.ShowDialog();
        }
    }
}
