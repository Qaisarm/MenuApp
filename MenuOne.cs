using System;
using System.Collections.Generic;
using System.Text;

namespace MenuApp
{
    public class MenuOne
    {


        //Class for Group Ticket Price
        public static void GroupTicket()
        {
            Console.Clear();
            // Price list
            int[] priceList = new int[] { 80, 90, 120, 0 };

            // User input for number of persons
            Console.Write("Please Enter The Number of Persons is a Group:");
            Console.Write(" ");
            var groupAsString = Console.ReadLine();
            int nubr;

            //Checks whether the input in integer or not
            while (!int.TryParse(groupAsString, out nubr))
            {
                Console.WriteLine("This is not a number\n Please enter Number of Persons again.");
                groupAsString = Console.ReadLine();
            }

            // To store the required sum 
            int sum = 0;

            // loop over the number of persons in group
            for (int i = 0; i < nubr; i++)
            {
                Console.WriteLine("Please enter your age: ");
                var ageAsString = Console.ReadLine();

                int age;
                while (!int.TryParse(ageAsString, out age))
                {
                    Console.WriteLine("This is not a number! \nPlease enter your age again.");
                    ageAsString = Console.ReadLine();
                }

                int ageGroup = age;
               
                // Adds the sum according to age group
                if (ageGroup > 5 && ageGroup < 20)
                {
                    sum += priceList[0];
                }
                else if (ageGroup > 64 && ageGroup < 100)
                {
                    sum += priceList[1];
                }
                else
                {
                    if (ageGroup < 5 || ageGroup > 100)
                    {
                        sum += priceList[3];
                    }
                    else
                    {
                        sum += priceList[2];
                    }
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine("Total Number of Persons: {0} \nTotal Price is: {1} SEK", nubr, sum);
            Console.ReadLine();

        }
        //Class for Single Ticket Price
        public static void SingleTicket()
        {
            Console.Clear();

            // Take age as input and prints price accordingly
            do
            {
                int ageSingle = Util.AskForInt("Please Enter Your Age: ");


                int[] priceList = new int[] { 80, 90, 120, 0 };

                if (ageSingle > 5 && ageSingle < 20)
                {
                    Console.Write("\nYouth Price : {0} SEK",  priceList[0]);
                }
                else if (ageSingle > 64 && ageSingle < 100)
                {
                    Console.Write("\nPensioner Price : {0} SEK", priceList[1]);
                }
                else
                {
                    if (ageSingle < 5 || ageSingle > 100)
                    {
                        Console.Write("\nYour Entry is Free of cost ({0} SEK)", priceList[3]);
                    }
                    else
                    {
                        Console.Write("\nStandard Price : {0} SEK", priceList[2]);
                    }
                }

                Console.ReadLine();
                break;
            } while (true);
 
        }

    }
}

