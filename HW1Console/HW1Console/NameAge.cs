using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1Console
{
    public class NameAge
    {
        public string name;
        public int age;

        public void NameAgeUser(string name)
        {
            Console.WriteLine($"How old are you, {name}?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"I am {age} years old");
        }
    }
}
