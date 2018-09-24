using System;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int n = num;
            int sum = 0;
            while(n!=0){
                int rem=n%10;
                sum=sum*10+rem;
                n/=10;
            }
            if(sum==num){
                Console.WriteLine("Palindrome");
            }
            else{
                Console.WriteLine("Not a Palindrome");
            }
        }
    }
}
