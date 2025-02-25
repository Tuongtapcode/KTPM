using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator_80_NguyenNgocTuong
{
    public partial class Caculator : Form
    {
        public Caculator()
        {
            InitializeComponent();
        }

        private void btnCong_Tuong_80_Click(object sender, EventArgs e)
        {
            int a_Tuong_80, b_Tuong_80, relsut_Tuong_80;
            a_Tuong_80 = int.Parse(txtSo1_Tuong_80.Text); // gán giá trị của a từ ô txtSo1
            b_Tuong_80 = int.Parse(txtSo2_Tuong_80.Text);// gán giá trị của b từ ô txtSo2
            Caculation_80_NguyenNgocTuong caculation = new Caculation_80_NguyenNgocTuong(a_Tuong_80, b_Tuong_80);// khởi tạo caculation bằng 2 tham số được truyền vào là a và b
            relsut_Tuong_80 = caculation.Execute_80_NguyenNgocTuong("+");// kết quả được tính toán bằng phương thức Execute và toán tử truyền vào là dấu +
            txtKQ_Tuong_80.Text = relsut_Tuong_80.ToString();//gán và hiển thị thuộc tính text bằng kết quả
        }

        private void btnTru_Tuong_80_Click(object sender, EventArgs e)
        {
            int a_Tuong_80, b_Tuong_80, relsut_Tuong_80;
            a_Tuong_80 = int.Parse(txtSo1_Tuong_80.Text); // gán giá trị của a từ ô txtSo1
            b_Tuong_80 = int.Parse(txtSo2_Tuong_80.Text);// gán giá trị của b từ ô txtSo2
            Caculation_80_NguyenNgocTuong caculation = new Caculation_80_NguyenNgocTuong(a_Tuong_80, b_Tuong_80);// khởi tạo caculation bằng 2 tham số được truyền vào là a và b
            relsut_Tuong_80 = caculation.Execute_80_NguyenNgocTuong("-");// kết quả được tính toán bằng phương thức Execute và toán tử truyền vào là dấu -
            txtKQ_Tuong_80.Text = relsut_Tuong_80.ToString();//gán và hiển thị thuộc tính text bằng kết quả
        }

        private void btnNhan_Tuong_80_Click(object sender, EventArgs e)
        {
            int a_Tuong_80, b_Tuong_80, relsut_Tuong_80;
            a_Tuong_80 = int.Parse(txtSo1_Tuong_80.Text); // gán giá trị của a từ ô txtSo1
            b_Tuong_80 = int.Parse(txtSo2_Tuong_80.Text);// gán giá trị của b từ ô txtSo2
            Caculation_80_NguyenNgocTuong caculation = new Caculation_80_NguyenNgocTuong(a_Tuong_80, b_Tuong_80);// khởi tạo caculation bằng 2 tham số được truyền vào là a và b
            relsut_Tuong_80 = caculation.Execute_80_NguyenNgocTuong("*");// kết quả được tính toán bằng phương thức Execute và toán tử truyền vào là dấu *
            txtKQ_Tuong_80.Text = relsut_Tuong_80.ToString();//gán và hiển thị thuộc tính text bằng kết quả
        }

        private void btnChia_Tuong_80_Click(object sender, EventArgs e)
        {
            int a_Tuong_80, b_Tuong_80, relsut;
            a_Tuong_80 = int.Parse(txtSo1_Tuong_80.Text); // gán giá trị của a từ ô txtSo1
            b_Tuong_80 = int.Parse(txtSo2_Tuong_80.Text);// gán giá trị của b từ ô txtSo2
            Caculation_80_NguyenNgocTuong caculation = new Caculation_80_NguyenNgocTuong(a_Tuong_80, b_Tuong_80);// khởi tạo caculation bằng 2 tham số được truyền vào là a và b
            relsut = caculation.Execute_80_NguyenNgocTuong("/");// kết quả được tính toán bằng phương thức Execute và toán tử truyền vào là dấu /
            txtKQ_Tuong_80.Text = relsut.ToString();//gán và hiển thị thuộc tính text bằng kết quả
        }
    }
}
