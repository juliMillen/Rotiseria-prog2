using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace repaso4
{
    class Rotiseria
    {
        private ArrayList listaPedidos = new ArrayList();
        public double TotalRecaudado
        {
            get { return TotalRecaudado; }
            set
            {
                TotalRecaudado += TotalPedidos;
            }
        }
        public int TotalPedidos
        {
            get { return listaPedidos.Count; }
        }

        public void AgregarPedido(Pedido p)
        {
            listaPedidos.Add(p);
        }

        public void EliminarPedido(Pedido p)
        {
            listaPedidos.Remove(p);
        }

        public Pedido VerPedido(int numero)
        {
            return (Pedido)listaPedidos[numero];
        }
    }
}
