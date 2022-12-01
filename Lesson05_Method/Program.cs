using System;

namespace Lesson05_Method
{
    class Program
    {
        static void f(int a, char b)
        {
            while (a > 0)
            {
                Console.WriteLine($"my char is {b} ");
                a--;
            }
            
        }
        static void f2(int a, char b)
        {
           
            Console.WriteLine($"my char is {b} ");
            if (a > 0)
                f(a - 1, b);                  
                 
        }

        static int Power(int Number, int power)
        {
            int count = 1;
            while (power > 0)
            {
                count *= Number;
                power--;
            }

            return count;
        }

        static long fact(long Number)
        {
            long count = 1;
            if (Number == 1)
                return 1;

            count =(long) fact(Number-1) * Number;

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number and then char: ");
            int a = Convert.ToInt32(Console.ReadLine());
            char s = Convert.ToChar(Console.ReadLine());
            f(a, s);
            Console.WriteLine();
            f2(a, s);
            Console.WriteLine();

            Console.WriteLine("Enter the Number and then enter power:  ");
            int NumberPower = Convert.ToInt32(Console.ReadLine());
            int power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{NumberPower} to the {power} th power = {Power(NumberPower, power)}");

            Console.WriteLine();
            Console.WriteLine("Enter the number whose factorial you want to know: ");
            long Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"factorial {Number} = {fact(Number)}");
        }
    }
}
