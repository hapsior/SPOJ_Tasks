using System;
using System.Collections.Generic;
using System.Text;

namespace SPOJ
{
    class Prime
    {
        public static void IsPrime(int n)
        {
            int l = 0;

            if (n == 1)
            {
                Console.WriteLine($"{n} NO");
            }
            if (n == 2)
            {
                Console.WriteLine($"{n} YES");
            }
            for (int x = 2; x < n; x++)
            {
                if (n % x == 0)
                {
                    Console.WriteLine($"{n} NO");
                    l = n;
                    break;
                }
            }
            if (n != l)
            {
                Console.WriteLine($"{n} YES");
            }
        }
    }
}
