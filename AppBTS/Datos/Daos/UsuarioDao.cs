using AppBTS.Datos.Interfaces;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBTS.Datos.Daos
{
    class UsuarioDao : IUsuario
    {
        public int ValidarUsuario(string nombre, string clave)
        {
            string consulta = "SELECT * FROM Usuarios WHERE usuario='" + nombre + "' AND password='" + clave + "'";

            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM Usuarios WHERE borrado = 0 order by usuario";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable RecuperarPorId(int idUsuario)
        {
            string consulta = "SELECT * FROM Usuarios WHERE borrado = 0 AND id_usuario = " + idUsuario;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public int Crear(Usuario oUsuario)
        {
            string consulta = "INSERT INTO Usuarios (usuario, password, email, id_perfil, estado, borrado) " +
                             "VALUES ('" +
                             oUsuario.Nombre + "','" +
                             oUsuario.Password + "','" +
                             oUsuario.Email + "'," +
                             oUsuario.Id_perfil.IdPerfil + ",'" +
                             oUsuario.Estado + "','" +
                             oUsuario.Borrado + "')";
            return BDHelper.obtenerInstancia().actualizar(consulta);
        }

        public int Actualizar(Usuario oUsuario)
        {
            string consulta = "UPDATE Usuarios SET usuario='" + oUsuario.Nombre + "'," +
                              "password='" + oUsuario.Password + "'," +
                              "email='" + oUsuario.Email + "'," +
                              "id_perfil=" + oUsuario.Id_perfil.IdPerfil + " " +
                              "WHERE id_usuario=" + oUsuario.Id_usuario;
            return BDHelper.obtenerInstancia().actualizar(consulta);
        }

        public int Eliminar(int idUsuario)
        {
            string consulta = "DELETE FROM Usuarios WHERE id_usuario=" + idUsuario;
            return BDHelper.obtenerInstancia().actualizar(consulta);
        }
    }
}
