using System;
using Task_1_3;

namespace Task_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Please, enter your name: ");
            // var userName = Console.ReadLine();
            // Console.WriteLine($"Hello, {userName}");
            // Console.ReadKey();

            Console.WriteLine("Please, enter your name: ");
            Console.WriteLine(HelloLibrary.SayHello(Console.ReadLine()));
            Console.ReadKey();
        }
    } 
}
