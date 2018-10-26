using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double num1, num2, prod = 0;
            int counter;
            for (counter = 0; counter <= 9; counter++)
            {
                num1 = rnd.Next(0, 9);
                num2 = rnd.Next(0, 9);
                prod = num1 * num2;
                Console.WriteLine("The product of " + num1 + "*" + num2 + " = " + prod);
                Console.WriteLine();
            }
        }
    }
}
