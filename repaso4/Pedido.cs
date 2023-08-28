using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace repaso4
{
    class Pedido
    {
        private ArrayList menu = new ArrayList();
        private string cliente;
        public int Nro { get; private set; }

        protected double precio = 0;

        public string Cliente
        {
            get { return cliente; }
        }

        public Pedido(int numero, string cliente)
        {
            this.cliente = cliente;
            this.Nro = numero;
        }

        public void AgregarItemMenu(ItemMenu itemMenu, int cantidad)
        {
            if (cantidad > 0)
            {
                menu.Add(itemMenu);
            }
        }
        public virtual double Precio()
        {
            if(menu.Count != 0)
            {
               precio = 1200 + 850;
            }
            else if(precio > 2000)
            {
                precio *= 0.05;
            }
            return precio;
        }

    }
}
