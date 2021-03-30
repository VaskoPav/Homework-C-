using System;

namespace Tik_Tak_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tik-Tak Numbers divisible by 3 and 5");

            int divisibleNumber;


            Console.WriteLine("Enter a number ");
            divisibleNumber = Convert.ToInt32(Console.ReadLine());


            if (divisibleNumber % 3 == 0)
            {
                Console.WriteLine("The number is Tik " + divisibleNumber + " is divisible by 3");
            }
            if (divisibleNumber % 5 == 0)
            {
                Console.WriteLine("The number is Tak " + divisibleNumber + " is divisible by 5");
            }
            if (divisibleNumber % 3 == 0 && divisibleNumber % 5 == 0)
            {
                Console.WriteLine("The number is Tik-Tak " + divisibleNumber + " is divisible by 3 and 5");
            }
            else
            {
                Console.WriteLine("The number is not divisble by 3 and 5, it is divisible only with one of this numbers");
            }

            Console.ReadLine();
        }
    }
}
