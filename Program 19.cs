using System;
using System.IO;

class MetricConverter
{
    static void Main()
    {
        string inputFile = "meters.txt";
        string outputFile = "feet.txt";

        // Write sample input
        Console.Write("Enter value in meters: ");
        double meters = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value in centimeters: ");
        double centimeters = Convert.ToDouble(Console.ReadLine());

        File.WriteAllText(inputFile, $"{meters}\n{centimeters}");

        // Read from file
        string[] lines = File.ReadAllLines(inputFile);
        meters = Convert.ToDouble(lines[0]);
        centimeters = Convert.ToDouble(lines[1]);

        // Conversion
        double totalMeters = meters + (centimeters / 100);
        double feet = totalMeters * 3.28084;
        double inches = totalMeters * 39.3701;

        // Save to output file
        File.WriteAllText(outputFile, $"Feet: {feet:F2}\nInches: {inches:F2}");

        Console.WriteLine("Conversion complete. Data saved to feet.txt.");
    }
}
