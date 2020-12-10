using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtChiSoCu.Clear();
            this.txtChiSoMoi.Clear();
            this.txtHoTenKH.Clear();
            this.txtKQ.Clear();
            this.txtSoNhanKhau.Clear();
            this.txtTongSoMetKhoiSD.Clear();
            this.txtTongTienPT.Clear();
            this.txtTongTienSD.Clear();
            this.txtTrongDinhMuc.Clear();
            this.txtVuotDinhMuc.Clear();
            this.txtHoTenKH.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int dinhmuc;

        private void btnTinh_Click(object sender, EventArgs e)
        {
          
            if (int.Parse(this.txtSoNhanKhau.Text) < 4)
            {
                dinhmuc = 12;
            }

            if (int.Parse(this.txtSoNhanKhau.Text) >= 4)
            {
                dinhmuc = int.Parse(this.txtSoNhanKhau.Text) * 4;
            }

            this.txtTongSoMetKhoiSD.Text = (int.Parse(txtChiSoMoi.Text) - int.Parse(txtChiSoCu.Text)).ToString();

            int TSD = int.Parse(this.txtTongSoMetKhoiSD.Text);

            if ( TSD <= dinhmuc )
            {
                this.txtTrongDinhMuc.Text = this.txtTongSoMetKhoiSD.Text;
                int a = 0;
                this.txtVuotDinhMuc.Text = a.ToString();
            }

            if ( TSD > dinhmuc )
            {
                this.txtTrongDinhMuc.Text = dinhmuc.ToString();
                this.txtVuotDinhMuc.Text = ( TSD - dinhmuc).ToString();
            }

            int trong = int.Parse(this.txtTrongDinhMuc.Text) * 4000;
            int vuot = int.Parse(this.txtVuotDinhMuc.Text) * 8000;
            int Tong = (trong + vuot);
            this.txtTongTienSD.Text = Tong.ToString() + " VND";

            int vat = (Tong / 10);
            this.txtTongTienVAT.Text = vat.ToString() + " VND";

            this.txtTongTienPT.Text = (Tong + vat).ToString() + " VND";
        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            this.txtKQ.Text = "Khách hàng: " + this.txtHoTenKH.Text + "\r\n"
                          + "Số Nhân Khẩu: " + this.txtSoNhanKhau.Text + "\r\n"
                          + "Tổng số mét khối sử dụng: " + this.txtTongTienSD.Text + "\r\n"
                          + "Trong định mức: " + this.txtTrongDinhMuc.Text + "\r\n"
                          + "Vượt định mức: " + this.txtVuotDinhMuc.Text + "\r\n"
                          + "Tổng tiền phải trả: " + this.txtTongTienPT.Text + "\r\n";
        }
    }
}
