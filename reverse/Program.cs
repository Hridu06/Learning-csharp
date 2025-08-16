using System;
class reverse
{
    public static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5, 6 };

        int i = 0, j = a.Length - 1, temp;

        while (i < j)
        {
            temp = a[i];
            a[i] = a[j];
            a[j] = temp;
            i++;
            j--;
        }

        // Print using for loop (not foreach)
        Console.WriteLine("Reversed array:");
        for (int k = 0; k < a.Length; k++)
        {
            Console.Write(a[k] + " ");
        }
    }
}
