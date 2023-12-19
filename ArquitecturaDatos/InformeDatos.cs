using ArquitecturaDatos;
using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDatos
{
	public static class InformeDatos
	{

		public static List<InformeEntidad> DevolverListaInformes(int id_estudiante) {
			try {
				List<InformeEntidad> listaInformes = new List<InformeEntidad>();
				List<Informes> listaInformesLINQ = new List<Informes>();
				using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
					var resultado = contexto.Informes;

					listaInformesLINQ = resultado.ToList().FindAll(i => i.id_estudiante == id_estudiante);
				}

				//foreach (var item in listaInformesLINQ) {
				//	listaInformes.Add(new InformeEntidad(item.id, (DateTime) item.fecha,
				//											(int) item.mes, (int) item.año,
				//											(int) item.id_estudiante));
				//}

				return listaInformes;


			} catch (Exception) {
				throw;
			}
		}
		//public static InformeEntidad DevolverInformeID(int id)
		//{
		//	try
		//	{
		//		InformeEntidad informe = new InformeEntidad();
		//		using (TareaGrupalEntities contexto = new TareaGrupalEntities())
		//		{
		//			Informes informeLINQ = contexto.Informes.FirstOrDefault((e) => e.id == informe.Id);

		//			informe.Id = informeLINQ.id;
		//			informe.Fecha = (DateTime)informeLINQ.fecha;
		//			informe.Mes = (int)informeLINQ.mes;
		//			informe.Año = (int)informeLINQ.año;
		//			informe.Id_Estudiante = (int) informeLINQ.id_estudiante;
		//			informe.NombreEstudiante = EstudianteDatos.DevolverEstudianteID((int) informeLINQ.id_estudiante).Nombre;


		//		}

		//		return informe;
		//	}
		//	catch (Exception)
		//	{

		//		throw;
		//	}
		//}




	}

}
