using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter zero (0) to stop adding numbers.");
        List<int> numbers = new List<int>();
        List<int> positiveNum = new List <int>();
        int userInput = -1;
        int sum = 0;
        int positiveSum =0;
        // float positiveNum = 1;
        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            string inputValue = Console.ReadLine();
            if(int.TryParse(inputValue, out userInput))
            {
                int input = int.Parse(inputValue);
                if (input != 0)
                {
                    numbers.Add(input);
                    userInput= input;
                }
                else
                {
                    Console.WriteLine("Got yeah! ");
                }
                if (input > 0)
                {
                    positiveNum.Add(input);
                }
                
                

            }
            
            

            

        }
        foreach (int add in numbers)
                {
                    sum += add;
                    
                    
                }
        Console.WriteLine($"The sum is : {sum}");

        if (sum != 0)
        {
            int average = sum / numbers.Count;
            Console.WriteLine($"The average  is: {average}");
        }
        
        if (sum != 0)
        {
            int highestNum = numbers.Max();
        Console.WriteLine($"The largest number is: {highestNum}");
        }
        
        
        foreach (int positivenum in positiveNum)
        {
            positiveSum += positivenum;
        }
        if (positiveSum <= 0 )
        {
            Console.WriteLine("There are no positive number in the list.");
        }
        else
        {
            int smallestPositiveNum = positiveNum.Min();
            Console.WriteLine($"The smallest positive number is: {smallestPositiveNum}");
        }
            
         
        numbers.Sort();
        Console.WriteLine("The sorted List from smallest to largest is: ");

        foreach (int num in numbers)
            if (num != 0)
            {
                Console.WriteLine($"{num}");
            }
    }
       
}