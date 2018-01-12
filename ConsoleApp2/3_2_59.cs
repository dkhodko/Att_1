using System;

namespace _3_2_59
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
        static bool IsPointRightOfParabolaX(double x, double y, double x0, double y0, double a)
        {
            return x > a * Math.Pow(y - y0, 2) + x0;
        }
        static bool IsPointInRect(double x, double y, double x0, double y0, double w, double h)
        {
            return (y <= y0 && y >= y0 - h && x >= x0 && x <= x0 + w);
        }
        static bool IsPointAboveLine(double x, double y, double x0, double y0, double a)
        {
            return y > a * (x - x0) + y0;
        }
        static bool IsPointInCircle(double x, double y, double x0, double y0, double r)
        {
            return Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2) <= Math.Pow(r, 2);
        }
        static bool IsPointRightOfParabolaX1(double x, double y)
        {
            return IsPointRightOfParabolaX(x, y, 0, 0, 0.12);
        }
        static bool IsPointInRect1(double x, double y)
        {
            return IsPointInRect(x, y, 1, 10, 7, 8);
        }
        static bool IsPointInRect2(double x, double y)
        {
            return IsPointInRect(x, y, -5, -3, 9, 2);
        }
        static bool IsPointInCircle1(double x, double y)
        {
            return IsPointInCircle(x, y, -1, -1, 4);
        }
        static bool IsPointAboveLine1(double x, double y)
        {
            return IsPointAboveLine(x, y, 0, -1, -2);
        }
        static SimpleColor GetColor(double x, double y)
        {
            if ((IsPointRightOfParabolaX1(x, y) && IsPointInRect1(x, y)) || (IsPointInCircle1(x, y) && !IsPointAboveLine1(x, y)))
            {
                return SimpleColor.Green;
            }
            if ((IsPointInCircle1(x, y) && IsPointRightOfParabolaX1(x, y) && !IsPointInRect1(x, y) && !IsPointInRect2(x, y)) || (IsPointRightOfParabolaX1(x, y) && IsPointInRect2(x, y) && !IsPointInCircle1(x, y)) || (IsPointAboveLine1(x, y) && !IsPointRightOfParabolaX1(x, y) && !IsPointInCircle1(x, y) && y < 2) || (IsPointRightOfParabolaX1(x, y) && x <= 1))
            {
                return SimpleColor.Orange;
            }
            if (IsPointInRect2(x, y) && !IsPointInCircle1(x, y) && IsPointAboveLine1(x, y) && !IsPointRightOfParabolaX1(x, y))
            {
                return SimpleColor.White;
            }
            if ((IsPointRightOfParabolaX1(x, y) && !IsPointInRect1(x, y) && !IsPointInRect2(x, y) & x > 1) || IsPointInCircle1(x, y) && IsPointAboveLine1(x, y) && !IsPointRightOfParabolaX1(x, y) && y < 2)
            {
                return SimpleColor.Yellow;
            }
            if ((IsPointAboveLine1(x, y) && !IsPointRightOfParabolaX1(x, y) && y > -2) || (IsPointInCircle1(x, y) && IsPointRightOfParabolaX1(x, y) && IsPointInRect2(x, y)))
            {
                return SimpleColor.Blue;
            }
            else
                return SimpleColor.Red;
        }
        static void PrintColorForPoint(double x, double y)
        {
            Console.WriteLine("({0}, {1}) -> {2}", x, y, GetColor(x, y));
        }
        static void PrintTestPoints()
        {
            PrintColorForPoint(0.99, 2.77);
            PrintColorForPoint(0, -5);
            PrintColorForPoint(-3, 0);
            PrintColorForPoint(5, 5);
            PrintColorForPoint(3, 0);
            PrintColorForPoint(3, -4);
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
