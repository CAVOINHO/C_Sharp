using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5
{
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            float soThuNhat = float.Parse(txtsSo1.Text);
            float soThuHai = float.Parse(txtSo2.Text);
            float Kq = soThuNhat + soThuHai;
            txtKQ.Text = Kq.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            float soThuNhat = float.Parse(txtsSo1.Text);
            float soThuHai = float.Parse(txtSo2.Text);
            float Kq = soThuNhat - soThuHai;
            txtKQ.Text = Kq.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            float soThuNhat = float.Parse(txtsSo1.Text);
            float soThuHai = float.Parse(txtSo2.Text);
            float Kq = soThuNhat * soThuHai;
            txtKQ.Text = Kq.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            float soThuNhat = float.Parse(txtsSo1.Text);
            float soThuHai = float.Parse(txtSo2.Text);
            float Kq = soThuNhat / soThuHai;
            txtKQ.Text = Kq.ToString();
            String warning = "Không thể chia cho 0";
            if (soThuHai == 0)
            {
                MessageBox.Show(warning);
                this.txtSo2.Clear();
                this.txtKQ.Clear();
                this.txtSo2.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtsSo1.Clear();
            this.txtSo2.Clear();
            this.txtKQ.Clear();
            this.txtsSo1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
