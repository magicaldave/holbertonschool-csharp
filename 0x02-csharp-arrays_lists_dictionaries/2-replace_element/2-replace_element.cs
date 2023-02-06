using System;
/// <summary>
/// Class to manipulate elements in an array.
/// </summary>
/// <author>S3kshun-8</author>
class Array
{
    /// <summary>
    /// Replaces an element of an array at the given index.
    /// </summary>
    /// <param name="array">The array in which to replace the element.</param>
    /// <param name="index">The index of the element to replace.</param>
    /// <param name="n">The value to replace the element with.</param>
    /// <returns>The updated array, or the unchanged array if the index is out of range.</returns>
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index <= 0 || index >= array.Length)
		Console.WriteLine("Index out of range");
	array[index] = n;
        return array;
    }
}
