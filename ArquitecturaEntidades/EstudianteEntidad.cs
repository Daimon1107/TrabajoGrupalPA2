using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaEntidades
{
	public class EstudianteEntidad
	{
        public int Id { get; set; }
        public string Cédula { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public CarreraEntidad Carrera { get; set; }
        public GéneroEntidad Género { get; set; }
        public byte[] Foto { get; set; }
        public EstudianteEntidad() {
        }

        public EstudianteEntidad(int id, string cédula, string apellido, string nombre, DateTime fechaNacimiento, CarreraEntidad carrera, GéneroEntidad género, byte[] foto)
        {
            Id = id;
            Cédula = cédula;
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Carrera = carrera;
            Género = género;
            Foto = foto;
        }
    }

}
