using System;
class HelloWorld
{
    static void Main()
    {

        Console.WriteLine("\nЗадача текст");

        Console.WriteLine("Введите ваше 1 предложение");
        string element1 = Console.ReadLine();

        Console.WriteLine("Введите ваше 2 предложение");
        string element2 = Console.ReadLine();


        Console.WriteLine("==================");

        string[] text = new string[4];//МОЙ МАССИВ из 4 элементов
        text[0] = element1; // text[0] = "Влад";
        text[1] = element2;

        for (int i = 0; i < text.Length; i++)
        {
            Console.WriteLine(text[i]);
        }
        if (text[0] == "When" || text[0] == "when")
        {
            Console.WriteLine("STOP");
        }


        // Console.WriteLine();
    }
}