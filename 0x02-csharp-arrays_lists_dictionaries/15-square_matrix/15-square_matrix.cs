using System;
class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int morphious = myMatrix.GetLength(0);
        int trinity = myMatrix.GetLength(1);
        int[,] neo = new int[morphious, trinity];
        for (int i = 0; i < morphious; i++)
        {
            for (int j = 0; j < trinity; j++)
            {
                neo[i, j] = (int)Math.Pow(myMatrix[i, j], 2);
            }
        }
        return neo;
    }
}
