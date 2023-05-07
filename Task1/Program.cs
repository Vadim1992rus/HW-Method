using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Укажите параметр a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Укажите параметр b");
        int b = Convert.ToInt32(Console.ReadLine());
        int P = 2 * (a + b);
        Console.WriteLine("Периметр равен :" + " " + P);
        Console.WriteLine("Укажите параметр укгла A");
        int U = Convert.ToInt32(Console.ReadLine());
        int F = Math.Sign(U);
        int S = a * b * F;
        Console.WriteLine("Площадь равна :" + " " + S);

    }
}
