using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    public class TrapezoidalIntegration
    {
        private Func<double, double> function;

        public TrapezoidalIntegration(Func<double, double> func)
        {
            function = func;
        }

        public double Calculate(double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = (function(a) + function(b)) / 2.0;

            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                sum += function(x);
            }

            return h * sum;
        }
    }
}
