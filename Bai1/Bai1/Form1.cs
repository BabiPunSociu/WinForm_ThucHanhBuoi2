using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Tin học đại cương")
                txtSoTinChi.Text = "2";
            if (comboBox1.SelectedItem == "Giải tích F1")
                txtSoTinChi.Text = "3";
            if (comboBox1.SelectedItem == "Tiếng Anh A0")
                txtSoTinChi.Text = "3";
            if (comboBox1.SelectedItem == "Triết học Mác - Lênin")
                txtSoTinChi.Text = "2";
            if (comboBox1.SelectedItem == "Vật lý F1")
                txtSoTinChi.Text = "3";
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn môn học");
                return;
            }    
            if(txtDiem.Text.Trim() == "" || float.Parse(txtDiem.Text.Trim()) > 10)
            {
                MessageBox.Show("Bạn chưa nhập điểm hoặc nhập điểm > 10");
                return;
            }

            string str = string.Format("{0,20}|{1,1}|{2,3}",comboBox1.Text.Trim(),txtSoTinChi.Text.Trim(),txtDiem.Text.Trim());
            lstMonHoc.Items.Add(str);

            comboBox1.Text = "";
            txtSoTinChi.Clear();
            txtDiem.Clear();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int tongTinChi = 0;
            double tongDiem = 0;

            foreach(string str in lstMonHoc.Items)
            {
                string[] substr = str.Split('|');
                tongTinChi += int.Parse(substr[1].Trim());
                tongDiem += double.Parse(substr[2].Trim())* int.Parse(substr[1].Trim());
            }    

            txtTongTinChi.Text = tongTinChi.ToString();
            txtTongDiem.Text = tongDiem.ToString();
            txtDTB.Text = (tongDiem / tongTinChi).ToString();
        }
    }
}
