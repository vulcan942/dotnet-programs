using System;

namespace Project12
{
    class Program
    {
        private string name=" ";
        public string Name{
            get{
                return name;
            }
            set{
                name = value;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine();
            p.Name="Bruce Wayne";
            Console.WriteLine("Hello, {0}",p.name);
            Console.WriteLine();
        }
    }
}
