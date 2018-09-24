using System;

namespace Project9
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade=2;
            Console.WriteLine();
            switch(grade){

                case 1: Console.WriteLine("Excellent"); break;
                case 2: break;
                default : Console.WriteLine("Passed"); break;
            }     
            Console.WriteLine();
        }
    }
}
