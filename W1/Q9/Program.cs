using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randm = new Random();
            int rand_num = randm.Next(1000, 9999);          //Random Number Generator 
            Console.WriteLine("----- Random Number -----");

            for (int i = 0; i < 1000; i++)

            {
                rand_num = randm.Next(1000, 9999);
                int rand_num1 = randm.Next(1000, 9999);
                int rand_num2 = randm.Next(1000, 9999);
                int rand_num3 = randm.Next(1000, 9999);
                int rand_num4 = randm.Next(1000, 9999);


                Console.WriteLine("Value of i: {0}", i);
                Console.Write("{0} {0} {0} {0} {0}", rand_num);

            }
                Console.ReadLine();
        }
    }
}
