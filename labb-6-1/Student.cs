using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prog_4s_l6_1
{
    public class Student : Persona
    {
        private string surname;
        private int bdate;
        private string faculty;
        private int course;

        public Student(string faculty, string surname, int curYr, int course)
        {

            this.faculty = faculty;
            this.surname = surname;
            this.curYr = curYr;
            this.course = course;
            //personaShow();
        }

        public void personaShow()
        {
            Console.WriteLine("\n\nInfo about student:");
            Console.WriteLine("Surname = " + surname + "\nbdate = " + bdate + "\nfaculty= " + faculty + "\ncourse = " + course);
        }

        public override void personaGetAge()
        {
            Console.WriteLine("\ntype student year of birthday ");
            bdate = int.Parse(Console.ReadLine());
            Console.WriteLine("This student is {0} years old", curYr - bdate);

        }
    }
}