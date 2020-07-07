using HomeWork1Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1 Perimetr&Area of a square
            Console.WriteLine("Please enter length sides of the square: ");
            int a = Convert.ToInt32(Console.ReadLine());

            PerimetrArea perimetrArea = new PerimetrArea();
            perimetrArea.side = a;

            perimetrArea.Perimetr(a);
            perimetrArea.Area(a);

            Console.WriteLine();
            Console.WriteLine();

            //task 2 Name&Age
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            NameAge nameAge = new NameAge();
            nameAge.NameAgeUser(name);

            Console.WriteLine();
            Console.WriteLine();

            //task 3 calculate length, area, volume
            Console.WriteLine("Please enter double number r: ");
            double r = Convert.ToDouble(Console.ReadLine());

            LengthAreaVolume lengthAreaVolume = new LengthAreaVolume();
            lengthAreaVolume.Length(r);
            lengthAreaVolume.Area(r);
            lengthAreaVolume.Volume(r);

            Console.ReadKey();
        }
    }
}
