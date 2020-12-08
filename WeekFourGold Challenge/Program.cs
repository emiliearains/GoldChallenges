using System;

namespace WeekFourGold_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            School ElementarySchool = new ElementarySchool();
            School MiddleSchool = new MiddleSchool();
            School HighSchool = new HighSchool();

            ElementarySchool.Name = "Sweetser Elementary School";
            ElementarySchool.ID = 24601;
            ElementarySchool.MaxStudentPopulation = 600;

            MiddleSchool.Name = "Oak Hill Middle School";
            MiddleSchool.ID = 90210;
            MiddleSchool.MaxStudentPopulation = 1200;

            HighSchool.Name = "Spruce Mountain High School";
            HighSchool.ID = 8675309;
            HighSchool.MaxStudentPopulation = 3600;

            Console.WriteLine(ElementarySchool.TeachGym());
            Console.WriteLine(MiddleSchool.TeachGym());
            Console.WriteLine(HighSchool.TeachGym());
        }
    }
}
