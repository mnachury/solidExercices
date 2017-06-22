using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    class operation
    {
        private double sum()
        {
            return resultat + tmpNb;
        }

        private double sub()
        {
            return resultat - tmpNb;
        }

        private double mul()
        {
            return resultat * tmpNb;
        }

        private double div()
        {
            if (tmpNb == 0)
            {
                throw new DivideByZeroException("Impossible de diviser par zero : (" + resultat.ToString() + "/0)");
            }
            return resultat / tmpNb;
        }
    }
}
