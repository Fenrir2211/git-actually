using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreetWhite();
            GreetBlack();
        }

        private static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }
        
        private static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }

    }
}
