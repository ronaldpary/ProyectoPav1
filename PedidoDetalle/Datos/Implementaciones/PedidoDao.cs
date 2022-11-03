using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedidoDetalle.Datos.Interfaces;
using PedidoDetalle.Entidades;

namespace PedidoDetalle.Datos.Implementaciones
{
    internal class PedidoDao : IPedidoDao 
    {
        public int Next()
        {
            string consultaSQL = "SELECT MAX(nro_pedido) FROM t_pedidos";
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(consultaSQL);
            if (tabla.Rows[0][0] == DBNull.Value)
                return 1;
            else
                return (int)tabla.Rows[0][0] + 1;

        }

        public bool SavePedido(Pedido oPedido)
        {
            string consultaMaestro = "insert into t_pedidos (id_cliente, fecha, sub_total, descuento, total) values("
                + oPedido.Cliente.IdCliente + ",'"
                + oPedido.Fecha.ToString("yyyy-MM-dd") + "',"
                + oPedido.SubTotal.ToString().Replace(",", ".") + "," //para reemplazar las comas , por puntos . decimales
                + oPedido.Descuento.ToString().Replace(",", ".") + ","
                + oPedido.Total.ToString().Replace(",", ".") + ")";
            BDHelper.getBDHelper().conectarConTransaccion();
            BDHelper.getBDHelper().EjecutarSQLConTransaccion(consultaMaestro);

            var nuevoId = BDHelper.getBDHelper().ConsultaSQLScalar("Select @@IDENTITY");
            oPedido.NroPedido = Convert.ToInt32(nuevoId);

            string consultaSQLDetalle;
            foreach (DetallePedido dp in oPedido.lstDetalle)
            {
                consultaSQLDetalle = "INSERT INTO t_detalle_pedido (nro_pedido,id_articulo,cantidad,precio) values("
                                                          + oPedido.NroPedido + ","
                                                          + dp.Articulo.IdArticulo + ","
                                                          + dp.Cantidad + ","
                                                          + dp.Precio.ToString().Replace(",", ".") + ")";
                BDHelper.getBDHelper().EjecutarSQLConTransaccion(consultaSQLDetalle);
            }

            return BDHelper.getBDHelper().desconectar();

        }
    }
}
