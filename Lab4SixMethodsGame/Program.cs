using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Create a game that accepts user input 0-6. Display a menu to the user. Entering 0 exits the application. 
 * If the user types in 1-6, call one of the methods below and do anything of your choosing as long as it adheres to the following rules:

Method 1: static void method that accepts no parameters
Method 2: static, non-void method that accepts one parameter and returns a value
Method 3: static method of any return type with at least one non-optional and at least one optional parameter
Method 4: static method of any return type that uses recursion to call itself
Method 5: static method of any return type that defines and uses a ref or out parameter
Method 6: static method of any return type that overloads one of the other methods
Again, you must create one of each method defined above. Once the method is run, return to the main menu until the user exits the application using 0.*/

    /* This game will be the character creation section of a role playing game.
     I'll use player input to determine traits
     based on his/her input 
     it's not as fancy as I'd like, because I'm still learning
     it's also not error-free <chagrin>*/

namespace Lab4SixMethodsGame
{
    class Program
    {
        static void Main()
        {
            Intro();

            int mainSelect = 7; //initialzed to 7 because 0-6 do things.

            while (mainSelect != 0) 

            {
                //the next several lines are the main menu
                //they all use the Main method and at least one other method.

                Console.WriteLine("\nPlease select from the following:"); 
                Console.WriteLine("\t1 for class selection screen.");   //has error in recursive. it sort of works.
                Console.WriteLine("\t2 to roll your stats.");  //won't print results to screen. did I get too fancy?
                Console.WriteLine("\t3 to guage your luck.");  //done, correct. use of "ref"
                Console.WriteLine("\t4 to test your math skills.");  //done, correct. overloaded method.
                Console.WriteLine("\t5 to learn about your enemies."); //done, correct. optional parameter.
                Console.WriteLine("\t6 to read a hint.");  //done, correct. accepts a parameter and returns a value.
                Console.WriteLine("\t0 to exit game.");  //done

                mainSelect = int.Parse(Console.ReadLine());

                //the next several lines activate depending on the user's selection
                if (mainSelect == 1)
                {
                    Console.WriteLine(ChooseCharacter());
                }
                if (mainSelect == 2)
                {
                    //this method is not working right... it will return only one number
                    RollStats(0, 0, 0);

                    Console.WriteLine($"Your stats are: {RollStats(0, 0, 0)}.");
                    /*Console.WriteLine($"\tStrength: {str}");
                    Console.WriteLine($"\tDexterity: {dex}");
                    Console.WriteLine($"\tIntelligence: {intel}"); */
                    //those last three lines are what I WANTED to return.
                    //doesn't work.

                    Console.ReadLine();
                }
                
                if (mainSelect == 3)
                {
                    int luck;
                    Console.WriteLine("On what day of the month were you born?");
                    luck = int.Parse(Console.ReadLine());

                    Console.WriteLine("Did you know your luck is");
                    Console.WriteLine("\tyour birthday multiplied by 2");
                    Console.WriteLine("\tthen divided by 5?");
                    Console.WriteLine($"Since your birthday is {luck}...");

                    AddLuck(ref luck);

                    Console.WriteLine($"\t...your luck is {luck}."); 
                }
                
                if (mainSelect == 4)
                {
                    Console.WriteLine("Let's see if you understand math.");
                    Console.WriteLine("Here are two accurate statements:\n");

                    Console.WriteLine($"3 times 3 is {SquareMathTest(3)}.");
                    Console.WriteLine($"3.1 times 3.1 is {SquareMathTest(3.1)}.");

                    Console.WriteLine("Did you understand these math problems? yes/no");
                    string answer = Console.ReadLine();

                    if (answer == "yes")
                {
                    Console.WriteLine("Good, because it took me forever to figure out how to code that.");
                }
                    else
                {
                    Console.WriteLine("Too bad. Consider rolling a rogue.");
                }
                    Console.ReadLine();
        }
                if (mainSelect == 5)
                {
                    Console.WriteLine("Enemies vary in level of scariness and silliness.");
                    Console.WriteLine("Let's figure out how silly your enemies will be.");

                    Console.WriteLine("\nOn a scale of 1 - 10, how scary are the Steelers?");
                    int steelersAnswer = int.Parse(Console.ReadLine());

                    Console.WriteLine("On a scale of 1 - 10, how scary are the Fembots?");
                    int fembotAnswer = int.Parse(Console.ReadLine());

                    Console.WriteLine($"The Steelers are level {steelersAnswer} on scariness");
                    Console.WriteLine($"\tbut a level { SillyEnemies(2, steelersAnswer)} on silliness, which makes them very silly.");

                    Console.WriteLine($"The Fembots are level {fembotAnswer} on scariness");
                    Console.WriteLine($"\tbut a level { SillyEnemies(fembotAnswer)} on silliness, which makes them only mildly silly.");

                    Console.WriteLine("\nDon't worry if those numbers seem nonsensical... this whole calculation is very silly.");
            
                    Console.ReadLine();
                }

                if (mainSelect == 6)
                {
                    HintMethod("Remember to save your game often!");
                }
            }
        }

