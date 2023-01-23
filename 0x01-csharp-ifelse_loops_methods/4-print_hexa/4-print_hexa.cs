using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
		// Write 0 to 98 in decimal, then hex.
		// Format: DEC = HEX \n
		int display = 0;
		for (; display <= 98; display++)
		{
			Console.Write("{0} = 0x{0:x}\n", display);
		}
        }
    }
}
