using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prog_4s_l6_1
{
    public class Abiturient : Persona
    {
        private int bdate;
        private string faculty;
        private string surname;

        public Abiturient(string faculty, string surname, int curYr)
        {

            this.faculty = faculty;
            this.surname = surname;
            this.curYr = curYr;
            //personaShow();
        }

        public override void personaShow()
        {
            Console.WriteLine("\n\nInfo about abiturient:");
            Console.WriteLine("Surname = " + surname + "\nfaculty= " + faculty + "\nbdate = " + bdate);
        }

        public override void personaGetAge()
        {
            Console.WriteLine("\ntype abiturient year of birthday");
            bdate = int.Parse(Console.ReadLine());
            Console.WriteLine("This abiturient is {0} years old", curYr - bdate);

        }
    }
}