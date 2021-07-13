using System;
class Program
{
    static void Main(string[] args)
    {
        for (int num = 00; num <= 99; num++)
        {    Console.Write($"{num / 10}{num % 10}");
                if (num < 99)
                Console.Write(", ");
        }
    }
}
