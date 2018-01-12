using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static int ReadValueFromConsole(string varName)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите {0}: ", varName);
                    int value = int.Parse(Console.ReadLine());
                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Переменная должна являться числом");
                }
            }
        }
    
        public static void PrintTr1(int h)
        {
            Console.Write(new string(' ', h / 2));
            Console.WriteLine(new string('*', h / 2));
        }
        public static void PrintTr2(int h)
        {
            for (int i = 2; i < h/2; i++)
            {
                Console.Write(new string(' ', h/2));
                Console.Write('*');
                Console.Write(new string('#', h/2 - i - 1));
                Console.WriteLine('*');
            }
            if (h > 2) 
            {
                Console.Write(new string(' ', h / 2));
                Console.WriteLine('*');
                Console.Write(new string(' ', h / 2 - 1));
                Console.WriteLine('*');
            }
            for (int i = h / 2 + 1; i < h - 1; i++)
            {
                Console.Write(new string(' ', h - i - 1));
                Console.Write('*');
                Console.Write(new string('#', i - h / 2 - 1));
                Console.WriteLine('*');
            }
            Console.WriteLine(new string('*', h / 2));
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int h = ReadValueFromConsole("h");
                if (h > 0 && h % 2 == 0)
                {
                    PrintTr1(h);
                    PrintTr2(h);
                }
            }
        }
    }
}
