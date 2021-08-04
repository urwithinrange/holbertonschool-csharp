using System;
/// <summary>Queue class</summary>
class Queue<T>
{
    /// <summary>Node class</summary>
    public class Node
    {
        public T value;
        public Node next = null;
        /// <summary>Method that takes a value for a new node and sets it</summary>
        public Node(T value)
        {
            this.value = value;
        }
    }

    public Node head;
    public Node tail;
    public int count;

    /// <summary>Method to the class Queue that crates a new Node and adds it to the end of queue</summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
        } 
        if (tail != null)
        {
            tail.next = newNode;
        }
        tail = newNode;
        count++;
    }
    /// <summary>Method that removes the first node and returns its value</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            T deqNode = head.value;
            head = head.next;
            count--;
            return deqNode;
        }
        
    }
    /// <summary>Method that returns the number of nodes in the queue</summary>
    public int Count()
    {
        return count;
    }
    /// <summary>Method checktype is going to rerturn the queue's type</summary>
    public Type CheckType()
    {
        return typeof(T);
    }

}