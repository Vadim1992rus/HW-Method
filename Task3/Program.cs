class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Стоимость суточного рациона \n");

        int[,] MyArr = { { 12, 24, 31, 13, 41, 54, 65 },
                         { 400, 500, 600, 250, 210, 321, 430 } };

        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                //Console.WriteLine(MyArr[i, j] * MyArr[i, j] + " " + "грн" + "\n");
                //Console.WriteLine("-------------------------------------");
                Console.WriteLine(MyArr[0, j] * MyArr[1, j] + " " + "грн" + "\n");
                //Console.WriteLine("-------------------------------------");
                //Console.Write(MyArr[0, j] * MyArr[i, 0] + " " + "грн");
            }

        }
    }
}