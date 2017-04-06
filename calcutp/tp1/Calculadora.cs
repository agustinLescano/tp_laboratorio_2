using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    class Calculadora
    {
        public static double operar(Numero n1, Numero n2, string operador)
        {
            double retorno=0;
            string simbolo = Calculadora.validarOperador(operador);
                switch (simbolo)
                {
                    case "+":
                    
                            retorno= n1.getNumero() + n2.getNumero();
                            break;
                    case "-":

                            retorno = n1.getNumero() -n2.getNumero();
                            break;
                    case "*":

                            retorno = n1.getNumero() * n2.getNumero();
                            break;
                    case "/":
                            if (n2.getNumero() == 0)
                            {
                                return retorno;
                            }
                            else
                            {
                                retorno = n1.getNumero() / n2.getNumero();
                                break;
                            }                                               
                }

                return retorno;            
            }
        public static string validarOperador(string operador)
        {
            string retorno ="+";

                if (operador != "+" && operador != "-" && operador != "/" && operador != "*")
                    {
                        return retorno;
                    }
                else
                    {
                        return operador;
                    }
        }
    }
}
