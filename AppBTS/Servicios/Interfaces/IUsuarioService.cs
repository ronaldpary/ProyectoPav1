using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios.Interfaces
{
    internal interface IUsuarioService
    {
        int encontrarUsuario(string nombre, string clave);
        DataTable traerTodos();
        DataTable traerPorId(int idUsuario);
        int insertarUsuario(Usuario oUsuario);
        int actualizarUsuario(Usuario oUsuario);
        int eliminarUsuario(int idUsuario);
    }
}
