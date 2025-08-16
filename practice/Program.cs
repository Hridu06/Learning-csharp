using System;

class AreaCalculator
{
    static void Main()
    {
        Console.WriteLine("Choose a shape to calculate the area:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Triangle");
        Console.Write("Enter your choice (1-3): ");

        int choice = int.Parse(Console.ReadLine());
        double area = 0;

        switch (choice)
        {
            case 1: // Circle
                Console.Write("Enter the radius: ");
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
                Console.WriteLine($"The area of the circle is: {area:F2}");
                break;

            case 2: // Rectangle
                Console.Write("Enter the length: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter the width: ");
                double width = double.Parse(Console.ReadLine());
                area = length * width;
                Console.WriteLine($"The area of the rectangle is: {area:F2}");
                break;

            case 3: // Triangle
                Console.Write("Enter the base: ");
                double baseLength = double.Parse(Console.ReadLine());
                Console.Write("Enter the height: ");
                double height = double.Parse(Console.ReadLine());
                area = 0.5 * baseLength * height;
                Console.WriteLine($"The area of the triangle is: {area:F2}");
                break;

            default:
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 3.");
                break;
        }
    }
}