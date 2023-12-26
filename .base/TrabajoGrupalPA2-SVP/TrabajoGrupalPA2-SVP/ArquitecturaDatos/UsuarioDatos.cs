using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDatos {
    public static class UsuarioDatos {

        public static UsuarioEntidad CrearUsuarioEntidad(Usuarios usuarioEF) {
            UsuarioEntidad usuarioE = new UsuarioEntidad();
            usuarioE.Id = usuarioEF.id;
            usuarioE.Cédula = usuarioEF.cedula;
            usuarioE.Nombre = usuarioEF.nombre;
            usuarioE.Apellido = usuarioEF.apellido;
            usuarioE.Fecha_Nacimiento = (DateTime) usuarioEF.fecha_nacimiento;
            usuarioE.Rol = (bool) usuarioEF.rol;
            usuarioE.Usuario = usuarioEF.usuario;
            usuarioE.Contraseña = usuarioEF.contraseña;
            return usuarioE;
        }

        public static Usuarios CrearUsuarioEF(UsuarioEntidad usuarioE) {
            Usuarios usuarioEF = new Usuarios();
            usuarioEF.id = usuarioE.Id;
            usuarioEF.cedula = usuarioE.Cédula;
            usuarioEF.nombre = usuarioE.Nombre;
            usuarioEF.apellido = usuarioE.Apellido;
            usuarioEF.fecha_nacimiento = usuarioE.Fecha_Nacimiento;
            usuarioEF.rol = (bool) usuarioE.Rol;
            usuarioEF.usuario = usuarioE.Usuario;
            usuarioEF.contraseña = usuarioE.Contraseña;
            return usuarioEF;
        }


        public static UsuarioEntidad DevolverUsuarioID(int id) {
            try {
                UsuarioEntidad usuarioE = new UsuarioEntidad();
                using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities()) {
                    var usuarioEF = contexto.Usuarios.FirstOrDefault(c => c.id == id);
                    usuarioE = CrearUsuarioEntidad(usuarioEF);
                }

                return usuarioE;
            } catch (Exception) {

                throw;
            }
        }

        public static UsuarioEntidad DevolverUsuarioContraseña(UsuarioEntidad usuarioE) {
            try {
                using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities()) {
                    var usuarioEF = contexto.Usuarios.FirstOrDefault(u => u.usuario == usuarioE.Usuario && u.contraseña == usuarioE.Contraseña);
                    if (usuarioEF == null)
                        return null;
                    usuarioE = CrearUsuarioEntidad(usuarioEF);
                }

                return usuarioE;
            } catch (Exception) {

                throw;
            }
        }


        public static bool EliminarCarrera(int id) {
            try {
                using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities()) {
                    Carreras carreraEF = contexto.Carreras.FirstOrDefault(c => c.id == id);
                    contexto.Carreras.Remove(carreraEF);
                    contexto.SaveChanges();
                    return true;
                }
            } catch (Exception) {
                return false;
                throw;
            }
        }

    }

}
