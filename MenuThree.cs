using System;
using System.Collections.Generic;
using System.Text;

namespace MenuApp
{
    class MenuThree
    {
       public static void ThirdWord()
        {
            Console.Clear();
            Console.WriteLine("Let Play a Three Word game Game\n");

            Console.WriteLine("Please enter a text of alteast 3 words\n");

            //  the input string.
            string inputString = Console.ReadLine();

            string[] X = inputString.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("     ");
            Console.WriteLine("The 3rd Word of your text is: \"{0}\" ", X[2]);

            Console.ReadLine();
        }
    }
}
