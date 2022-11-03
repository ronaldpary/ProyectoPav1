using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoDetalle.Entidades
{
    internal class Pedido
    {
        public int NroPedido { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public double SubTotal { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }
        public List<DetallePedido> lstDetalle { get; set; }
        public Pedido()
        {
            lstDetalle = new List<DetallePedido>();
        }
        public void AgregarDetalle(DetallePedido oDetallePedido)
        {
            lstDetalle.Add(oDetallePedido);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (DetallePedido dp in lstDetalle)
            {
                total += dp.CalcularSubTotal();
            }
            return Math.Round(total, 2);
        }
    }
}
