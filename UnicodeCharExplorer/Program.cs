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
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Input from: to: borders number over space (Example: 1 100)");
            string userInput = Console.ReadLine();
            string[] inputBorders;
            inputBorders = userInput.Split(' ');
            int fromBorder = 0;
            int toBorder = 0 ;
            if (inputBorders.Length != 0)
            {
                int number;
                bool success = int.TryParse(inputBorders[0], out number);
                if (success)
                {
                    fromBorder = number;
                }
                else
                {
                    Console.WriteLine("Parsing error!");
                }

                int number2;
                bool success2 = int.TryParse(inputBorders[1], out number2);
                if (success2)
                {
                    toBorder = number2;
                }
                else
                {
                    Console.WriteLine("Parsing error!");
                }

                

                if (fromBorder > toBorder)
                { 
                    (fromBorder,toBorder) = (toBorder,fromBorder);
                }
            }
            else
            {
                Console.WriteLine("No borders inputed !");
            }

            Console.WriteLine("BORDERS FROM {0} TO {1}", fromBorder, toBorder);
            List<string> charStringsList = new List<string>();

            for (int i = fromBorder; i <= toBorder; i++)
            {
                String charString = String.Format("{0} - ({1}) [{1:X}]", (char)i, i);
                charStringsList.Add(charString);
            }

            Console.WriteLine("Input Columns Count:");
            string userInputColumns = Console.ReadLine();
            Console.Clear();
            int numberIntTest;
            int userInputColumnsInt;
            bool success3 = int.TryParse(userInputColumns, out numberIntTest);
            if (success3)
            {
                userInputColumnsInt = numberIntTest;
            }
            else
            {
                userInputColumnsInt = 3;
                Console.WriteLine("Parsing error!");
            }

            int columsCount;
            if (userInputColumnsInt >= 2)
            {
                columsCount = userInputColumnsInt;
            }
            else
            {
                columsCount = 2;
            }

            int rowsCount = (charStringsList.Count / columsCount) ;

            for (int i = 0; i < rowsCount; i++)
            {
                String outputString = "";
                for (int j = 0; j < columsCount; j++)
                {
                    outputString = outputString + charStringsList[(rowsCount * j) + i] + "\t";
                }
                Console.WriteLine(outputString);
            }
            if ((columsCount * rowsCount) < charStringsList.Count)
            {
                int lostElementsFrom = columsCount * rowsCount;
                int lostElementsTo = charStringsList.Count;
                for (int k = lostElementsFrom; k < lostElementsTo; k++)
                {
                    Console.WriteLine(charStringsList[k]);
                }

            }



            Console.ReadLine();
        }
        
    }
}


