using System;
namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World this is the week 3 friction assignment! ");
            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction();
            Fraction fraction3 = new Fraction();
            Fraction fraction4 = new Fraction();
            fraction2.SetTopNumber(5);
            fraction3.SetBothNumbers(3, 4);
            fraction4.SetBothNumbers(1, 3);

            // fraction1.SetTopFraction(10);
            // fraction2.SetBothFraction(9, 1);
            Console.WriteLine(fraction1.GetFractionString());
            Console.WriteLine(fraction2.GetFractionString());
            Console.WriteLine(fraction3.GetFractionString());
            Console.WriteLine($"{fraction3.GetDecimal(3, 4)}");
            Console.WriteLine(fraction4.GetFractionString());
            Console.WriteLine($"{fraction4.GetDecimal(1, 3)}");

        }

    }
    
}