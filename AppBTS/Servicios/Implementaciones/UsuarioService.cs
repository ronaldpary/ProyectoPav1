using AppBTS.Datos.Daos;
using AppBTS.Datos.Interfaces;
using AppBTS.Negocio;
using AppBTS.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Servicios
{
    class UsuarioService :IUsuarioService
    {
        private IUsuario dao;

        public UsuarioService()
        {
            dao = new UsuarioDao();
        }
        public int encontrarUsuario(string nombre, string clave)
        {
            return dao.ValidarUsuario(nombre, clave);
        }
        public DataTable traerTodos()
        {
            return dao.RecuperarTodos();
        }
        public DataTable traerPorId(int idUsuario)
        {
            return dao.RecuperarPorId(idUsuario);
        }

        public int insertarUsuario(Usuario oUsuario)
        {
            return dao.Crear(oUsuario);
        }

        public int actualizarUsuario(Usuario oUsuario)
        {
            return dao.Actualizar(oUsuario);
        }

        public int eliminarUsuario(int idUsuario)
        {
            return dao.Eliminar(idUsuario);
        }
    }
}
