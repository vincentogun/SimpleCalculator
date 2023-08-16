using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SimpleCalculator;
class Program
{
    static void Main(string[] args)
        {
            int firstNumber, secondNumber, userOperator;
            double result;
            char choice;

            try
            {
                do
                {

                    Console.WriteLine("======================================");
                    Console.WriteLine("SIMPLE CALCULATOR!!!");
                    Console.WriteLine("======================================");
                    Console.WriteLine("                              ");


                    //User Input for First and Second Value
                    Console.Write("Enter the first number: ");
                    firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Second number: ");
                    secondNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");

                    //User input of Operator
                    Console.WriteLine("Choose An Operation:\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
                    Console.WriteLine("");

                    Console.Write("Enter the number corresponding to the operation: ");
                    userOperator = Int32.Parse(Console.ReadLine());

                    //Calculator 

                    if (userOperator == 1)
                    {
                        result = firstNumber + secondNumber;
                        Console.WriteLine($"Result: {firstNumber} + {secondNumber} = " + result);
                    }
                    else if (userOperator == 2)
                    {
                        result = firstNumber - secondNumber;
                        Console.WriteLine($"Result: {firstNumber} - {secondNumber} = " + result);
                    }
                    else if (userOperator == 3)
                    {
                        result = firstNumber * secondNumber;
                        Console.WriteLine($"Result: {firstNumber} * {secondNumber} = " + result);
                    }
                    else if (userOperator == 4)
                    {
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"Result: {firstNumber} / {secondNumber} = " + result);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice. Try Again");
                    }

                    Console.WriteLine("");

                    Console.WriteLine("Do you want to continue: y/n ?");
                    choice = Convert.ToChar(Console.ReadLine().ToLower());

                }  while (choice == 'y');
            }
            catch (FormatException format)
            {
                Console.WriteLine("Error: " + format.Message);
            }
        }
}
