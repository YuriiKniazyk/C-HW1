using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1Console
{
    public class PerimetrArea
    {
        public int side;

        public void Perimetr (int side)
        {
            int countSideSquare = 4;
            double perimetr = countSideSquare * side;

            Console.WriteLine($"Perimetr of the square = {perimetr} ");
        }

        public void Area (int side)
        {
            double area = side * side;
            Console.WriteLine($"Area of the square = {area}");
        }
    }
}
