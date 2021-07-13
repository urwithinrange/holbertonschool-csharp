using System;
class Program
{
    static void Main(string[] args)
    {
        for (int num = 00; num <= 90; num++)
        {
            int first_number = num / 10;
            int second_number = num % 10;
            if (num != 89 && first_number < second_number)
                Console.Write($"{num:D2}, ");
            else if (num == 89)
                Console.WriteLine($"{num:D2}");
        }
    }
}