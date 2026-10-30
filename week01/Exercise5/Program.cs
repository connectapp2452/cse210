using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine("Welcome to the program! ");
       static string PromptUserName ()
        {
            Console.Write("Please enter your first and last name: ");
            string userinput = Console.ReadLine();
            return userinput;

            
        }
        string username = PromptUserName();
        static int FavNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string favNum = Console.ReadLine();
            int favNumber = int.Parse(favNum);
            int squre = favNumber * favNumber;
            return squre; 
        }
        int favorite = FavNumber();

        Console.WriteLine($"{username}, the squere of your number  is {favorite}.");
        
    }

    
}