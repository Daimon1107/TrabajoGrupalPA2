using ArquitecturaDatos;
using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLogicaNegocio {
    public static class UsuarioNegocio {
        public static UsuarioEntidad DevolverUsuarioContraseña(UsuarioEntidad usuarioE) {
            return UsuarioDatos.DevolverUsuarioContraseña(usuarioE);
        }
    }
}
