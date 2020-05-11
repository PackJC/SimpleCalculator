using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Operations
    {
        public float Add(int x, int y)
        {
            float z = x + y;
            return z;
        }
        public float Mult(int x, int y)
        {
            float z = x * y;
            return z;
        }
        public float Div(int x, int y)
        {
            float z = x / y;
            return z;
        }
        public float Sub(int x, int y)
        {
            float z = x - y;
            return z;
        }
    }
}
