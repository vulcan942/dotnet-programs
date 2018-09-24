using System;
using System.Collections;

namespace Project16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Hashtable ht = new Hashtable();
            ht.Add("Quantity","Furniture");
            ht.Add(250,"chair");
            ht.Add(50,"table");
            ht.Add(20,"Bed");

            foreach(var x in ht.Keys){
                Console.WriteLine("{0}=>{1}",x,ht[x]);
            }
            Console.WriteLine();
        }
    }
}
