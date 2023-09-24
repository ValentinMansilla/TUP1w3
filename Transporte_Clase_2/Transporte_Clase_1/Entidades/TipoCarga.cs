using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_Clase_1.Entidades
{
    public class TipoCarga
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public TipoCarga()
        {
            Codigo = 0;
            Nombre = string.Empty;

        }
        public TipoCarga(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
