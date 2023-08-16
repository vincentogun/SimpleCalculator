using System;
using System.Text;
using System.Collections.Generic;


namespace SimpleCalculator;
class Program
{
    static void Main(string[] args)
    {
        //DateTime.DaysInMonth(5, 7);
        Console.WriteLine("What is your name??: ");
        string name = "boye";
        
        Console.WriteLine("Welcome Mr " + name);
        Console.WriteLine("What is your Birth Year?");
        int age = 2023 - Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine("You are " + age +"yrs today. Happy Birthday Mr " + name);

    }
}
