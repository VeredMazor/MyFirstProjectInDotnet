using System;
using System.Text.RegularExpressions;

// Namespace
namespace MyFirstProjectInDotnet
{


    // Main Class
    internal class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            getAppInfo();//Run app info function

            //Ask user name
            Console.WriteLine("what is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play Seven Boom!", inputName);

            while (true) {
                var count = 1;
                int save= count;

                Console.WriteLine("Rules: when there is a number that is divisible by 7 you have to write Boom!");
                Console.WriteLine("Lets start...");
                //While guess is not correct
                while (count<=1000){
                    save = count;
                    Console.WriteLine("-----{0}-----", save);
                   
                    // Get users input
                    String input = Console.ReadLine();
                    try { 
                    //Make sure its a number
                    if (count % 7 == 0)
                    {
                        if (input != "Boom!" && input != "boom!")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You are Lose!!!");
                            //Reset text color
                            Console.ResetColor();
                            count = 1001;
                        }
                        else if (input == "Boom!")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            //Tell user its the right number
                            Console.WriteLine("This is CORRECT!!!");
                            //Reset text color
                            Console.ResetColor();
                        }
                    }
                    else if ((!int.TryParse(input, out count))){
                        count = count + 2;
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;
                        //Tell user its the wrong number
                        Console.WriteLine("Please enter an actual number");
                        //Reset text color
                        Console.ResetColor();
                        count = save;
                        //Keep going
                        continue;
                    }
                    else{
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        //Tell user its the right number
                        Console.WriteLine("You are CORRECT!!!");
                        //Reset text color
                        Console.ResetColor();
                    }
                    count++;
                    }
                    catch(FormatException){
                        Console.WriteLine("Please enter an actual number");
                    }

                }

                //Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                    continue;

                else if (answer == "N")
                    return;

            }
        }
      static void getAppInfo(){
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Vered Mazor";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

        }
    }
}
