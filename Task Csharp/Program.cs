using System;
namespace FunctionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;//type of data
            x = 10;
            y = 15;
            int sum = Add(x, y);
            int minus = Minus(x, y);
            Console.WriteLine($"Sum is {sum}");
            Console.ReadKey();
            Console.WriteLine(Minus);
            Console.WriteLine($"Minus is {Minus}");
            Console.ReadKey();
        }

        static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static int Minus(int c, int d)
        {
            int minus = c - d;
            return minus;
        }

    }
}