using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        bool playAgain = true;
        while (playAgain)
        {
            Random randomGenerator = new Random();
            int cMagic = randomGenerator.Next(1, 101);

            // Console.Write("What is the Magic number?: ");
            // string guessNumber = Console.ReadLine();
            int cGuess = -1;

            int count= 0;

            while (cGuess != cMagic)
            {
                Console.Write("What is the Magic number?: ");
                string input =  Console.ReadLine();
                if (int.TryParse(input, out cGuess))
                
                    {
                        count++;
                        if (cGuess > cMagic)
                            {
                                Console.WriteLine("Lower");
                            }
                        else if (cGuess < cMagic)
                            {
                                Console.WriteLine("Higher");
                            }
                        else
                            {
                                Console.WriteLine($"You guessed it! it took you {count} guesses.");
                            }
                    }
                else
                {
                    Console.WriteLine("That is not a  valid number try again: ");
                }
            }


        Console.Write("Do you want to play again? (yes/No): ");
        string response = Console.ReadLine().Trim().ToLower();

        if (response != "yes" && response != "y")
            {
                playAgain = false;
            }



        }
        

        
        
     


        



        

        
    }
}