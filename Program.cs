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
            else
            {
                Console.WriteLine("You have entered a Incorrect Option\n" +
                    "Please Select a Correct Option from the Following Menu.\n");
                Console.WriteLine(" ");
                return true;
            }

        }
        // This is the second Menu
        private static bool SecondMenu()
        {
            Console.Clear(); // Clears the output
                             // Shows the Menu Options
            Console.WriteLine("Select from the Following option:\n" +
                " ");
            Console.WriteLine("If you Want to know the Ticket Price Press 1 ");
            Console.WriteLine("If you Want to Print Something Ten Times Press 2 ");
            Console.WriteLine("If you want to play Three Word Game Press 3");
            Console.WriteLine("If You want to exit this Menu Press 9 ");
            // Takes Options input
            string result = Console.ReadLine();
            if (result == "1")
            {
                // Prints the options 
                Console.WriteLine(" ");
                Console.WriteLine("Press (1) for Single Ticket");
                Console.WriteLine("Press (2) for Group Ticket");
                // Takes input Options
                string ticketType = Console.ReadLine();
                if (ticketType == "1")
                {
                    MenuOne.SingleTicket();
                }
                else if (ticketType == "2")
                {
                    MenuOne.GroupTicket();
                }

                return true;
            }
            else if (result == "2")
            {
                MenuTwo.RepeatTenTimes();
                return true;
            }
            else if (result == "3")
            {
                MenuThree.ThirdWord();
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




    }
}
