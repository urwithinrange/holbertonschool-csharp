﻿using System;
using System.Collections.Generic;
class Int
{
    public static void divide(int a, int b)
    {
        int div = 0;
        try
        {
            if (b == 0)
                throw new DivideByZeroException();
            div = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {div}");
        }
    }
}