using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaEntidades
{
    public class Maestro_TesisEntidad
    {
        public int Id { get; set; }
        public CuentaDocenteEntidad CuentasDocente { get; set; }
        public EstudianteEntidad Estudiantes { get; set; }
        public int MesAP { get; set; }
        public int AñoAP { get; set; }
        public string Tema { get; set; }

        public Maestro_TesisEntidad()
        {
            
        }

        public Maestro_TesisEntidad(int id, CuentaDocenteEntidad cuentasDocente, EstudianteEntidad estudiantes, int mesAP, int añoAP, string tema)
        {
            Id = id;
            CuentasDocente = cuentasDocente;
            Estudiantes = estudiantes;
            MesAP = mesAP;
            AñoAP = añoAP;
            Tema = tema;
        }
    }
}
