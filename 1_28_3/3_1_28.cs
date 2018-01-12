using System;

namespace _3_1_28
{
    enum SimpleColor
    {
        Black,
        White,
        Gray,
        Red,
        Orange,
        Yellow,
        Green,
        Blue
    }

    class Program
    {
        static bool IsPointAboveParabolaY(double x, double y, double x0, double y0, double a)
        {
            return y > a * Math.Pow(x - x0, 2) + y0;
        }
        static bool IsPointInRect(double x, double y, double x0, double y0, double w, double h)
        {
            return (y <= y0 && y >= y0 - h && x >= x0 && x <= x0 + w);
        }
        static bool IsPointAboveParabola1(double x, double y)
        {
            return IsPointAboveParabolaY(x, y, 0, -6, 1);
        }
        static bool IsPointInRect1(double x, double y)
        {
            return IsPointInRect(x, y, -6, 5, 10, 9);
        }
        static bool IsPointInRect2(double x, double y)
        {
            return IsPointInRect(x, y, 1, 9, 7, 9);
        }

        static SimpleColor GetColor(double x, double y)
        {
            if ((IsPointAboveParabola1(x, y) && IsPointInRect1(x, y)) || (IsPointAboveParabola1(x, y) && IsPointInRect2(x, y)))
            {
                return SimpleColor.Gray;
            }
            if ((IsPointInRect1(x, y) && x < 0 && !IsPointAboveParabola1(x, y)) || (IsPointAboveParabola1(x, y) && y < 0 && !IsPointInRect1(x, y)))
            {
                return SimpleColor.Orange;
            }
            if ((IsPointAboveParabola1(x, y) && y > 0 && !IsPointInRect1(x, y) && !IsPointInRect2(x, y)) || (IsPointInRect1(x, y) && IsPointInRect2(x, y) && !IsPointAboveParabola1(x, y)))
            {
                return SimpleColor.White;
            }
            if (IsPointInRect1(x, y) && x > 0 && !IsPointAboveParabola1(x, y) && !IsPointInRect2(x, y))
            {
                return SimpleColor.Yellow;
            }
            if (IsPointInRect2(x, y) && !IsPointInRect1(x, y) && !IsPointAboveParabola1(x, y))
            {
                return SimpleColor.Blue;
            }
            else
                return SimpleColor.Gray;
        }
        static void PrintColorForPoint(double x, double y)
        {
            Console.WriteLine("({0}, {1}) -> {2}", x, y, GetColor(x, y));
        }
        static void PrintTestPoints()
        {
            PrintColorForPoint(1, 1);
            PrintColorForPoint(0, -5);
            PrintColorForPoint(-3, 0);
            PrintColorForPoint(5, 5);
            PrintColorForPoint(3, 0);
            PrintColorForPoint(3, -3);
            PrintColorForPoint(0, 8);
        }
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
        static void ReadCoord(out double x, out double y)
        {
            x = ReadData("X");
            y = ReadData("Y");
        }
        static void Main(string[] args)
        {
            PrintTestPoints();
            while (true)
            {
                double x, y;
                ReadCoord(out x, out y);
                if (x < 10 && x > -10 && y < 10 && y > -10)
                    PrintColorForPoint(x, y);
                else
                    Console.WriteLine("Не входит в промежуток");
            }
        }
    }
}
