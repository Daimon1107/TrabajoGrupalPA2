using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDatos
{
    public static class Maestro_TesisDatos
    {
        public static Maestro_TesisEntidad DevolverMaestroId(int id_tesis)
        {
			try
			{
				using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
				{
					Maestro_Tesis tesisEF = contexto.Maestro_Tesis.FirstOrDefault(t => t.id == id_tesis);
					Maestro_TesisEntidad tesisE = null;
					if (tesisEF != null)
					{
						tesisE = new Maestro_TesisEntidad(tesisEF.id, CuentaDocenteDatos.DevolverDocenteID((int)tesisEF.id_docente),
							EstudianteDatos.DevolverEstudianteId((int) tesisEF.id_estudiante), (int)tesisEF.mesAP, (int)tesisEF.añoAP, tesisEF.tema);
					}

					return tesisE;
				}

			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
