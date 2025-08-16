using System;
class fibonacci
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());

        int first = 0, second = 1, next;

        for (int i = 0; i < n; i++)
        {

            Console.WriteLine(first + " ");

            next = first + second;
            first = second;
            second = next;
        }
    }
   
}
