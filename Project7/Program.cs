using System;

namespace Project7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=123;
            Object o =i; //Boxing
            int b =(int)o;
            Console.WriteLine("i = "+i);
            Console.WriteLine("o = "+o+"(Boxing)");
            Console.WriteLine("b = "+b+"(Unboxing)");
        }
    }
}
