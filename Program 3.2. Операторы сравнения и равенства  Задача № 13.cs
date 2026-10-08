using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nan = double.NaN;
            bool res = nan == nan;
            bool safeCheck = double.IsNaN(nan);

            Console.WriteLine($"double.NaN == double.NaN = {res}");           // False
            Console.WriteLine($"double.IsNaN(double.NaN) = {safeCheck}");      // True
        }
    }
}

