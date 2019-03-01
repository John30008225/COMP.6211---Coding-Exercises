using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10, b = 20, temp;

            temp = a;
            a = b;
            b = temp;           //Swapping Number

            Console.WriteLine("Values after swapping are:");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.ReadLine();
        }
    }
}
