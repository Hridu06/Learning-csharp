using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start range: ");
            int start = int .Parse(Console.ReadLine());

            Console.WriteLine("Enter the end range: ");
            int End = int .Parse(Console.ReadLine());

            Console.WriteLine("Perfect numbers in this range:");
            for (int i = start; i <= End; i++)
            {
                int sum = 0;
                for (int j = 1; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                        
                }

                if (i == sum && i != 0)
                {
                    Console.WriteLine(i);
                }
                    
            }
        }
    }
}
