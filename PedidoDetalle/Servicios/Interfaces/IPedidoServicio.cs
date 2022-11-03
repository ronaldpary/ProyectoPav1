using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedidoDetalle.Entidades;

namespace PedidoDetalle.Servicios.Interfaces
{
    internal interface IPedidoServicio
    {
        int ProximoNumero();
        bool GrabarPedido(Pedido oPedido);
    }
}
