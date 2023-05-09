using System;
using System.Linq;
class Array {
/// <summary>
/// Creates and prints an array of integers of a given size.
/// </summary>
/// <param name="size">The size of the array to create</param>
/// <returns>The newly created array</returns>
/// <author>S3kshun-8</author>
	public static int[] CreatePrint(int size)
	{
		int[] IntArray;

		// Check if size is greater than 0. If yes, create an array using the range 0 to size-1 and assign it to IntArray.
		// If size is zero, create an empty array, otherwise initialize IntArray as null.
		IntArray = size > 0 ? Enumerable.Range(0, size).ToArray() : (size == 0 ? new int[0] : null);

		// Check if size is greater than 0. If yes, print the elements of IntArray joined with a space.
		// If size is 0, print a newline character.
		// If size is less than 0, print "Size cannot be negative".
		Console.WriteLine(size > 0
				  ? string.Join(" ", IntArray)
				  : size == 0
				  ? "\n"
				  : "Size cannot be negative");

		return IntArray;
	}
}
