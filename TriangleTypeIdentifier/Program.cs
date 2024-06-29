using System;

class TriangleTypeCalculator
{
    static void Main()
    {
        Console.Write("Enter the length of side 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of side 2: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the length of side 3: ");
        double side3 = double.Parse(Console.ReadLine());

        string triangleType = DetermineTriangleType(side1, side2, side3);
        Console.WriteLine("The triangle is: " + triangleType);

        Console.ReadKey();
    }

    static string DetermineTriangleType(double side1, double side2, double side3)
    {
        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}

