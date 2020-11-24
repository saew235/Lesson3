using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            char next = (char) (c + 1);
            Console.WriteLine(next);
        }
    }
}
