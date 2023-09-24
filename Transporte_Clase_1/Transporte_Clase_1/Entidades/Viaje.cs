using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_Clase_1.Entidades
{
    public class Viaje
    {
        public Camion camion { get; set; }

        public List<DetalleViaje> detallesCarga { get; set; }

        public Viaje()
        {
            detallesCarga = new List<DetalleViaje>();
        }

        public void AgregarDetalle(DetalleViaje detalle)
        {
            detallesCarga.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            detallesCarga.RemoveAt(indice);
        }

        public double CalcularTotal()
        {
            double total = 0;

            foreach (DetalleViaje d in detallesCarga)
            {
                total += d.CalcularSubtotal();
            }

            return total;
        }

    }
}
