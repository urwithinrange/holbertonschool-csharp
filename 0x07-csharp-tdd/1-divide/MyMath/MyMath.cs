using System;

namespace MyMath
{
    /// <summary>Matrix Class.</summary>
    public class Matrix
    {
        /// <summary>Gets quotient of matrix values divided by num.</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null || num == 0)
            {
                if (num == 0)
                    Console.WriteLine("Num cannot be 0");
                return null;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i, j] / num;
                }
            }
            return matrix;
        }
    }
}
