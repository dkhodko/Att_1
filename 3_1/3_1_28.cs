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
        static bool IsPointAboveLine(double x, double y, double x0, double y0, double a)
        {
            return y > a * (x - x0) + y0;
        }
        static bool IsPointInCircle(double x, double y, double x0, double y0, double r)
        {
            return Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2) <= Math.Pow(r, 2);
        }
        static bool IsPointAboveParabola1(double x, double y)
        {
            return IsPointAboveParabolaY(x, y, 1, -1, 1);
        }
        static bool IsPointInCircle1(double x, double y)
        {
            return IsPointInCircle(x, y, -1, 6, 3);
        }
        static bool IsPointAboveLine1(double x, double y)
        {
            return IsPointAboveLine(x, y, 3, 3, -4);
        }
        static bool IsPointAboveLine2(double x, double y)
        {
            return IsPointAboveLine(x, y, -1, -1, -2);
        }
        static SimpleColor GetColor(double x, double y)
        {
            if (IsPointAboveParabola1(x, y) && !IsPointAboveLine1(x, y) && !IsPointInCircle1(x, y))
            {
                return SimpleColor.Gray;
            }
            if (!IsPointAboveLine2(x, y) || (IsPointAboveParabola1(x, y) && IsPointAboveLine1(x, y)))
            {
                return SimpleColor.Orange;
            }
            if (IsPointInCircle1(x, y) && IsPointAboveParabola1(x, y))
            {
                return SimpleColor.White;
            }
            if (IsPointAboveLine1(x, y) && !IsPointAboveParabola1(x, y))
            {
                return SimpleColor.Green;
            }
            if (IsPointInCircle1(x, y) && !IsPointAboveParabola1(x, y))
            {
                return SimpleColor.Blue;
            }
            else
                return SimpleColor.White;
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
        static void ReadCoord(out double x, out double y)
        {
            Console.Write("Input X: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Input Y: ");
            y = double.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            PrintTestPoints();
            while (true)
            {
                double x, y;
                ReadCoord(out x, out y);
                PrintColorForPoint(x, y);
            }
        }
    }
}
