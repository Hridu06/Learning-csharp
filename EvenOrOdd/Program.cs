using System;
using System.Security.Cryptography;
using System.Transactions;

class EvenOrOdd
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else if (number % 2 != 0)
        {
            Console.WriteLine("Odd");
        }
        else {
            Console.WriteLine("invalid");
                }
            
    }

}
