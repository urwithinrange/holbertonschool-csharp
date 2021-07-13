using System;
class Program
{
    static void Main(string[] args)
    {
        for (int num = 0; num < 99; num++)
            Console.Write($"{num} = 0x{num:x0}\n");
    }
}
