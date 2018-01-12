using System;

namespace _1_1_28
{
    class Program
    {
        static double ReadData(string varName)
        {
            Console.WriteLine("Введите {0}: ", varName);
            double value = double.Parse(Console.ReadLine());
            return value;
        }
        static double ReadV(string varName)
        {
            Console.WriteLine("Введите {0}: ", varName);
            double v = double.Parse(Console.ReadLine());
            return v;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                double v1 = ReadV("V1"),
                       v2 = ReadV("V2"),
                       t1 = ReadData("t1"),
                       t2 = ReadData("t2");
                if (v1 <= 0 || v2 <= 0)
                {
                    Console.WriteLine("hh");
                }
                double V = v1 + v2,
                       T = (t1 * v1 + t2 * v2) / V;

            
                Console.WriteLine("Объем смеси: " + V);
                Console.Write("Температура смеси: " + T);
                Console.ReadLine();
            }
        }
    }
}