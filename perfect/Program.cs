using System;
using System.Diagnostics.CodeAnalysis;
class perfect
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your start range : ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter Your end range :  ");
        int end = int.Parse(Console.ReadLine());

        for (int num = start; num <= end; num++)
        {

            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }

            if(sum == num && num != 0)
            {
                Console.WriteLine(num);
            }
        }

    }
}