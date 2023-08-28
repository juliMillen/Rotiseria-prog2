using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso4
{
    class Delivery:Pedido
    {
        private double distancia;
        public Delivery(int numero, string nombre, double distancia):base(numero,nombre)
        {
            this.distancia = distancia;
        }

        public override double Precio()
        {
            double precioDelivery;
            return precioDelivery = precio + 150 + (precio * distancia * 0.08);

        }
    }
}
