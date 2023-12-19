using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaEntidades
{
	public class DocenteEntidad
	{

        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public int Id { get; set; }
        public string Cedula{ get; set; }
        public string Nombre{ get; set; }
        public string Apellido{ get; set; }
        public DateTime FechaNacimiento{ get; set; }
        public int IdFacultad{ get; set; }

        public DocenteEntidad()
        {
                
        }

		public DocenteEntidad(int id, string usuario)
		{
			Id = id;
			Usuario = usuario;
		}

        public DocenteEntidad(int id, string cedula, string nombre, string apellido, DateTime fechaNacimiento, int idFacultad)
        {
            Id = id;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            IdFacultad = idFacultad;
        }
    }
}
