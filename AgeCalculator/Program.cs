using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Type your birth year:");

        // Read and parse the birth year input
        int birthYear = int.Parse(Console.ReadLine());

        // Calculate the user's age
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        // Output the result
        Console.WriteLine($"You are {age} years old.");
    }
}
