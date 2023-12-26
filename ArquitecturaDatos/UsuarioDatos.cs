using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDatos
{
    public static class UsuarioDatos
    {
        public static UsuarioEntidad DevolverUsuarioId(int id_usuario)
        {
			try
			{
				using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
				{
					Usuarios usuarioEF = contexto.Usuarios.FirstOrDefault(u => u.id == id_usuario);
					UsuarioEntidad usuarioE = null;

                    if (usuarioEF != null)
					{
						usuarioE = new UsuarioEntidad(usuarioEF.id, usuarioEF.cedula, usuarioEF.nombre, usuarioEF.apellido, (DateTime)usuarioEF.fecha_nacimiento,
							(bool)usuarioEF.rol, usuarioEF.usuario, usuarioEF.contraseña);

					}
                    return usuarioE;

                }

            }
			catch (Exception)
			{

				throw;
			}
        }

		public static bool ComprobarSesiónVálida(string usuario, string contraseña)
		{
			try
			{
				using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
				{
					Usuarios usuarioEF = contexto.Usuarios.FirstOrDefault(u => u.usuario.Equals(usuario) && u.contraseña.Equals(contraseña));
					if (usuarioEF != null)
					{
						return true;
					}
					return false;
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
    }
}
