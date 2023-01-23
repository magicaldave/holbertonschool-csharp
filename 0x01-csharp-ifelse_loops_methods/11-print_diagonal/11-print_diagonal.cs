using System;

class Line
{
	public static void PrintDiagonal(int length)
	{
		int linestep;
		// print \ length number of times
		if (length <= 0)
		{
			Console.Write('\n');
			return;

		}
		for (linestep = 1; linestep <= length; ++linestep)
			Console.WriteLine(new string(' ', linestep) + '\\');
	}
}
