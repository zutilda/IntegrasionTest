using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTest
{
    internal class NLogarifm
    {
        public static double LN(double x)
        {
            if (x < 1)
            {
                return -LN(1 / x);
            }
            double e = 1, a = (x - e) / (x + e), b = a * a, p = a, s = a, q = e;
            while (e > 1e-18)
            {
                q += 2;
                p *= b;
                e = p / q;
                s += e;
            }
            return 2 * s;
        }
        public double show(double x)
        {
            double result = LN(x);
            return result;
        }
    }
}
