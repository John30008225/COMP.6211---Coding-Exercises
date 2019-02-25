using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)

        {
            int a;
            Console.WriteLine("Input a number:");
            a = int.Parse(Console.ReadLine());


            for (int i = 0; i < 12; i++)
            {
                Console.Write($"{a} x {i} = {a * i}\n");
            }
            Console.ReadLine();
        }
    }
}
