using System;
using System.Collections;

namespace Project17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Queue q= new Queue();
            q.Enqueue(1);
            q.Enqueue(5);
            q.Enqueue(7);
            q.Enqueue(3);
            Console.WriteLine("No. of elements in Queue: {0}",q.Count);
            Console.WriteLine();
        }
    }
}
