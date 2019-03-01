using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Input a number:");
                double radius = double.Parse(Console.ReadLine());
                double pi = Math.PI;
                double area = pi * (radius * radius);
                Console.WriteLine("The Area of your circle is: {0:0.00}", area);
            }
                Console.ReadLine();
            
        }
    }
}
