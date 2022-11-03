using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    internal interface IBugService
    {
        bool CrearBugConHistorial(Bug oBug, HistorialBug oHistorialBug);
    }
}
