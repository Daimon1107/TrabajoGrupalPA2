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
		public static EstudianteEntidad NuevoEstudiante(EstudianteEntidad estudiante)
		{
			try
			{
				Estudiante estudianteEF = new Estudiante();
				estudianteEF.id = estudiante.Id;
				estudianteEF.nombre = estudiante.Nombre;
				estudianteEF.apellido = estudiante.Apellido;
				estudianteEF.cedula = estudiante.Cedula;
				estudianteEF.fecha_nacimiento = estudiante.FechaNacimiento;
				estudianteEF.estado_civil = estudiante.EstadoCivil.ToString();
				estudianteEF.id_carrera = estudiante.IdCarrera;
				estudianteEF.tema = estudiante.Tema;
				estudianteEF.id_docente = estudiante.IdDocente;
				estudianteEF.id_genero = estudiante.IdGenero;

	
				using (TareaGrupalEntities contexto = new TareaGrupalEntities())
				{
					contexto.Estudiante.Add(estudianteEF);
					contexto.SaveChanges();
				}

				estudiante.Id = estudianteEF.id;
				return estudiante;
			}


			catch (Exception)
			{

				throw;
			}
		}

		public static EstudianteEntidad ActualizarEstudiante(EstudianteEntidad estudiante)
		{

			try
			{

				Estudiante estudianteEF = new Estudiante();
                estudianteEF.id = estudiante.Id;
                estudianteEF.nombre = estudiante.Nombre;
                estudianteEF.apellido = estudiante.Apellido;
                estudianteEF.cedula = estudiante.Cedula;
                estudianteEF.fecha_nacimiento = estudiante.FechaNacimiento;
                estudianteEF.estado_civil = estudiante.EstadoCivil.ToString();
                estudianteEF.id_carrera = estudiante.IdCarrera;
                estudianteEF.tema = estudiante.Tema;
                estudianteEF.id_docente = estudiante.IdDocente;
                estudianteEF.id_genero = estudiante.IdGenero;

                using (TareaGrupalEntities contexto = new TareaGrupalEntities())
				{
					contexto.Estudiante.AddOrUpdate(estudianteEF);
					contexto.SaveChanges();
				
				}
				return estudiante;
			}
			catch (Exception)
			{

				throw;
			}
		
		}
		
		public static List<EstudianteEntidad> DevolverListaEstudiantes()
		{
			try
			{
				List<EstudianteEntidad> listaEstudiantes = new List<EstudianteEntidad>();
				
				using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {

					var ms = contexto.Estudiante.Include("Genero").
												Include("Docente").
												Include("Informes").
												Include("Carreras").ToList();

					foreach (var item in ms)
					{
						listaEstudiantes.Add(new EstudianteEntidad(item.id, item.cedula, 
							item.nombre, item.apellido, (DateTime)item.fecha_nacimiento, 
							char.Parse(item.estado_civil), (int)item.id_carrera, 
							item.tema, (int)item.id_docente, (int)item.id_genero));
					
					}	
				}
                return listaEstudiantes;

            }
			catch (Exception)
			{
				throw;
			}
		}

		public static EstudianteEntidad DevolverEstudianteId(int id)
		{
			try
			{

				EstudianteEntidad estudianteEntidad = new EstudianteEntidad();

				using (TareaGrupalEntities contexto = new TareaGrupalEntities())
				{
                    var estudianteEF = contexto.Estudiante.Include("Genero").
                                                Include("Docente").
                                                Include("Informes").
                                                Include("Carreras").FirstOrDefault(p => p.id == id);

                    estudianteEntidad.Id = estudianteEF.id;
                    estudianteEntidad.Nombre = estudianteEF.nombre;
                    estudianteEntidad.Apellido = estudianteEF.apellido;
                    estudianteEntidad.Cedula = estudianteEF.cedula;
                    estudianteEntidad.FechaNacimiento = (DateTime) estudianteEF.fecha_nacimiento;
                    estudianteEntidad.EstadoCivil= char.Parse(estudianteEF.estado_civil);
                    estudianteEntidad.IdCarrera = (int)estudianteEF.id_carrera;
                    estudianteEntidad.Tema= estudianteEF.tema;
                    estudianteEntidad.IdDocente = (int)estudianteEF.id_docente;
                    estudianteEntidad.IdGenero = (int)estudianteEF.id_genero;
                }
				return estudianteEntidad;

            }
			catch (Exception)
			{

				throw;
			}
		
		}

        public static bool EliminarEstudianteId(int id)
        {
            try
            {
                using (TareaGrupalEntities contexto = new TareaGrupalEntities())
                {
                    Docente docenteEF = contexto.Docente
                                                  .FirstOrDefault(p => p.id == id);
                    contexto.Docente.Remove(docenteEF);
                    contexto.SaveChanges();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static List<EstudianteEntidad> DevolverListaEstudiantesFiltro(FiltradorBuilderEntidad filtro) {
			try {
				List<EstudianteEntidad> listaEstudiantes = new List<EstudianteEntidad>();
				List<Estudiante> listaEstudiantesLINQ = new List<Estudiante>();
				using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
                    var resultado = contexto.Estudiante.SqlQuery(@"SELECT id
                                                                      ,cedula
																	  ,apellido
																	  ,nombre
																	  ,id_carrera
																	  ,id_genero
																	  ,añoAP
																	  ,mesAP
																	  ,id_docente
																	  FROM Estudiante
																	  " +
                                            filtro.ConstruirTextoFiltro(), filtro.ConstruirParametros());

                    listaEstudiantesLINQ = resultado.ToList();


					//foreach (var item in listaEstudiantesLINQ) {
					//	listaEstudiantes.Add(new EstudianteEntidad(item.id, item.cedula,
					//												item.apellido, item.nombre,
					//											(int) item.id_carrera, item.Carreras.nombre, (int) item.id_genero,
					//											item.Genero.nombre, (int) item.añoAP,
					//											(int) item.mesAP,
					//											(int) item.id_docente));
					//}

					return listaEstudiantes;

				}
			} catch (Exception) {
				throw;
			}
		}

		public static bool EliminarEstudiante(int id)
		{
			try
			{
				using(TareaGrupalEntities contexto =  new TareaGrupalEntities())
				{

					Estudiante estudianteEF = contexto.Estudiante.FirstOrDefault(p=> p.id == id);
				contexto.Estudiante.Remove(estudianteEF);
					contexto.SaveChanges();
					return true;
				
				}

			}
			catch (Exception)
			{
				return false;
				throw;
			}
		}

	}

}
