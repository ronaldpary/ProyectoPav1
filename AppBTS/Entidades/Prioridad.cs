﻿using AppBTS.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Negocio
{
    class Prioridad
    {
        public int IdPrioridad { get; set; }
        public string Nombre { get; set; }
        public bool Borrado { get; set; }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM Prioridades WHERE borrado = 0 order by 2";

            //BDHelper oDatos = new BDHelper();
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
