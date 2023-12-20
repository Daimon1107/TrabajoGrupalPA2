using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaEntidades
{
	public class CuentaDocenteEntidad
	{
        public int Id { get; set; }
        public int Id_Facultad { get; set; }
        public string Facultad { get; set; }
        public int Id_Datos { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Rol { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public CuentaDocenteEntidad()
        {
                
        }

        public CuentaDocenteEntidad(int id, int id_Facultad, string facultad, int id_Datos, string cedula, string nombre, string apellido, DateTime fechaNacimiento, bool rol, string usuario, string contraseña) {
            Id = id;
            Id_Facultad = id_Facultad;
            Facultad = facultad;
            Id_Datos = id_Datos;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Rol = rol;
            Usuario = usuario;
            Contraseña = contraseña;
        }
    }
}
