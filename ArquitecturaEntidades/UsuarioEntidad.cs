using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaEntidades {
    public class UsuarioEntidad {
        public int Id { get; set; }
        public string Cédula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public bool Rol { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public UsuarioEntidad()
        {
                
        }

        public UsuarioEntidad(int id, string cédula, string nombre, string apellido, DateTime fecha_Nacimiento, bool rol, string usuario, string contraseña) {
            Id = id;
            Cédula = cédula;
            Nombre = nombre;
            Apellido = apellido;
            Fecha_Nacimiento = fecha_Nacimiento;
            Rol = rol;
            Usuario = usuario;
            Contraseña = contraseña;
        }
    }
}
