using System;

namespace SPOJ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add range of number. Script always start from 1");
            int n = Int32.Parse(Console.ReadLine());



            for (int i = 1; i <= n; i++)
            {
                Prime.IsPrime(i);
            }




        }
        
    }
}


