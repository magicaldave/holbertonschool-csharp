using System;
/// <summary>
/// Array manipulations, including retrieval, replacement, and reversal.
/// </summary>
/// <author>S3kshun-8</author>
class Array
{
    /// <summary>
    /// Prints all integers of an array, in reverse order.
    /// </summary>
    /// <param name="array">The array to be printed in reverse order.</param>
    public static void Reverse(int[] array)
    {
	    if (array != null && array.Length > 1)
	    {
		    System.Array.Reverse(array);
		    Console.WriteLine(String.Join(" ", array));
		    return;
	    }
	    Console.WriteLine();
    }
}
