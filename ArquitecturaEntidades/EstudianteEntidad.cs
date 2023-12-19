using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaEntidades
{
	public class EstudianteEntidad
	{
        public EstudianteEntidad()
        {
        }

        public EstudianteEntidad(int id, string cedula, string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, int idCarrera, string tema, int idDocente, int idGenero)
        {
            Id = id;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            EstadoCivil = estadoCivil;
            IdCarrera = idCarrera;
            Tema = tema;
            IdDocente = idDocente;
            IdGenero = idGenero;
        }

        public int Id { get; set; }
        public string Cedula{ get; set; }
        public string Nombre { get; set; }
        public string Apellido{ get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char EstadoCivil { get; set; }
        public int  IdCarrera{ get; set; }
        public string Tema { get; set; }
        public int IdDocente { get; set; }
        public int IdGenero { get; set; }

    }

}
