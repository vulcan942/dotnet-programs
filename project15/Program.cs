using System;
using System.Collections;

namespace project15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Stack s= new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            foreach(var x in s){
                Console.Write("{0} ",x);
            }
            Console.WriteLine();
            s.Pop();
            s.Push(4);
            foreach(var x in s){
                Console.Write("{0} ",x);
            }
            Console.WriteLine();
        }
    }
}
