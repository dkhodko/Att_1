using System;

namespace _1_1_28
{
    class Program
    {
        static double ReadData(string varName)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите {0}: ", varName);
                    double value = double.Parse(Console.ReadLine());
                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Переменная должна являться числом");
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                var x = true;
                while (x)
                {
                    double v1 = ReadData("V1"),
                           v2 = ReadData("V2");
                    if (v1 > 0 || v2 > 0)
                    {
                        double t1 = ReadData("t1"),
                               t2 = ReadData("t2"),
                               V = v1 + v2,
                               T = (t1 * v1 + t2 * v2) / V;
                        x = false;
                        Console.WriteLine("Объем смеси: " + V);
                        Console.Write("Температура смеси: " + T);
                    }
                    if (v1 < 0 || v2 < 0)
                    {
                        Console.WriteLine("Объем не может быть меньше нуля. Введите другое значение.");
                        x = true;
                    }
                    if (v1 == 0 || v2 == 0)
                    {
                        Console.WriteLine("Объем не может быть равен нулю. Введите другое значение.");
                        x = true;
                    }
                }
                Console.ReadLine();
            }
        }
    }
}