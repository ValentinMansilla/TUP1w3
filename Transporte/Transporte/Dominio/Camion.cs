using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte.Dominio
{
    public class Camion
    {
        public string Patente { get; set; }
        public int Estado { get; set; }
        public double PesoMaximo { get; set; }

        public Carga Carga { get; set; }

        public Camion()
        {
            Patente = string.Empty;
            Estado = 0;
            PesoMaximo = 0;
        }

        public Camion(string patente, int estado, Carga carga)
        {
            Patente=patente;
            Estado = estado;
            Carga = carga;
        }

        public override string ToString()
        {
            return "el camión " + Patente + " se encuentra " + Estado + " y tiene un " +
                "peso máximo de: " +PesoMaximo;
        }
    }
}
