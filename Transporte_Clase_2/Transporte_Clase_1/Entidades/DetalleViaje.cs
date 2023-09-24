using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_Clase_1.Entidades
{
    public class DetalleViaje
    {
        public Camion NuevoCamion { get; set; }

        public int Cantidad { get; set; }

        public DetalleViaje(Camion camion, int cantidad)
        {
            NuevoCamion = camion;
            Cantidad = cantidad;
        }

        public double CalcularSubtotal()
        {
            double subtotal = NuevoCamion.Carga.Peso*Cantidad;

            return subtotal;
        }


    }
}
