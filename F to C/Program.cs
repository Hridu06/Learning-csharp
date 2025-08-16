using System;
class celcious
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the farenheight value : ");
        float f  = float.Parse(Console.ReadLine());

        float c =  5 * (f - 32) / 9;

        Console.WriteLine(c);
    }
}
