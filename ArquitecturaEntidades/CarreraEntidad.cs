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
        public int Id_Facultad{ get; set; }

        public CarreraEntidad(int id, string nombre, int id_Facultad)
        {
            Id = id;
            Nombre = nombre;
            Id_Facultad = id_Facultad;
        }

        public CarreraEntidad()
        {
        }
    }
}
