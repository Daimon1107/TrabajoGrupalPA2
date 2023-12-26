using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaEntidades
{
    public class ActividadEntidad
    {
        public int Id { get; set; }
        public string NombreActividad { get; set; }
        public DateTime FechaActividad { get; set; }
        public Maestro_TesisEntidad Tesis { get; set; }

        public ActividadEntidad()
        {
            
        }

        public ActividadEntidad(int id, string nombreActividad, DateTime fechaActividad, Maestro_TesisEntidad tesis)
        {
            Id = id;
            NombreActividad = nombreActividad;
            FechaActividad = fechaActividad;
            Tesis = tesis;
        }
    }
}
