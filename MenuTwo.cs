using System;
using System.Collections.Generic;
using System.Text;

namespace MenuApp
{
   public class MenuTwo
    {
        public static void RepeatTenTimes()
        {
            Console.Clear();
            // Take the text input
            Console.WriteLine("Please Enter your Text here:\n");

            string inputData = Console.ReadLine();

            Console.WriteLine(" ");
            // loop over the input ten times
            for (int i = 0; i < 10; i++)
            {
                int k = i + 1;
                Console.Write("{0}. {1}, ", k, inputData);
            }
            Console.ReadLine();
        }
    }
}
