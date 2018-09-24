using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a=b;
            b=c;
            Console.WriteLine("The Value of a: "+a);
            Console.WriteLine("The Value of b: "+b);
        }
    }
}
