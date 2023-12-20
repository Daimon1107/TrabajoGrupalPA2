using ArquitecturaDatos;
using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDatos
{
	public static class EstudianteDatos
	{
		//public static EstudianteTesisEntidad NuevoEstudiante(EstudianteTesisEntidad estudiante)
		//{
		//	try
		//	{
		//		Estudiante estudianteEF = new Estudiante();
		//		estudianteEF.id = estudiante.Id;
		//		estudianteEF.nombre = estudiante.Nombre;
		//		estudianteEF.apellido = estudiante.Apellido;
		//		estudianteEF.cedula = estudiante.Cedula;
		//		estudianteEF.fecha_nacimiento = estudiante.FechaNacimiento;
		//		estudianteEF.estado_civil = estudiante.EstadoCivil.ToString();
		//		estudianteEF.id_carrera = estudiante.IdCarrera;
		//		estudianteEF.tema = estudiante.Tema;
		//		estudianteEF.id_docente = estudiante.IdDocente;
		//		estudianteEF.id_genero = estudiante.IdGenero;

	
		//		using (TareaGrupalEntities contexto = new TareaGrupalEntities())
		//		{
		//			contexto.Estudiante.Add(estudianteEF);
		//			contexto.SaveChanges();
		//		}

		//		estudiante.Id = estudianteEF.id;
		//		return estudiante;
		//	}


		//	catch (Exception)
		//	{

		//		throw;
		//	}
		//}

        public static EstudianteTesisEntidad NuevoEstudianteCSV(EstudianteTesisEntidad estudiante)
        {
			try {
				return null;
			} catch (Exception) {

				throw;
			}
        }

  //      public static EstudianteTesisEntidad ActualizarEstudiante(EstudianteTesisEntidad estudiante)
		//{

		//	try
		//	{

		//		Estudiante estudianteEF = new Estudiante();
  //              estudianteEF.id = estudiante.Id;
  //              estudianteEF.nombre = estudiante.Nombre;
  //              estudianteEF.apellido = estudiante.Apellido;
  //              estudianteEF.cedula = estudiante.Cedula;
  //              estudianteEF.fecha_nacimiento = estudiante.FechaNacimiento;
  //              estudianteEF.estado_civil = estudiante.EstadoCivil.ToString();
  //              estudianteEF.id_carrera = estudiante.IdCarrera;
  //              estudianteEF.tema = estudiante.Tema;
  //              estudianteEF.id_docente = estudiante.IdDocente;
  //              estudianteEF.id_genero = estudiante.IdGenero;

  //              using (TareaGrupalEntities contexto = new TareaGrupalEntities())
		//		{
		//			contexto.Estudiante.AddOrUpdate(estudianteEF);
		//			contexto.SaveChanges();
				
		//		}
		//		return estudiante;
		//	}
		//	catch (Exception)
		//	{

		//		throw;
		//	}
		
		//}
		
		public static List<EstudianteTesisEntidad> DevolverListaEstudiantes()
		{
			try
			{
				List<EstudianteTesisEntidad> listaEstudiantes = new List<EstudianteTesisEntidad>();
				
				using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {

					var ms = contexto.EstudiantesTesis.ToList();

					foreach (var item in ms)
					{
						listaEstudiantes.Add(new EstudianteTesisEntidad(item.id, item.cedula, 
							item.nombre, item.apellido, (DateTime)item.fecha_nacimiento, 
							char.Parse(item.estado_civil), (int)item.id_carrera, item.Carreras.nombre, 
							item.tema, (int)item.id_docente,item.CuentasDocente.Usuarios.nombre, (int)item.id_genero,
							item.Géneros.nombre, (int) item.mesAP, (int) item.añoAP));
					
					}	
				}
                return listaEstudiantes;

            }
			catch (Exception)
			{
				throw;
			}
		}

		//public static EstudianteTesisEntidad DevolverEstudianteId(int id)
		//{
		//	try
		//	{

		//		EstudianteTesisEntidad estudianteEntidad = new EstudianteTesisEntidad();

		//		using (TareaGrupalEntities contexto = new TareaGrupalEntities())
		//		{
		//                  var estudianteEF = contexto.EstudiantesTesis.Include("Genero").
		//                                              Include("Docente").
		//                                              Include("Informes").
		//                                              Include("Carreras").FirstOrDefault(p => p.id == id);

		//                  estudianteEntidad.Id = estudianteEF.id;
		//                  estudianteEntidad.Nombre = estudianteEF.nombre;
		//                  estudianteEntidad.Apellido = estudianteEF.apellido;
		//                  estudianteEntidad.Cedula = estudianteEF.cedula;
		//                  estudianteEntidad.FechaNacimiento = (DateTime) estudianteEF.fecha_nacimiento;
		//                  estudianteEntidad.EstadoCivil= char.Parse(estudianteEF.estado_civil);
		//                  estudianteEntidad.IdCarrera = (int)estudianteEF.id_carrera;
		//                  estudianteEntidad.Tema= estudianteEF.tema;
		//                  estudianteEntidad.IdDocente = (int)estudianteEF.id_docente;
		//                  estudianteEntidad.IdGenero = (int)estudianteEF.id_genero;
		//              }
		//		return estudianteEntidad;

		//          }
		//	catch (Exception)
		//	{

		//		throw;
		//	}

		//}

		//      public static bool EliminarEstudianteId(int id)
		//      {
		//          try
		//          {
		//              using (TareaGrupalEntities contexto = new TareaGrupalEntities())
		//              {
		//                  EstudiantesTesis docenteEF = contexto.EstudiantesTesis
		//                                                .FirstOrDefault(p => p.id == id);
		//                  contexto.EstudiantesTesis.Remove(docenteEF);
		//                  contexto.SaveChanges();
		//                  return true;
		//              }

		//          }
		//          catch (Exception)
		//          {
		//              return false;
		//              throw;
		//          }
		//      }

		public static List<EstudianteTesisEntidad> DevolverListaEstudiantesFiltro(FiltradorBuilderEntidad filtro) {
			try {
				List<EstudianteTesisEntidad> listaEstudiantes = new List<EstudianteTesisEntidad>();
				List<EstudiantesTesis> listaEstudiantesEF = new List<EstudiantesTesis>();
				using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
					var resultado = contexto.EstudiantesTesis.SqlQuery(@"SELECT id
                                                                      ,cedula
																	  ,apellido
																	  ,nombre
																	  ,fecha_nacimiento
																	  ,estado_civil
																	  ,id_carrera
																	  ,tema
																	  ,[id_docente]
																	  ,[id_genero]
																	  ,[mesAP]
																	  ,[añoAP]
																	  ,[foto]
																	  FROM [EstudiantesTesis]
																	  " +
											filtro.ConstruirTextoFiltro(), filtro.ConstruirParametros());

					listaEstudiantesEF = resultado.ToList();


					foreach (var item in listaEstudiantesEF) {
						listaEstudiantes.Add(new EstudianteTesisEntidad(item.id, item.cedula,
                            item.nombre, item.apellido, (DateTime) item.fecha_nacimiento,
                            char.Parse(item.estado_civil), (int) item.id_carrera, item.Carreras.nombre,
                            item.tema, (int) item.id_docente, item.CuentasDocente.Usuarios.nombre, (int) item.id_genero,
                            item.Géneros.nombre, (int) item.mesAP, (int) item.añoAP));
					}

					return listaEstudiantes;

				}
			} catch (Exception) {
				throw;
			}
		}

		//public static bool EliminarEstudiante(int id)
		//{
		//	try
		//	{
		//		using(TareaGrupalEntities contexto =  new TareaGrupalEntities())
		//		{

		//			Estudiante estudianteEF = contexto.Estudiante.FirstOrDefault(p=> p.id == id);
		//		contexto.Estudiante.Remove(estudianteEF);
		//			contexto.SaveChanges();
		//			return true;

		//		}

		//	}
		//	catch (Exception)
		//	{
		//		return false;
		//		throw;
		//	}
		//}


		//public static List<EstudianteTesisEntidad> DevolverListaCSV()
		//{
		//    throw new NotImplementedException();
		//}


	}

}
