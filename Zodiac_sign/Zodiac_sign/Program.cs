using System;

class ChineseZodiac
{
    static void Main()
    {
        string[] zodiac = {
            "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox",
            "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep"
        };

        Console.Write("Enter your birth year: ");
        int year = int.Parse(Console.ReadLine());

        int index = year % 12;
        Console.WriteLine("Your Chinese Zodiac is: " + zodiac[index]);
    }
}
