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
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            float b = float.Parse(txtB.Text);
            float c = float.Parse(txtC.Text);
            if (b == 0)
            {
                MessageBox.Show("He so b phai khac 0");
                this.txtB.Clear();
                this.txtKQ.Clear();
                this.txtB.Focus();
            }
            else
            {
                float kq = -c / b;
                txtKQ.Text = kq.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
