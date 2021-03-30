using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Calculator");

            Console.WriteLine("Calculator");

            int firstNumber = 0;
            int secondNumber = 0;
            string operation;
            int result;

            Console.WriteLine("Enter a number");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a operation (+,-,/,*)");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    Console.WriteLine("Result is " + result);
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    Console.WriteLine("Result is " + result);
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    Console.WriteLine("Result is " + result);
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    Console.WriteLine("Result is " + result);
                    break;
                default:
                    Console.WriteLine("No such operator,try again");
                    break;
            }

            Console.ReadLine();
        }
    }
}
