using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_4s_l6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Abiturient x = new Abiturient("FEM", "Korcha", 2019);
            x.personaGetAge();
            x.personaShow();

            Student y = new Student("ElIT", "Markova", 2019, 3);
            y.personaGetAge();
            y.personaShow();

            Vykladach z = new Vykladach("TeCeT", "Bobrenko", 2019, "K.T.N", 25);
            z.personaGetAge();
            z.personaShow();
        }
    }
}
