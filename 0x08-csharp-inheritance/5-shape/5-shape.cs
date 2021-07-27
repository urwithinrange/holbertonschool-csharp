using System;
using System.Collections.Generic;

/// <summary>Shapeclass</summary>
class Shape
{
    /// <summary>Method returns new Exception</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
