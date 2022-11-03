using AppBTS.Entidades;
using System.Collections.Generic;


namespace AppBTS.Datos.Interfaces
{
    interface IPerfil
    {
        List<Perfil> RecuperarTodos();
    }
}