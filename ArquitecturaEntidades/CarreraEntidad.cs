using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaEntidades
{
	public class CarreraEntidad
	{
        public int Id { get; set; }
        public string Nombre { get; set; }
        public FacultadEntidad Facultad { get; set; }

        public CarreraEntidad()
        {
        }

        public CarreraEntidad(int id, string nombre, FacultadEntidad facultad)
        {
            Id = id;
            Nombre = nombre;
            Facultad = facultad;
        }
    }
}
