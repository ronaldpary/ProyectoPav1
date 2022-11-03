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
    internal class ArticuloService : IArticuloServicio
    {
        IArticulo oDao;
        public ArticuloService()
        {
            oDao = new ArticuloDao();
        }
        public List<Articulo> ObtenerArticulos()
        {
            return oDao.RecuperarTodos();
        }
    }
}
