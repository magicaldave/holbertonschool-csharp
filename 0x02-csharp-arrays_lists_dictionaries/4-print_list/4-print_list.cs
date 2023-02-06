using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Class containing methods for creating and printing a list of integers
/// </summary>
/// <author>S3kshun-8</author>
class List
{
    /// <summary>
    /// Creates and prints a list of integers of a given size.
    /// </summary>
    /// <param name="size">The size of the list to be created</param>
    /// <returns>The newly created list of integers, or null if size is less than 0</returns>
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> numbers = Enumerable.Range(0, size).ToList();

        Console.WriteLine(String.Join(" ", numbers));

        return numbers;
    }
}
