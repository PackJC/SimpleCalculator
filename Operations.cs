using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Operations
    {
        public decimal Add(int x, int y)
        {
            decimal z = x + y;
            return z;
        }
        public decimal Mult(int x, int y)
        {
            decimal z = x * y;
            return z;
        }
        public decimal Div(int x, int y)
        {
            decimal z = x / y;
            return z;
        }
        public decimal Sub(int x, int y)
        {
            decimal z = x - y;
            return z;
        }
    }
}
