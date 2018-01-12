using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static int ReadDoubleValueFromConsole(string varName)
        {
            Console.Write("Введите {0}: ", varName);
            int value = int.Parse(Console.ReadLine());
            return value;
        }
        public static void PrintStarTriangle2(int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h - i - 1; j++)
                    Console.Write("*");
                Console.WriteLine("*");
            }
        }
        static void Main(string[] args)
        {
            int h = ReadDoubleValueFromConsole("h");
            PrintStarTriangle2(h);
            Console.ReadLine();
        }
    }
}
