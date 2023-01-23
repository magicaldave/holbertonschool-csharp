using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
		int tens, ones;
		for (tens = 0; tens <= 8; ++tens)
		{
			for (ones = 1; ones <= 9; ++ones)
			{
				if (tens < ones)
				{
					Console.Write("{0}{1}", tens, ones);
					if (tens < 8)
						Console.Write(", ");
				}
			}
		}
		Console.Write("\n");
        }
    }
}
