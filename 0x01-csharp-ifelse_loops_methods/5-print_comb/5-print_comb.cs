using System;
class Program
{
    static void Main(string[] args)
    {
        for (int num = 00; num <= 99; num++)
        {
            if (num == 99)
                Console.Write($"{num} \n");
            else
                Console.Write($"{num / 10}{num % 10}, ");
        }
    }
}
