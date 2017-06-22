using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;

namespace SolidExercices
{
    public class Calculator
    {
        public double resultat = 0;
        private double tmpNb;

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
        public double Calculate(string operation)
        {
            IDictionary<char, Func<double>> methods = new Dictionary<char, Func<double>>();
            methods['+'] = sum;
            methods['-'] = sub;
            methods['x'] = mul;
            methods['/'] = div;

            string strNb = "";
            char lastOp = ' ';
            if (operation.StartsWith("-"))
            {
                operation = "0" + operation.Replace(" ", "") + ";"; 
            }
            else
            {
                operation = "0+" + operation.Replace(" ", "") + ";";
            }


            foreach (char car in operation)
            {
                if (double.TryParse(car.ToString(), out tmpNb))
                {
                    strNb += car.ToString();
                }
                else if (car == '.' || car == ',')
                {
                    strNb += ',';
                }
                else
                {
                    tmpNb = double.Parse(strNb);
                    strNb = "";
                    if (methods.ContainsKey(lastOp))
                    {
                        resultat = methods[lastOp].Invoke();
                    }
                    else
                    {
                        if (lastOp != ' ')
                        {
                            throw new stringMalFormerException("Erreur sur la string operation au niveau du caractères: '" + lastOp + "'");
                        }
                    }
                    lastOp = car;
                }
            }

            return resultat;
        }

        public class stringMalFormerException : System.Exception
        {
            public stringMalFormerException(string message) : base(message) { }
        }
    }
}