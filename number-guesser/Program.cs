using System;

//name space
namespace number_guesser
{
    //Main class
    
    class Program
    {   // Entry point method

        static void Main(string[] args)
        {
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0";
            string appAuthor = "Payton Dennis";

            //changes info text color to green
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(appName + " " + appVersion);
            Console.WriteLine(" ");
            Console.WriteLine(appAuthor);
            Console.WriteLine(" ");

            //changes main text to white

            Console.ForegroundColor = ConsoleColor.White;

            //user name question
            Console.WriteLine("What is your name?");

            //user name input
            string input = Console.ReadLine();

            Console.WriteLine("Hello " + input + ", Let's play a game.", input);

            //Init correct number
            int correctNumber = 7;

            //Init guess var
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            if (guess != correctNumber)
                Console.WriteLine("Wrong number " + input);

            Console.ReadLine();
        }
    }
}
