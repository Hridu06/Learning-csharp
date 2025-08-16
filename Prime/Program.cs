using System;

class prime
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Start Range : ");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Your end Range : ");
        int end = int.Parse(Console.ReadLine());

        for (int num = start; num < end; num++)
        {
            bool isPrime = true;

            if (num <=1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if(num % 2 == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            if(isPrime)
            {
                Console.WriteLine(num);
            }
        }
    }
}
