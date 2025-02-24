using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a, b, relsut;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Caculation caculation = new Caculation(a, b);
            relsut = caculation.Execute("+");
            txtKQ.Text = relsut.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int a, b, relsut;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Caculation caculation = new Caculation(a, b);
            relsut = caculation.Execute("-");
            txtKQ.Text = relsut.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int a, b, relsut;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Caculation caculation = new Caculation(a, b);
            relsut = caculation.Execute("*");
            txtKQ.Text = relsut.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int a, b, relsut;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Caculation caculation = new Caculation(a, b);
            relsut = caculation.Execute("/");
            txtKQ.Text = relsut.ToString();
        }
    }
}
