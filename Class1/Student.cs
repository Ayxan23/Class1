using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    public class Student
    {
        public string Name;
        public string Surname;
        public int Group;
        public int Point;
        public bool IsGraduated;

        public Student(string name, string surname, int group, int point, bool isgraduated) 
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = isgraduated;
        }


        public void FullName()
        {
            Console.WriteLine(Name + " " + Surname);
        }


        public void AllValues()
        {
            string mezun = "";

            if(IsGraduated)
            {
                mezun = "Mezun olub";
            }
            else
            {
                mezun = "Mezun olmayib";
            }
            Console.WriteLine(Name + " " + Surname + " " + Group + " " + Point + " " + IsGraduated + " " + mezun);
        }


        public void NextExam()
        {
            if (Point > 80)
            {
                Console.WriteLine("Novbeti imtahana gire biler");
            }
            else
            {
                Console.WriteLine("Novbeti imtahana gire bilmez");
            }
        }

    }
}
