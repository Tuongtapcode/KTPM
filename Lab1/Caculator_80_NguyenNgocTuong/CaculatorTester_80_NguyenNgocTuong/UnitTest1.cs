using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Caculator_80_NguyenNgocTuong;

namespace CaculatorTester_80_NguyenNgocTuong
{
    [TestClass]
    public class UnitTest1
    {
        private Caculation_80_NguyenNgocTuong caculation_Tuong_80;
        [TestMethod]
        [TestInitialize] // thiết lập thẻ dùng chung cho test case
        public void setup()
        {
            caculation_Tuong_80 = new Caculation_80_NguyenNgocTuong(12, 6);
        }

        [TestMethod] // test case 1: a = 12, b = 6,  expected =18, actual = 18 --> true
        public void TestCase1_AddOperator_Tuong_80()
        {
            int expected_Tuong_80, actual_Tuong_80;
            expected_Tuong_80 = 18;
            actual_Tuong_80 = caculation_Tuong_80.Execute_80_NguyenNgocTuong("+");
            Assert.AreEqual(expected_Tuong_80, actual_Tuong_80);

        }
        [TestMethod] // test case 2: a = 12, b = -6,  expected =6, actual = 6 --> true
        public void TestCase2_AddOperator_Tuong_80()
        {
            int expected_Tuong_80, actual_Tuong_80;
            caculation_Tuong_80 = new Caculation_80_NguyenNgocTuong(12, -6);
            expected_Tuong_80 = 6;
            actual_Tuong_80 = caculation_Tuong_80.Execute_80_NguyenNgocTuong("+");
            Assert.AreEqual(expected_Tuong_80, actual_Tuong_80);
        }

        [TestMethod] // test case 3: a = -12, b = -6,  expected =-18, actual = -18 --> true
        public void TestCase3_AddOperator_Tuong_80()
        {
            int expected_Tuong_80, actual_Tuong_80;
            caculation_Tuong_80 = new Caculation_80_NguyenNgocTuong(-12, -6);
            expected_Tuong_80 = -18;
            actual_Tuong_80 = caculation_Tuong_80.Execute_80_NguyenNgocTuong("+");
            Assert.AreEqual(expected_Tuong_80, actual_Tuong_80);
        }

        [TestMethod] // test case 4: a = -1, b = 0,  expected =-1, actual = -1 --> true
        public void TestCase4_AddOperator_Tuong_80()
        {
            int expected_Tuong_80, actual_Tuong_80;
            caculation_Tuong_80 = new Caculation_80_NguyenNgocTuong(-1, 0);
            expected_Tuong_80 = -1;
            actual_Tuong_80 = caculation_Tuong_80.Execute_80_NguyenNgocTuong("+");
            Assert.AreEqual(expected_Tuong_80, actual_Tuong_80);
        }



        [TestMethod] // test case 5: a = 5, b = 5,  expected = 7, actual = 10 
        public void TestCase5_AddOperator_Tuong_80()
        {
            int expected_Tuong_80, actual_Tuong_80;
            caculation_Tuong_80 = new Caculation_80_NguyenNgocTuong(5, 5);
            expected_Tuong_80 = 7;
            actual_Tuong_80 = caculation_Tuong_80.Execute_80_NguyenNgocTuong("+");
            Assert.AreEqual(expected_Tuong_80, actual_Tuong_80);
        }

        [TestMethod] // test case 6: a = -5, b = 5,  expected = -1, actual = 0
        public void TestCase6_AddOperator_Tuong_80()
        {
            int expected_Tuong_80, actual_Tuong_80;
            caculation_Tuong_80 = new Caculation_80_NguyenNgocTuong(-5, 5);
            expected_Tuong_80 = -1;
            actual_Tuong_80 = caculation_Tuong_80.Execute_80_NguyenNgocTuong("+");
            Assert.AreEqual(expected_Tuong_80, actual_Tuong_80);
        }

        [TestMethod] // test case 7: a = 0, b = -5,  expected = 1, actual = -5
        public void TestCase7_AddOperator_Tuong_80()
        {
            int expected_Tuong_80, actual_Tuong_80;
            caculation_Tuong_80 = new Caculation_80_NguyenNgocTuong(0, -5);
            expected_Tuong_80 = 1;
            actual_Tuong_80 = caculation_Tuong_80.Execute_80_NguyenNgocTuong("+");
            Assert.AreEqual(expected_Tuong_80, actual_Tuong_80);
        }

        [TestMethod] // test case 8: a = 0, b = 0,  expected = -5, actual = 0
        public void TestCase8_AddOperator_Tuong_80()
        {
            int expected_Tuong_80, actual_Tuong_80;
            caculation_Tuong_80 = new Caculation_80_NguyenNgocTuong(0, 0);
            expected_Tuong_80 = -5;
            actual_Tuong_80 = caculation_Tuong_80.Execute_80_NguyenNgocTuong("+");
            Assert.AreEqual(expected_Tuong_80, actual_Tuong_80);
        }

        [TestMethod] // test case 9: a = -9, b = -9,  expected = -5, actual = -18
        public void TestCase9_AddOperator_Tuong_80()
        {
            int expected_Tuong_80, actual_Tuong_80;
            caculation_Tuong_80 = new Caculation_80_NguyenNgocTuong(-9, -9);
            expected_Tuong_80 = -5;
            actual_Tuong_80 = caculation_Tuong_80.Execute_80_NguyenNgocTuong("+");
            Assert.AreEqual(expected_Tuong_80, actual_Tuong_80);
        }





        [TestMethod]//test case tru: a = 12, b = 6,  expected = 6, actual = 6 --> true
        public void TestSubOperator_Tuong_80()
        {
            int expected_Tuong_80, actual_Tuong_80;
            expected_Tuong_80 = 6;
            actual_Tuong_80 = caculation_Tuong_80.Execute_80_NguyenNgocTuong("-");
            Assert.AreEqual(expected_Tuong_80, actual_Tuong_80);
        }
        [TestMethod]//test case nhan: a = 12, b = 6,  expected = 72, actual = 72 --> true
        public void TestMulOperator_Tuong_80()
        {
            int expected_Tuong_80, actual_Tuong_80;
            expected_Tuong_80 = 72;
            actual_Tuong_80 = caculation_Tuong_80.Execute_80_NguyenNgocTuong("*");
            Assert.AreEqual(expected_Tuong_80, actual_Tuong_80);
        }
        [TestMethod]//test case chia: a = 12, b = 6,  expected = 2, actual = 2 --> true
        public void TestDivOperato_Tuong_80()
        {
            int expected_Tuong_80, actual_Tuong_80;
            expected_Tuong_80 = 2;
            actual_Tuong_80 = caculation_Tuong_80.Execute_80_NguyenNgocTuong("/");
            Assert.AreEqual(expected_Tuong_80, actual_Tuong_80);
        }
        [TestMethod]//test case chia voi so 0
        [ExpectedException(typeof(DivideByZeroException))]
        // Chỉ định rằng kiểm thử này kỳ vọng sẽ ném ra một ngoại lệ loại DivideByZeroException
        public void TestDivOperatorByZero_Tuong_80()
        {
            caculation_Tuong_80 = new Caculation_80_NguyenNgocTuong(14, 0);
            // Gọi phương thức Execute_80_NguyenNgocTuong với tham số "/" để thực hiện phép chia.
            // Vì b = 0, phương thức này sẽ ném ra ngoại lệ DivideByZeroException.
            caculation_Tuong_80.Execute_80_NguyenNgocTuong("/");
        }
    }
}
