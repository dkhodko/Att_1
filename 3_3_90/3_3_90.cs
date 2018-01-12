using System;

namespace _3_3_90
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
        static bool IsPointLeftOfParabolaX(double x, double y, double x0, double y0, double a)
        {
            return x < a * Math.Pow(y - y0, 2) + x0;
        }
        static bool IsPointAboveParabolaY(double x, double y, double x0, double y0, double a)
        {
            return y > a * Math.Pow(x - x0, 2) + y0;
        }
        static bool IsPointInRect(double x, double y, double x0, double y0, double w, double h)
        {
            return (y <= y0 && y >= y0 - h && x >= x0 && x <= x0 + w);
        }
        static bool IsPointInCircle(double x, double y, double x0, double y0, double r)
        {
            return Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2) <= Math.Pow(r, 2);
        }
        static bool IsPointLeftOfParabolaX1(double x, double y)
        {
            return IsPointLeftOfParabolaX(x, y, -6, 2, -0.125);
        }
        static bool IsPointLeftOfParabolaX2(double x, double y)
        {
            return IsPointLeftOfParabolaX(x, y, 3, -6, -1);
        }
        static bool IsPointAboveParabola1(double x, double y)
        {
            return IsPointAboveParabolaY(x, y, -6, -4, 1);
        }
        static bool IsPointInRect1(double x, double y)
        {
            return IsPointInRect(x, y, -5, 4, 6, 6);
        }
        static bool IsPointInCircle1(double x, double y)
        {
            return IsPointInCircle(x, y, 6, -2, 5);
        }
        static SimpleColor GetColor(double x, double y)
        {
            if ((IsPointLeftOfParabolaX1(x, y) && IsPointAboveParabola1(x, y)) || (IsPointInRect1(x, y) && IsPointAboveParabola1(x, y)) || (IsPointLeftOfParabolaX2(x, y) && IsPointAboveParabola1(x, y)))
            {
                return SimpleColor.Green;
            }
            if (IsPointLeftOfParabolaX2(x, y) && !IsPointLeftOfParabolaX1(x, y) && !IsPointInCircle1(x, y) && !IsPointAboveParabola1(x, y))
            {
                return SimpleColor.Orange;
            }
            if (!IsPointLeftOfParabolaX1(x, y) && !IsPointInRect1(x, y) && !IsPointLeftOfParabolaX2(x, y) && IsPointAboveParabola1(x, y))
            {
                return SimpleColor.White;
            }
            if (IsPointInCircle1(x, y) && !IsPointLeftOfParabolaX2(x, y))
            {
                return SimpleColor.Yellow;
            }
            if ((x < -7 && x > -9 && y > -3 && y < -1 && !IsPointLeftOfParabolaX2(x, y) && !IsPointLeftOfParabolaX1(x, y) && !IsPointAboveParabola1(x, y)) || (!IsPointLeftOfParabolaX2(x, y) && IsPointLeftOfParabolaX1(x, y) && !IsPointAboveParabola1(x, y)))
            {
                return SimpleColor.Blue;
            }
            if ((!IsPointLeftOfParabolaX1(x, y) && !IsPointInRect1(x, y) && !IsPointLeftOfParabolaX2(x, y) && !IsPointAboveParabola1(x, y) && !IsPointInCircle1(x, y)) && (x < -5 || y <= -2))
                return SimpleColor.Gray;
            else
                return SimpleColor.White;
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
