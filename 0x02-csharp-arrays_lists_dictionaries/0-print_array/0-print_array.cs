using System;
class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] num = new int[size];
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = i;
            Console.Write(num [i]);
            if (i + 1 != num.Length)
                Console.Write(" ");
        }
        Console.Write("\n");
        return (num);
    }

}
