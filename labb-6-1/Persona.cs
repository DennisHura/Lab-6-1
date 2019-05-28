using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prog_4s_l6_1
{
    public abstract class Persona
    {
        protected int curYr;

        public virtual void personaShow()
        {
            throw new System.NotImplementedException();
        }

        public virtual void personaGetAge()
        {
            throw new System.NotImplementedException();
        }
    }
}