using System;

namespace Average_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Average Number");

            int numberFirst = 0;
            int numberSecond = 0;
            int numberThird = 0;
            int numberFourth = 0;

            double averageNumb;

            double averageSum;

            Console.WriteLine("Enter your first number");
            numberFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            numberSecond = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your third number");
            numberThird = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your fourth number");
            numberFourth = Convert.ToInt32(Console.ReadLine());


            averageNumb = (numberFirst + numberSecond + numberThird + numberFourth);

            averageSum = averageNumb / 4;

            Console.WriteLine("Average sum of the numbers is " + averageSum);

            Console.ReadLine();
        }
    }
}
