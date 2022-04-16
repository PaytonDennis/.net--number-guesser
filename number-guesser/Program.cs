using System;

//name space
namespace number_guesser
{
    //Main class
    
    class Program

    {   // Entry point method

        static void Main(string[] args)
        {
            
            GetAppInfo(); // function to get user input

            GreetUser(); // function to greet user
            
            while (true) { 

                //Init correct number which is random
             Random random = new Random();

             //generates random number ans correctNumber
             int correctNumber = random.Next(1, 10);
            

             //Init guess var
             int guess = 0;

              Console.WriteLine("Guess a number between 1 and 10");


             //Ask user for number
              while (guess != correctNumber) {
                 string input = Console.ReadLine();


                  //error check

                   if (!int.TryParse(input, out guess))
                  {
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Input needs to be a number");
                     Console.ResetColor();

                    //continue
                       continue;
                  }
                    

                 //cast to int then put in guess var
                    guess = Int32.Parse(input);


                    if (guess > 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("correct number is less than ten");
                        Console.ResetColor();

                        //continue
                        continue;
                    }

                    //tells user if number is incorrect
                    if (guess != correctNumber)
                   {
                     Console.ForegroundColor = ConsoleColor.Red;

                     Console.WriteLine("Wrong number, please try again ");

                       Console.ResetColor();
                   }
                
                
               }

            //tell user if input is successful

             if (guess == correctNumber) {
                   Console.ForegroundColor = ConsoleColor.Blue;
                   Console.WriteLine("correct number");
                    Console.ResetColor();

                    //ask to play again
                    Console.WriteLine("Play again? [Y or N]");

                    //get answer
                    string answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                    {
                        continue;
                    }
                    else if (answer == "N")
                    {
                        return;
                    }
                    else
                    {
                        return;
                    }
            }
          }
             Console.ReadLine();
        }

        static void GetAppInfo()
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

            Console.ResetColor();
        }

        static void GreetUser()
        {
            //user name question
            Console.WriteLine("What is your name?");

            //user name input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello " + inputName + ", Let's play a game.", inputName);

        }
    }
}
