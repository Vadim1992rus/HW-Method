/* 
Task #4
Суми квадратів елементів масіву
1) Возведение 
2) Сума елементів
*/
using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Array M * N \n");

        int[,] MyArr = { { 1, 2, 3 }, 
                         { 4, 5, 6 } };

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(MyArr[i, j] + "\t");
                Console.Write(Math.Pow(MyArr[i, j], 2) + "\n");
                Console.Write(Math.Pow(MyArr[i, j], 2) + Math.Pow(MyArr[i, j], 2) +" " + "сумма квадратов" + "\n");
            }

        }
    }
}