using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class UsuarioBussiness
    {
        public static List<Usuario> GetUsuarios()
        {
            return UsuarioData.ObtenerUsuario();
        }

        public static void CrearUsuario(Usuario Newusuario)
        {
            UsuarioData.CrearUsuario(Newusuario);
        }
        public static void EliminarUsuario(int id)
        {
            UsuarioData.BorrarUsuario(id);
        }
        public static void ModificarUsuario (Usuario usuario)
        {
            UsuarioData.ActualizarUsuario(usuario);
        }

        public static Usuario GetUsuariosById(int id)
        {
            return UsuarioData.ObtenerUsuarioPorId(id);
        }
    }
}
