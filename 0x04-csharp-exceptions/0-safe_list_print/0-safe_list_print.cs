using System;
using System.Collections.Generic;

class List
{
	public static int SafePrint(List<int> myList, int n)
	{
		int printed;
		if (n <= 0)
			return 0;
		for (printed = 0; printed < n; ++printed)
		{
			try
			{
				Console.WriteLine("{0}", myList[printed]);
			}
			catch (Exception)
			{
				return printed;
			}
		}
		return printed;

        }
}
