using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);
        string letterSign =  " ";
        string gradeLetter = " ";
        if (gradePercent >= 90)
        {
            gradeLetter = ("A");
        }
        else if (gradePercent >= 80)
        {
            gradeLetter = ("B");
        }
        else if (gradePercent >= 70)
        {
            gradeLetter = ("C");
        }
        else if (gradePercent >= 60)
        {
            gradeLetter = ("D");
        }
        else
        {
            gradeLetter  = ("F");   
        }
        string textVersionGrade = gradePercent.ToString();
        int numVersion = int.Parse(textVersionGrade[1].ToString());
        int passVersion = int.Parse(textVersionGrade.ToString());

            if (passVersion < 60)
            {
                letterSign = " ";
            }
        
            if (numVersion >= 7)
            {
                letterSign = "+";
            }
            else if (numVersion < 3)
            {
                letterSign = "-";
            }
            
            else
            {
                letterSign = " ";
            }
        
        

        

        if (gradeLetter == "A" && letterSign == "+")
        {
            letterSign= "";
        }

        if (gradeLetter == "F")
        {
            letterSign= "";
        }

        Console.WriteLine($"Your grade is: {gradeLetter}{letterSign}");

        if (passVersion >= 70)
        {
            Console.WriteLine($"Congratulations You Passed!");
        }
        else
        {
            Console.WriteLine($"You can do better next time!.");
        }


        

    }
}

