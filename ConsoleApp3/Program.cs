using System;

namespace _2_1_28
{
    enum TrType
    {
        Rectangular,
        Obtuse,
        Acute
    }
    class Program
    {


        static void ReadTr(out double a, out double b, out double c)
        {
            Console.WriteLine("Введите первое число: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            c = double.Parse(Console.ReadLine());
        }
        static void Altitudes(out double h1, out double h2, out double h3, double a, double b, double c)
        {           
            double p = (a + b + c) / 2;
            h1 = (2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / a;
            h2 = (2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / b;
            h3 = (2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / c;
            Console.WriteLine("{0}; {1}; {2}", h1, h2, h3);
        }
        static void PrintColorForPoint(double a, double b, double c)
        {
            Console.WriteLine("{0}", CheckType(a, b, c));
        }
        static TrType CheckType(double a, double b, double c)
        {            
            if ((a * a > b * b + c * c) || (b * b > a * a + c * c) || (c * c > a * a + b * b))
                return TrType.Obtuse;
            if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b))
                return TrType.Rectangular;
            else
                return TrType.Acute;
        }
        static void Main(string[] args)
        {
            while(true)
            {
                double a, b, c;
                ReadTr(out a, out b, out c);
                if (a > 0 && b > 0 && c > 0)
                {
                    PrintColorForPoint(a, b, c);
                    double h1, h2, h3;
                    Altitudes(out h1, out h2, out h3, a, b, c);
                }
                else
                    Console.WriteLine("Такого треугольника не существует");
            }
        }
    }
}
