using System;

namespace MenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dear Coustomer You have entered to Main Menu of this Program\n" +
                "You have following Options to Select from:");

            bool displayMenu = true;
            while (displayMenu)
            {
                // Displays the Main Menu to User
                displayMenu = MainMenu();
            }

        }


        private static bool MainMenu()
        {
            // Takes input from the user
            Console.WriteLine(" ");
            Console.WriteLine("Press (1) to Check the Main Menu:");
            Console.WriteLine("Press (0) to Exit:");

            string result = Console.ReadLine();

           // Initialize the user options
                if (result == "1")
                {
                
                SecondMenu();
                
                return true;
                }
                else if (result == "0")
                {

                 return false;
                }
                else { 
                    Console.WriteLine("You have entered a Incorrect Option\n" +
                        "Please Select a Correct Option from the Following Menu.");

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                return true;
                }
            
          
        }
          // This is the second Menu
            private static bool SecondMenu()
            {
                Console.Clear();
                Console.WriteLine("Select from the Following option:\n" +
                    " ");
                Console.WriteLine("If you are Youth or Senior Citizen Press 1 ");
                Console.WriteLine("If you Want to Print Something Ten Times Press 2 ");
                Console.WriteLine("If you want to play Three Word Game Press 3");
                Console.WriteLine("If You want to exit this Menu Press 9 ");

                string result = Console.ReadLine();
                if (result == "1")
                {
                YouthSeniorCitizen();
                    return true;
                }
                else if (result == "2")
                {
                RepeatTenTimes();
                    return true;
                }
                else if (result == "3")
                {
                ThirdWord();
                    return true;
                }
                else if (result == "9")
                {
                return false;
                }
                else
                {
                    return true;
                }
            }
        //Class for Menu Option for Price
            private static void YouthSeniorCitizen()
            {
                Console.Clear();
            
                Console.Write("Please Enter Your Age:");
                Console.Write(" ");
            // Take age as input
            int age = int.Parse(Console.ReadLine());
           

            if (age > 5 && age < 20)
            {
                Console.Write("\nYouth Price : 80 SEK");
            }
            else if (age > 64 && age < 100)
            {
                Console.Write("\nPensioner Price : 90 SEK");
            }
            else 
            {
                if (age < 5 || age > 100)
                {
                    Console.Write("\nYour Entry of Free of cost");
                }
                else { 
                Console.Write("\nStandard Price : 120 SEK");
                }
            }

            Console.ReadLine();
            }
            private static void RepeatTenTimes()
            {
                Console.Clear();
                Console.WriteLine("Please Enter your Text here:\n");

            string inputData = Console.ReadLine();

            Console.WriteLine( " " );
            for (int i = 0; i < 10; i++)
            {
                int k = i + 1;
                Console.Write( "{0}. {1}, ", k,inputData);
            }
            Console.ReadLine();
            }
        private static void ThirdWord()
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