        static int RollStats(int str, int dex, int intel)  //this links to choice 2
        {
            //this is the method that I can't get to return the results
            //is it because I'm trying to return more than one result?
            //I don't get any error messages to help me.

            Console.WriteLine("Hit <Enter> to roll your primary statistics:");
            Console.ReadLine();

            Random randomNumbers = new Random();
            return str = randomNumbers.Next(1, 7); 
            return dex = randomNumbers.Next(1, 7);    
            return intel = randomNumbers.Next(1, 7);

            return str;
            return dex;
            return intel;
        }

        static void Intro() //this always runs
        {
            Console.WriteLine("Pretend it is 1984 and you're about to play an amazing new text adventure.\n");
            Console.WriteLine("Welcome to the Character Creation Screen.\n");
            Console.WriteLine("Just follow the instructions.");
            Console.WriteLine("Hit <Enter> if you don't know what else to do.");

            return;
        }
        
        static void HintMethod(string thingToSay) //this links to choice 6
        {
            Console.WriteLine(thingToSay);
            return;
        }

        static string ChooseCharacter() //this links to choice 1
                                        //note the recursive in the "default" case. 
                                        //it sometimes works... but sometimes gives a funny result and
                                        //returns the user to the main menu
        {
            string charChoice = "";

            Console.WriteLine("Which of these is your favorite word?");
            Console.WriteLine("\tSMASH");
            Console.WriteLine("\tKazaa");
            Console.WriteLine("\tShh");
            Console.WriteLine("\tHeel");
            Console.WriteLine("\tLalala");
            Console.WriteLine("\tAmen");
            charChoice = (Console.ReadLine());

            switch (charChoice)
            {
                case "SMASH":
                    return "You're a Warrior. Equip a sturdy shield!";
           
                case "Kazaa":
                    return "You're a Sorceress. You're deadly but delicate.";
   
                case "Shh":
                    return "You're a Rogue. Be prepared to be unpopular.";
                   
                case "Heel":
                    return "You're a Huntress. A wolf is a woman's best friend!";
                    
                case "Lalala":
                    return "You're a Bard. Keep those vocal chords limber.";
             
                case "Amen":
                    return "You're a Priestess. Everyone's death will be your fault.";
                
                default:
                    ChooseCharacter(); //this doesn't quite work. 
                    return "That's not a choice, select again."; 
        }
    }

        static void AddLuck (ref int input) //this method links to choice 3
            {
                input = (input * 2) / 5;
                return;
            }

        static int SquareMathTest(int intValue)  //this is the method for squaring integers, linked to choice 4
        {
            return intValue * intValue;
        }

        static double SquareMathTest(double doubleValue)  //this one squares doubles, linked to choice 4
        {
            return doubleValue * doubleValue;
        }

        static int SillyEnemies(int justSilly, int verySilly = 2)  //this method links to choice 5
        {
            int result = 1;

            for (int counter = 1; counter <= verySilly; ++counter)
            {
                result *= justSilly;
            }

            return result;
        }
    }
}