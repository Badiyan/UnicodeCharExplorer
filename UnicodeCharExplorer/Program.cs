using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            ushort minBorder = 0x0030;
            ushort maxBorder = 0x0060;


            string userInputStr = Console.ReadLine();
            
            ushort number;
            bool success = ushort.TryParse(userInputStr, out number);
            if (success)
            {
                Console.WriteLine("Successfull parse");
            }
            else
            {
                Console.WriteLine($"Attempted conversion of '{userInputStr ?? "<null>"}' failed.");
            }

            Console.WriteLine(number);


            Console.WriteLine(number);


            for (ushort i = minBorder; i <= maxBorder; i++)
            {
                Console.WriteLine("{0} - ({1}) [{1:X}]", (char)i, i);
            }

            Console.ReadKey();
        }
        
    }
}


