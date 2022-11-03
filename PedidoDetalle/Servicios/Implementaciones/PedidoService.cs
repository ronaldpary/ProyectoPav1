using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedidoDetalle.Datos.Implementaciones;
using PedidoDetalle.Datos.Interfaces;
using PedidoDetalle.Entidades;
using PedidoDetalle.Servicios.Interfaces;

namespace PedidoDetalle.Servicios.Implementaciones
{
    internal class PedidoService : IPedidoServicio
    {
        IPedidoDao oDao;
        public PedidoService()
        {
            oDao = new PedidoDao();
        }

        public bool GrabarPedido(Pedido oPedido)
        {
            return oDao.SavePedido(oPedido);
        }

        public int ProximoNumero()
        {
            return oDao.Next();
        }
    }
}
