using System;
using System.Collections;
using System.Linq;

namespace Project13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            String s="ACDEB";
            char[] c=s.ToCharArray(0,s.Length);
            foreach(char x in c.OrderBy(y => y)){
                Console.Write(x);
            }
            Console.WriteLine();
            foreach(char x in c.Reverse()){
                
                Console.Write(x);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
