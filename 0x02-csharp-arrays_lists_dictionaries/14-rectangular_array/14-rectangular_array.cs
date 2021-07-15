using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[5, 5];
        int r = 5, c = 5;

        for (int i = 0; i < c; i++)
        {
            for (int j = 0; j < r; j++)
            {
                if (i == 2 && j == 2)
                    Console.Write("1");
                else
                    Console.Write("0");
                if (j + 1 != r)
                    Console.Write(" ");
                if (j + 1 == r)
                    Console.Write("\n");
            }
        }    

    }
}
