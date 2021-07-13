using System;

class Program
{
    static void Main()
    {
        char alphabet;
        for (alphabet = 'a'; alphabet <= 'z'; alphabet++)
            if (alphabet == 'q' || alphabet == 'e')
                continue;
            else
                Console.Write(alphabet);
    }
}