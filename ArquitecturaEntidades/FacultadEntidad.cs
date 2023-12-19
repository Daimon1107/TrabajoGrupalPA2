using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaEntidades
{
    public class FacultadEntidad
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        

        public FacultadEntidad(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public FacultadEntidad()
        {

        }
    }
}
