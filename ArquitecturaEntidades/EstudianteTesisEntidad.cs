using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaEntidades
{
	public class EstudianteTesisEntidad
	{
        public int Id { get; set; }
        public string Cedula{ get; set; }
        public string Nombre { get; set; }
        public string Apellido{ get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char EstadoCivil { get; set; }
        public int  IdCarrera{ get; set; }
        public string Carrera { get; set; }
        public string Tema { get; set; }
        public int IdDocente { get; set; }
        public string Docente { get; set; }
        public int IdGenero { get; set; }
        public string Género { get; set; }
        public int MesAP { get; set; }
        public int AñoAP { get; set; }

        public EstudianteTesisEntidad() {
        }

        public EstudianteTesisEntidad(int id, string cedula, string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, int idCarrera, string carrera, string tema, int idDocente, string docente, int idGenero, string género, int mesAP, int añoAP) {
            Id = id;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            EstadoCivil = estadoCivil;
            IdCarrera = idCarrera;
            Carrera = carrera;
            Tema = tema;
            IdDocente = idDocente;
            Docente = docente;
            IdGenero = idGenero;
            Género = género;
            MesAP = mesAP;
            AñoAP = añoAP;
        }
    }

}
