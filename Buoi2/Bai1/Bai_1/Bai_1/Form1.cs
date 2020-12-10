using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float soThuNhat = float.Parse(txtsSo1.Text);
            float soThuHai = float.Parse(txtSo2.Text);
            float Kq = soThuNhat * soThuHai;
            txtKQ.Text = Kq.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtsSo1.Clear();
            this.txtSo2.Clear();
            this.txtKQ.Clear();
            this.txtsSo1.Focus();
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

        private void btnChia_Click(object sender, EventArgs e)
        {
            float soThuNhat = float.Parse(txtsSo1.Text);
            float soThuHai = float.Parse(txtSo2.Text);
            float Kq = soThuNhat / soThuHai;
            txtKQ.Text = Kq.ToString();
            String warning = "Không thể chia cho 0";
            if(soThuHai == 0)
            {
                MessageBox.Show(warning);
                this.txtSo2.Clear();
                this.txtKQ.Clear();
                this.txtSo2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
