using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Negocio;
using AppBTS.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Implementaciones
{
    internal class BugService : IBugService
    {
        private IBug dao;
        public BugService()
        {
            dao = new BugDao();
        }
        public bool CrearBugConHistorial(Bug oBug, HistorialBug oHistorialBug)
        {
            return dao.InsertarBugConHistorial(oBug, oHistorialBug);
        }
    }
}
