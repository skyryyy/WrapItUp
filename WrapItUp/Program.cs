using System;
using System.Collections.Generic;

namespace WrapItUp
{
    class Program
    {
        static PissLenght piss = new PissLenght();

        static void Main(string[] args)
        {
            List<string> whatPiss = new List<string>() {
            "Long piss (1)",
            "Short piss (2)",
            "Dubble up (3)"
            };
            string wienerLenght = "";           // Variabel för att kunna bestämma längden, 
                                                //den är en string eftersom man ska kunna skriva
                                                // i den och eftersom den ska åka igenom en TryParse.
            int thisWiener;                     //Variabeln som denna^^ kommer att typkonverteras till.
            int pissChoice = 5;
            string restart = "repee";

            Console.WriteLine("OMG, where is the nearest toilet?");
            Console.WriteLine("I need to pee.");
            Console.WriteLine("How long is your pp? (1-25 cm)");

            while (restart == "repee")
            {

                while (wienerLenght == "")                     //Loop som gör att man måste skriva in en acceptabel siffra mellan de jag bestämmt.
                {
                    wienerLenght = Console.ReadLine().Trim();       //Gör om den till en ReadLine så att man kan skriva i den.

                    bool yourWiener = int.TryParse(wienerLenght, out thisWiener);       //Typkonvertering till en integer.

                    if (thisWiener <= 0 || thisWiener >= 26)            //If-sats som hindrar gör att loopen kommer köras igen om typkonverteringen misslyckas.
                    {
                        Console.WriteLine("That is not a valid pp, try again");
                        wienerLenght = "";                                          //Ändrar så att loopen kommer köras igen.
                    }

                    if (thisWiener >= 1 && thisWiener <= 25)
                    {
                        Console.WriteLine("Wow, your pp is " + thisWiener + " cm long.");
                    }
                }

                Console.WriteLine("What are you feeling today?");

                foreach (string item in whatPiss)
                {
                    Console.WriteLine(item);
                }

                while (pissChoice == 5)
                {
                    int.TryParse(Console.ReadLine(), out pissChoice);
                    switch (pissChoice)
                    {
                        case 1:
                            piss.LongPiss();
                            break;

                        case 2:
                            piss.ShortPiss();
                            break;

                        case 3:
                            piss.DubbleUp();
                            break;

                        default:
                            Console.WriteLine("That's not a pissing option.");
                            pissChoice = 5;
                            break;
                    }
                }

                pissChoice = 5;

                Console.WriteLine("Do you need to go again? If so, type repee, if not, press any key then enter.");

                restart = Console.ReadLine().Trim().ToLower();
            }
        }



    }
}

