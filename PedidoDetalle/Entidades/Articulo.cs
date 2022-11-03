using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoDetalle.Entidades
{
    internal class Articulo
    {
        public int IdArticulo {get; set; }
        public string Nombre { get; set; }  
        public double Precio { get; set; }
    }
}
