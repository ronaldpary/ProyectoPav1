﻿using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    internal interface IBug
    {
        bool InsertarBugConHistorial(Bug oBug, HistorialBug oHistorialBug);
    }
}
