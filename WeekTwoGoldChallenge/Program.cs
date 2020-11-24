using System;

namespace WeekTwoGoldChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // New up instance of Greeter class -- call all three methods from Greeter
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Greeter myGreeter = new Greeter();
            Console.WriteLine(myGreeter.TakeNameSayHello(name));
            Console.WriteLine(myGreeter.SaysFarewellToName(name));
            Console.WriteLine(myGreeter.TimeGreetingToName(name));
        }
    }
}
