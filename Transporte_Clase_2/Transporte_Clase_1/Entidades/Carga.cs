using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_Clase_1.Entidades
{
    public class Carga
    {
        public double Peso { get; set; }

        public TipoCarga Tipo { get; set; }

        public Carga()
        {
            Peso = 0;
            Tipo = new TipoCarga();
        }

        public Carga(double peso, TipoCarga tipo)
        {
            Peso = peso;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return Tipo.ToString();
        }
    }
}
