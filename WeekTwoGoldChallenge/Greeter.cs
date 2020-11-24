using System;
using System.Collections.Generic;
using System.Text;

namespace WeekTwoGoldChallenge
{
    class Greeter
    {
        // Method that takes in a name and says hello to the name
        public string TakeNameSayHello(string name)
        {
            return $"Hello, {name}!";
        }

        // Method that outputs a farewell to the name
        public string SaysFarewellToName(string name)
        {
            return $"Adios, {name}!";
        }

        // Method that gives time specific salutation
        public string TimeGreetingToName(string name)
        {
            DateTime currTime = DateTime.Now;
            string returnString = "";
            if (currTime.Hour < 12)
            {
                returnString = $"Good morning, {name}.";
            }
            else if (currTime.Hour >= 12 && currTime.Hour < 17)
            {
                returnString = $"Good afternoon, {name}.";
            }
            else if (currTime.Hour >= 17 && currTime.Hour < 21)
            {
                returnString = $"Good evening, {name}.";
            }
            else
            {
                returnString = $"Good night, {name}.";
            }
            return returnString;
        }

    }
}
