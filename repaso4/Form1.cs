using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repaso4
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        Pedido cliente;
        Delivery pedidoConDelivery;
        ItemMenu nuevoMenu;
        private void btnTomarPedido_Click(object sender, EventArgs e)
        {
            FDatos nuevoPedido = new FDatos();
            if (nuevoPedido.ShowDialog() == DialogResult.OK)
            {
                string nombre = nuevoPedido.tBnombreCliente.Text;
                cliente = new Pedido(1, nombre);

                if (nuevoPedido.checkBox1.Checked)
                {
                    string nombreC = nuevoPedido.tBnombreCliente.Text;
                    double km = Convert.ToDouble(nuevoPedido.tBdistancia.Text);
                    pedidoConDelivery = new Delivery(2, nombre, km);

                }
                nuevoPedido.tBnombreCliente.Clear();
                nuevoPedido.tBdistancia.Clear();
            }
            nuevoPedido.Dispose();
        }

        private void btnAgregarMenu_Click(object sender, EventArgs e)
        {
            string menu = (string)cbxOpciones.SelectedItem;
            int cantidad = Convert.ToInt32(textBox1.Text);
            nuevoMenu = new ItemMenu(menu);
            cliente.AgregarItemMenu(nuevoMenu, cantidad);
            lBpedidos.Items.Add("Menu seleccionado: " + nuevoMenu.Descripcion() + "\ncantidad: " + cantidad.ToString());
            textBox1.Clear();
        
        }

        private void btnCerrarPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Precio Final: " + cliente.Precio().ToString("00.0"));
            lBpedidos.Items.Clear();
            lBlistaPedidos.Items.Clear();
            lBlistaPedidos.Items.Add("Cliente Numero: " + cliente.Nro + " \tNombre: " + cliente.Cliente);
            lBlistaPedidos.Items.Add("Precio total: " + cliente.Precio().ToString("00.0"));
        }
    }
}
