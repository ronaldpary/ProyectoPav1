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
    internal class ClienteDao : IClienteDao
    {
        public Cliente RecuperarPorId(int id)
        {
            string consultaSQL = "SELECT * FROM t_clientes WHERE id_clientes=" + id;
            DataTable tabla = new DataTable();
            tabla = BDHelper.getBDHelper().ConsultaSQL(consultaSQL);
            if (tabla.Rows.Count > 0)
            {
                Cliente c = new Cliente();
                c.IdCliente = id;                    //Convert.ToInt32(tabla.Rows[0][0])
                c.Nombre = tabla.Rows[0][1].ToString();     //tabla.Rows[0]["n_clientes"].ToString()
                c.Calle = tabla.Rows[0][2].ToString();      //tabla.Rows[0]["calle"].ToString()
                c.Numero = Convert.ToInt32(tabla.Rows[0][3]);//Convert.ToInt32(tabla.Rows[0]["calle_nro"])
                return c;
            }
            else
                return null;
        }
    }
}
