using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator_80_NguyenNgocTuong
{
    public class Caculation_80_NguyenNgocTuong // thêm từ khóa public để sử dụng trong lớp khác
    {
        private int a_Tuong_80, b_Tuong_80;

        public Caculation_80_NguyenNgocTuong(int a_Tuong_80, int b_Tuong_80) // phương thức khởi tạo gán a và b tương ứng với 2 tham số được truyền vào
        {
            this.a_Tuong_80 = a_Tuong_80;
            this.b_Tuong_80 = b_Tuong_80;
        }

        public int Execute_80_NguyenNgocTuong(String operation)// phương thức tính toán dựa vào toán tử được truyền vào
        {
            int result = 0;
            switch (operation)//kiểm tra giá trị của toán tử để xác định phép toán 
            {
                case "+": // thực hiện phép cộng
                    result = this.a_Tuong_80 + this.b_Tuong_80;
                    break;

                case "-"://thực hiện phép trừ
                    result = this.a_Tuong_80 - this.b_Tuong_80;
                    break;

                case "*"://thực hiện phép nhân
                    result = this.a_Tuong_80 * this.b_Tuong_80;
                    break;

                case "/"://thực hiện phép chia
                    result = this.a_Tuong_80 / this.b_Tuong_80;
                    break;

            }
            return result;
        }
    }
}
