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
    internal class ArticuloDao : IArticulo
    {
        public List<Articulo> RecuperarTodos()
        {
            List<Articulo> lst = new List<Articulo>();
            string consulta = "select * from t_articulos";
            DataTable tabla = BDHelper.getBDHelper().ConsultaSQL(consulta);
            foreach (DataRow fila in tabla.Rows)
            {
                Articulo a = new Articulo();
                a.IdArticulo = Convert.ToInt32(fila[0]);
                a.Nombre = fila[1].ToString();
                a.Precio = Convert.ToDouble(fila[2]);
                lst.Add(a);
            }
            return lst;
        }
    }
}
