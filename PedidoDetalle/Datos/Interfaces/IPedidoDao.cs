using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedidoDetalle.Entidades;

namespace PedidoDetalle.Datos.Interfaces
{
    internal interface IPedidoDao
    {
        int Next();
        bool SavePedido(Pedido oPedido);
    }
}
