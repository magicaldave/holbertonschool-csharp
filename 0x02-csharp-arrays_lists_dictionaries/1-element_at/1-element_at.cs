using System;
/// <summary>
/// Class to retrieve elements from an array.
/// </summary>
/// <author>S3kshun-8</author>
class Array
{
    /// <summary>
    /// Retrieves an element from an array at the given index.
    /// </summary>
    /// <param name="array">The array from which to retrieve the element.</param>
    /// <param name="index">The index of the element to retrieve.</param>
    /// <returns>The element at the given index, or -1 if the index is out of range.</returns>
    public static int elementAt(int[] array, int index)
	{
		if (index < 0 || index > array.Length)
		{
			Console.WriteLine("Index out of range");
			return -1;
		}
		return array[index];
    }
}
