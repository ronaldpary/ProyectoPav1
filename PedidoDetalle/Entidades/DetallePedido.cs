using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoDetalle.Entidades
{
    internal class DetallePedido
    {
        public int NroPedido { get; set; }
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double CalcularSubTotal()
        {
            return Math.Round(Precio * Cantidad, 2);
        }
    }
}
