using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");

            Console.Write("How many hours of sleep did you get?");
            int hours = int.Parse(Console.ReadLine());

            if (hours >= 8)
            {
                Console.WriteLine("You are well reseted");
            }
            else
            {
                Console.WriteLine("You should get more sleep!");
            }
        }
    }
}
