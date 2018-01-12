using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 12;
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s/2 - i; j++)
                    Console.Write("^");
                Console.WriteLine("*");
            }

            Console.ReadLine();
        }
    }
}
