using System;

namespace Project6c
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Today= DateTime.Now;
            DateTime yesterday= Today.AddDays(-1);
            Console.WriteLine(yesterday.ToString("dd/MM/yyyy"));
        }
    }
}
