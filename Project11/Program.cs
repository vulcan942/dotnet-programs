using System;

namespace Project11
{
    class Program
    {
        public void print(){
            Console.WriteLine("Hello, World");

        }
        public int print(int a,int b){
            return  a + b;
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            Console.WriteLine();
            p.print();
            Console.WriteLine(p.print(5,6));
            Console.WriteLine();
        }
    }
}
