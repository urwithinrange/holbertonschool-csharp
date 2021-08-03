﻿using System;

/// <summary>Matrix math</summary>
class MatrixMath
{
    /// <summary>Method that adds two matrices and returns the resulting matrix</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            return new double[,] {{matrix[0, 0] * scalar, matrix[0, 1] * scalar}, {matrix[1, 0] * scalar, matrix[1, 1] * scalar}};
        }
        if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3 && matrix.GetLength(2) == 3)
        {
            return new double[,] {{matrix[0, 0] * scalar, matrix[0, 1] * scalar, matrix[0, 2] * scalar}, {matrix[1, 0] * scalar, matrix[1, 1] * scalar, matrix[1, 2] * scalar}, {matrix[2, 0] * scalar, matrix[2, 1] * scalar, matrix[2, 2] * scalar}};
        }
        return new double[,] {{-1}};
    }
}