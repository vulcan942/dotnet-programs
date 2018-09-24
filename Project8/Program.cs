using System;

namespace Project8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0]= new int[3]{4,5,6};
            arr[1]= new int[4]{6,7,8,9};
            arr[2]= new int[2]{2,3};
            foreach(int[] x in arr){
                foreach(int y in x){
                    Console.Write(y+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
