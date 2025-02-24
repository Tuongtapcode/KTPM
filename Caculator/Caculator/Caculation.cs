﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    public class Caculation
    {
        private int a, b;

        public Caculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Execute(String operation )
        {
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = this.a + this.b;
                    break;

                case "-":
                    result = this.a - this.b;
                    break;

                case "*":
                    result = this.a * this.b;
                    break;

                case "/":
                    result = this.a / this.b;
                    break;

            }
            return result;
        }

    }
}
