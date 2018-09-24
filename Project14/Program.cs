using System;
using System.Collections;

namespace Project14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            ArrayList list= new ArrayList();
            list.Add(54);
            list.Add('a');
            list.Add(66.6);
            foreach(var x in list){
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }
    }
}
