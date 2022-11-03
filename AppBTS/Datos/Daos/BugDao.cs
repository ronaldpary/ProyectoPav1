using AppBTS.Datos.Interfaces;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Daos
{
    internal class BugDao : IBug
    {
        public bool InsertarBugConHistorial(Bug oBug, HistorialBug oHistorialBug)
        {
            bool aux = false;
            //Insertar Bug
            string consultaBug = "Insert into Bugs (titulo,descripcion,fecha_alta" +
                                ",id_producto,id_criticidad,id_prioridad,id_estado" +
                                ",id_usuario_responsable) "
                            + "Values ('" + oBug.Titulo + "','"
                                       + oBug.Descripcion + "','"
                                       + oBug.Fecha_alta.ToString("yyyy/MM/dd") + "',"
                                       + oBug.Id_producto + ","
                                       + oBug.Id_criticidad + ","
                                       + oBug.Id_prioridad + ","
                                       + oBug.Id_estado + ","
                                       + oBug.Id_usuario_responsable + ")";
            BDHelper.obtenerInstancia().conectarConTransaccion();
            BDHelper.obtenerInstancia().EjecutarSQLConTransaccion(consultaBug);

            //Recuperar id nuevo

            var nuevoId = BDHelper.obtenerInstancia().ConsultaSQLScalar("SELECT @@IDENTITY");
            oHistorialBug.IdBug = Convert.ToInt32(nuevoId);

            //Insertar Historial con nuevo id
            string consultaHistorial = "Insert into BugsHistorico (titulo,id_estado" +
                                       ",id_usuario_responsable,fecha_historico,id_bug) "
                                       + "Values ('"+oBug.Titulo+"',"+
                                       + oHistorialBug.IdEstado + ","
                                       + oHistorialBug.Responsable + ",'"
                                       + oHistorialBug.Fecha.ToString("yyyy/MM/dd") + "',"
                                       + oHistorialBug.IdBug + ")";
            BDHelper.obtenerInstancia().EjecutarSQLConTransaccion(consultaHistorial);
            aux = BDHelper.obtenerInstancia().desconectar();
            return aux;
        }
    }
}
