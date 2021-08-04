using System;
/// <summary>Queue class</summary>
class Queue<T>
{
    /// <summary>Method checktype is going to rerturn the queue's type</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
