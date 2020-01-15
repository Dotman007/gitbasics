using System;

namespace GitBasics
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(10, 10));
        }

        public static int Sum(int first, int second)
        {
            return first + second;
        }
        
        public static int Subtract(int first, int second)
        {
            return first - second;
        }
    }
}
