using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prog_4s_l6_1
{
    public class Vykladach : Persona
    {
        private int bdate;

        private string faculty;
        private string posada;
        private string surname;
        private int stag;

        public Vykladach(string faculty, string surname, int curYr, string posada, int stag)
        {

            this.faculty = faculty;
            this.surname = surname;
            this.curYr = curYr;
            this.posada = posada;
            this.stag = stag;
            //personaShow();
        }

        public void personaShow()
        {
            Console.WriteLine("\n\nInfo about vykladach:");
            Console.WriteLine("Surname = " + surname + "\nbdate = " + bdate + "\nfaculty= " + faculty + "\nposada = " + posada + "\nstag = " + stag);
        }

        public override void personaGetAge()
        {
            Console.WriteLine("\ntype vykladach year of birthday ");
            bdate = int.Parse(Console.ReadLine());
            Console.WriteLine("This student is {0} years old", curYr - bdate);

        }
    }
}