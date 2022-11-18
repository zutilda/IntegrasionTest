using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTest
{
    internal class Logarifm
    {
        public static double Log(double x)
        {
            for (int i = 0; i < 100; i++)
            {
                if (Math.Pow(5, i) == x)
                {
                    return i;
                }
            }
            return 0;
        }
        public double show(double x)
        {
            double result = Log(x);
            return result;
        }
    }
}
