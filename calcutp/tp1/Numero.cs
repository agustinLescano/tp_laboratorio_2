using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    class Numero
    {
        private double numero;

        public double getNumero()
            {
                return this.numero;
            }

        public Numero()
            {
                this.numero = 0;
            }
        public Numero(double numero)
            {
                this.numero = numero;
            }
        public Numero(string numero)
            {
                setNumero(numero);
            }

        private double validarNumero(string numero)
        {
            double _numero;
            bool correcto;
            correcto = double.TryParse(numero, out _numero);
                if (correcto == true)
                {
                    return _numero;
                }
                else
                {
                    _numero = 0;
                   return _numero;
                }
        }
        public void setNumero(string numero)
            {
                this.numero = validarNumero(numero);
            }


    }
}
    