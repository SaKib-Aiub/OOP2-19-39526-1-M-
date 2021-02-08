using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofevenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int even = 0;
            int odd = 0;
            int n = 100;
            for (i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    even = even + i;
                }
                else
                    odd = odd + i;
            }

            Console.WriteLine("Even numbers sum: " + even);
            Console.WriteLine("Even numbers sum: " + odd);
        }
    }
}