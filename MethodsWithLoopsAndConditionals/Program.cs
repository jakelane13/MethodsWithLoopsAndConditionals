using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRange();
            Threes();
            IsEqual();
            IsEven(1);
            IsPositive(1);
            CanVote(18);
        }

        public static bool CanVote(int num)
        {
            Console.WriteLine("How old are you?");
            num = int.Parse(Console.ReadLine());

            if (num >= 18)
            {
                Console.WriteLine("Get out there and vote!");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry you can't vote yet :(");
                return false;
            }
        }

        public static bool IsPositive(int num)
        {
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("That number is positive!");
                return true;
            }
            else
            {
                Console.WriteLine("That number is negative");
                return false;
            }
        }

        public static bool IsEven(int num)
        {
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) 
            {
                Console.WriteLine("Even");
                return true;
            }
            else
            {
                Console.WriteLine("odd");
                return false;
            }
        }

        public static void IsEqual()
        {
            Console.WriteLine("give me 2 numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine($"{a} is equal to {b}");
            }
            else
            {
                Console.WriteLine($"{a} is not equal to {b}");
            }
        }

        public static void Threes()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintRange()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
