using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1Console
{
    public class LengthAreaVolume
    {
        double pi = 3.14;

        public void Length(double r)
        {
            var l = 2 * pi * r;
            Console.WriteLine($"Length = {l}");
        }

        public void Area(double r)
        {
            var s = pi * r * r;
            Console.WriteLine($"Area = {s}");
        }

        public void Volume(double r)
        {
            var v = 4/3 * pi * r * r * r;
            Console.WriteLine($"Volume = {v:F3}");
        }
    }
}
