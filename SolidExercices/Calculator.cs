using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;

namespace SolidExercices
{
    public class Calculator
    {
        public double Calculate(string operation)
        {

            double resultat = 0;
            double tmpNb;
            string strNb = "";
            char lastOp = ' ';

            operation = operation.Replace(" ", "");
            operation += ";";

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
        
                        switch (lastOp)
                        {
                            case '+':
                                resultat += tmpNb;
                                break;
                            case '-':
                                resultat -= tmpNb;
                                break;
                            case '*':
                                resultat *= tmpNb;
                                break;
                            case '/':
                                resultat /= tmpNb;
                                break;
                            case ' ':
                                resultat = tmpNb;
                                break;
                    }
                lastOp = car;
                }
            }

            return resultat;
        }
    }
}