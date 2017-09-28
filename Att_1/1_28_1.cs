using System;

namespace _1_28_1
{
    class Program
    {
        static double ReadData(string varName)
        {
            Console.WriteLine("Введите {0}: ", varName);
            double value = double.Parse(Console.ReadLine());
            return value;
        }

        static void Main(string[] args)
        {
            double s1 = Math.PI * Math.Pow(ReadData("r1"), 2),
                   s2 = Math.PI * Math.Pow(ReadData("r2"), 2),
                   r3 = ReadData("r3"),
                   s3 = Math.PI * Math.Pow(r3, 2),
                   Sq = Math.Pow(2*r3,2),
                   S = Sq - s3 + s2 - s1;
            Console.Write(S);
            Console.ReadLine();
        }
    }
}
