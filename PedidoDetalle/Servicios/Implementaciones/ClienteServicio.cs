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
    internal class ClienteServicio : IClienteServicio
    {
        IClienteDao oDao;
        public ClienteServicio()
        {
            oDao = new ClienteDao();
        }

        public Cliente TraerPorId(int id)
        {
            return oDao.RecuperarPorId(id);
        }
    }
}
