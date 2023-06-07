using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDu1
{
    class GuiTien
    {
        private int MaKH;
        private string Hoten;
        private string DiaChi;
        private int SoTienGui;
        private DateTime ngayGui;
        private int thoiGianGui;
        private bool loaiTK;   // true = Thuong     false = phat loc
        private double tienlai;

        public GuiTien(int maKH, string hoten, string diaChi, int soTienGui, DateTime ngayGui, int thoiGianGui, bool loaiTK, double tienlai)
        {
            MaKH = maKH;
            Hoten = hoten;
            DiaChi = diaChi;
            SoTienGui = soTienGui;
            this.ngayGui = ngayGui;
            this.thoiGianGui = thoiGianGui;
            this.loaiTK = loaiTK;
            this.tienlai = tienlai;
        }

        public int get_MaKH() { return MaKH; }
        public string get_Hoten() { return Hoten; }
        public string get_DiaChi() { return DiaChi; }
        public int get_SoTienGui() { return SoTienGui; }
        public DateTime get_ngayGui() { return ngayGui; }
        public int get_thoiGianGui() { return thoiGianGui; }
        public bool get_loaiTK() { return loaiTK; }
        public double get_tienlai() { return tienlai; }
        public string xuat()
        {
            string str = string.Format("{0,10}|{1,20}|{2,20}|{3,10}|{4,11}|{5,2} tháng|{6,11}", MaKH, Hoten,
                DiaChi, ngayGui.ToString("dd/MM/yyyy"), SoTienGui, thoiGianGui.ToString("00"), tienlai);
            return str;
        }
    }
}
