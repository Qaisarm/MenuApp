﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MenuApp
{

    //Static class cant make instances of. Exactly as the Console class for example

    public static class Util

    {

        //must be static in a static class

        //string return type

        //AskForString method name

        public static string AskForString(string prompt)

        {

            bool correct = true;

            string answer; //Scope



            do //Repeat

            {

                Console.WriteLine(prompt);

                answer = Console.ReadLine();


                //If answer is not null or empty string

                if (!string.IsNullOrEmpty(answer))

                {

                    //Set bool correct to false to exit loop

                    correct = false;

                }

            } while (correct);  //until we have get a correct value


            return answer;  //return value

        }

        public static int AskForInt(string prompt)

        {

            bool success;

            int answer;  //Scope


            do //Repeat

            {

                string input = AskForString(prompt);

                //Try to parse string to int returns bool

                //If true exit loop

                success = int.TryParse(input, out answer);

                if (!success)

                {

                    //Write errormessage

                    Console.WriteLine("This is not a number\n Please enter you age again.");

                }

            } while (!success);

            //Returns parsed string

            return answer;

        }

    }

}