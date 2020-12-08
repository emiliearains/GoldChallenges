using System;
using System.Collections.Generic;
using System.Text;

namespace WeekFourGold_Challenge
{
    abstract class School
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int MaxStudentPopulation { get; set; }
        
        public virtual string TeachGym()
        {
            return "The students go to gym class.";
        }

    }

    
}
