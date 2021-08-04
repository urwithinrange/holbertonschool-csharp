using System;

/// <summary>Queue class</summary>
class Queue<T>
{
    /// <summary>Node class</summary>

    public Node head;
    public Node tail;
    public int count;

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
    /// <summary>Method that returns the value of the first node</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
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
    /// <summary>Method that prints the list of Nodes</summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.value);
            temp = temp.next;
        }
    }
    /// <summary>Method that concatenates all values in the queue only if the queue is of type String or Char.</summary>
    public string Concatenate()
    {
        string str = "";
        if (head == null)
        {
           Console.WriteLine("Queue is empty");
           return null;
        }
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            System.Console.WriteLine("Concatenate is for a queue of Strings or Chars only.");
            return null;
        }        
        Node temp = head;
        while (temp != null)
        {
            str += temp.value.ToString();
            if (typeof(T) == typeof(string) && temp.next != null)
                str += " ";
            temp = temp.next;
        }
        return str;
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