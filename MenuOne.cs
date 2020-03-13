using System;
using System.Collections.Generic;
using System.Text;

namespace MenuApp
{
    public class MenuOne
    {
       
     
        //Class for Single Ticket Price
        public static void GroupTicket()
        {
            Console.Clear();
            Console.Write("Please Enter The Number of Persons is a Group:");
            Console.Write(" ");
            var groupAsString = Console.ReadLine();
            int nubr;
            while (!int.TryParse(groupAsString, out nubr))
            {
                Console.WriteLine("This is not a number\n Please enter you age again.");
                groupAsString = Console.ReadLine();
            }
            

            for (int i = 0; i < nubr; i++)
            {
                int age;
                // Check whether in input is number or not
                do
                {                 
                    int ageGroup = Util.AskForInt("Please Enter Your Age: ");

                    ageGroup = age;


                    
                    
                    break;
                } while (true);
                int sumTotal = 0;
                sumTotal += sumTotal;
                Console.WriteLine("Total Number of Persons are: {0} \n Total Price : {1} ", nubr, sumTotal);
                Console.ReadLine();

            }

            
        }

        //Class for Single Ticket Price
        public static void SingleTicket()
        {
            Console.Clear();


            
            // Take age as input
            do
            {
                int ageSingle = Util.AskForInt("Please Enter Your Age: ");
                int[] priceList = new int[] { 80, 90, 120 };


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
                        Console.Write("\nYour Entry of Free of cost");
                    }
                    else
                    {
                        Console.Write("\nStandard Price : {0} SEK", priceList[2]);
                    }
                }

                Console.ReadLine();
                break;
            } while (true);

            /*var ageAsString = Console.ReadLine();

            // Check whether in input is number or not
            int age;
            while (!int.TryParse(ageAsString, out age))
            {
                Console.WriteLine("This is not a number\n Please enter you age again.");
                ageAsString = Console.ReadLine();
            }*/

            
        }
        
        
    }
}
