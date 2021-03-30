using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Swap Numbers");

            int swapNumberFirst;
            int swapNumberSecond;

            Console.WriteLine("Enter your first swap Number");
            swapNumberFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second swap number");
            swapNumberSecond = Convert.ToInt32(Console.ReadLine());

            if (swapNumberFirst >= swapNumberSecond)
            {
                Console.WriteLine(" The numbers are " + swapNumberFirst + " " + swapNumberSecond + " after swaping");
            }
            else
            {
                Console.WriteLine(" The numbers are  " + swapNumberSecond + " " + swapNumberFirst);
            }

            Console.ReadLine();
        }
    }
}
