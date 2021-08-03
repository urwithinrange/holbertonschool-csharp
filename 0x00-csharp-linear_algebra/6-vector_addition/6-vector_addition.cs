using System;
/// <summary>VectorMath class</summary>
class VectorMath
{
    /// <summary>Module that returns a vector for a 2d array or 3d array</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            return new double[] {vector1[0] + vector2[0], vector1[1] + vector2[1]};
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            return new double[] {vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2]};
        }
        return new double[] {-1};
    }
}