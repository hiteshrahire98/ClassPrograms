using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPrograms
{
    public class Calculation  // For Method Overloading... 
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, int b)
        {
            return a + b;
        }

        public double Add(float a, double b)
        {
            return a + b;
        }
    }
}
