using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Interfaces
{
    interface IUsuario
    {
        int ValidarUsuario(string nombre, string clave);
        DataTable RecuperarTodos();
        DataTable RecuperarPorId(int idUsuario);
        int Crear(Usuario oUsuario);
        int Actualizar(Usuario oUsuario);
        int Eliminar(int idUsuario);
    }
}
