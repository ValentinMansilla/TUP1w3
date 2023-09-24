using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Transporte_Clase_1.Entidades
{
    public class Camion
    {
        public int Id { get; set; }
        public string Patente { get; set; }
        public bool Estado { get; set; }
        public double PesoMaximo { get; set; }

        public Carga Carga { get; set; }

        public Camion()
        {
            Id = 0;
            Patente = string.Empty;
            Estado = false;
            PesoMaximo = 0;
            Carga = null;
        }

        public Camion(int id, string patente, bool estado, double peso, Carga carga)
        {
            Id = id;
            Patente = patente;
            Estado = estado;
            PesoMaximo = peso;
            Carga = carga;
        }

        public override string ToString()
        {
            return "el camión " + Id +", Patente: " + Patente + " se encuentra " + Estado.ToString() + " y tiene un " +
                "peso máximo de: " + PesoMaximo;
        }
    }
}
