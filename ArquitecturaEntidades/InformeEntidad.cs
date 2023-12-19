using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaEntidades
{
	public class InformeEntidad
	{
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Mes { get; set; }
        public int  Año { get; set; }
        public int Id_Estudiante { get; set; }

        public InformeEntidad()
        {
            
        }

		public InformeEntidad(int id, DateTime fecha, int mes, int año, int id_Estudiante)
		{
			Id = id;
			Fecha = fecha;
			Mes = mes;
			Año = año;
			Id_Estudiante = id_Estudiante;
		}
	}
}
