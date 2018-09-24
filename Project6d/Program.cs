using System;

namespace Project6d
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Today= DateTime.Now;
            DateTime yesterday= Today.AddDays(-1);
            Console.WriteLine(yesterday.DayOfWeek);
        }

    }
}
