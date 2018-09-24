using System;
using System.Text;
namespace Project10
{
    class Program
    {
        static void Main(string[] args)
        {
           StringBuilder s= new StringBuilder("Hello, World");
           Console.WriteLine();
           Console.WriteLine("Original: {0} ",s);
           s.Append('4'); 
           Console.WriteLine("After append: {0}",s);
           s.Insert(5,'5');
           Console.WriteLine("After Insert: {0}",s);   
           Console.WriteLine();        
        }
    }
}
