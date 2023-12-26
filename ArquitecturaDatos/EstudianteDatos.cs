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
		public static EstudianteEntidad NuevoEstudiante(EstudianteEntidad estudianteE)
		{
			try
			{
				Estudiantes estudianteEF = new Estudiantes();
				estudianteEF.id = estudianteE.Id;
				estudianteEF.cedula = estudianteE.Cédula;
				estudianteEF.apellido = estudianteE.Apellido;
				estudianteEF.nombre = estudianteE.Nombre;
				estudianteEF.fecha_nacimiento = estudianteE.FechaNacimiento;
				estudianteEF.id_carrera = estudianteE.Carrera.Id;
				estudianteEF.id_genero = estudianteE.Género.Id;
				estudianteEF.foto = estudianteE.Foto;


				using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
				{
					contexto.Estudiantes.Add(estudianteEF);
					contexto.SaveChanges();
				}

				estudianteE.Id = estudianteEF.id;
				return estudianteE;
			}


			catch (Exception)
			{

				throw;
			}
		}

		public static EstudianteEntidad NuevoEstudianteCSV(EstudianteEntidad Estudiantes)
        {
			try {
				return null;
			} catch (Exception) {

				throw;
			}
        }

		public static EstudianteEntidad ActualizarEstudiante(EstudianteEntidad estudianteE)
		{

			try
			{

                Estudiantes estudianteEF = new Estudiantes();
                estudianteEF.id = estudianteE.Id;
                estudianteEF.cedula = estudianteE.Cédula;
                estudianteEF.apellido = estudianteE.Apellido;
                estudianteEF.nombre = estudianteE.Nombre;
                estudianteEF.fecha_nacimiento = estudianteE.FechaNacimiento;
                estudianteEF.id_carrera = estudianteE.Carrera.Id;
                estudianteEF.id_genero = estudianteE.Género.Id;
                estudianteEF.foto = estudianteE.Foto;

                using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
				{
					contexto.Estudiantes.AddOrUpdate(estudianteEF);
					contexto.SaveChanges();

				}
				return estudianteE;
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
				
				using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities()) {

					var ms = contexto.Estudiantes.ToList();

					foreach (var item in ms)
					{
						listaEstudiantes.Add(new EstudianteEntidad(item.id, item.cedula, 
							item.apellido, item.nombre, (DateTime)item.fecha_nacimiento,
                            CarreraDatos.DevolverCarreraId((int)item.id_carrera),
                            GéneroDatos.DevolverGéneroId((int)item.id_genero), item.foto));
					
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

				using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
				{
					var estudianteEF = contexto.Estudiantes.Include("Genero").
												Include("CuentasDocente").
												Include("Informes").
												Include("Carreras").FirstOrDefault(p => p.id == id);

					estudianteEntidad.Id = estudianteEF.id;
					estudianteEntidad.Nombre = estudianteEF.nombre;
					estudianteEntidad.Apellido = estudianteEF.apellido;
					estudianteEntidad.FechaNacimiento = (DateTime) estudianteEF.fecha_nacimiento;
					estudianteEntidad.Carrera = CarreraDatos.DevolverCarreraId((int) estudianteEF.id_carrera);
					estudianteEntidad.Género = GéneroDatos.DevolverGéneroId((int) estudianteEF.id_genero);
					estudianteEntidad.Foto = estudianteEF.foto;
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
				using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
				{
					Estudiantes docenteEF = contexto.Estudiantes
												  .FirstOrDefault(p => p.id == id);
					contexto.Estudiantes.Remove(docenteEF);
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
				List<Estudiantes> listaEstudiantesEF = new List<Estudiantes>();
				using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities()) {
					var resultado = contexto.Estudiantes.SqlQuery(@"SELECT id
                                                                      ,cedula
																	  ,apellido
																	  ,nombre
																	  ,fecha_nacimiento
																	  ,id_carrera
																	  ,id_genero
																	  FROM [EstudiantesTesis]
																	  " +
											filtro.ConstruirTextoFiltro(), filtro.ConstruirParametros());

					listaEstudiantesEF = resultado.ToList();


					foreach (var item in listaEstudiantesEF) {
                        listaEstudiantes.Add(new EstudianteEntidad(item.id, item.cedula,
                            item.apellido, item.nombre, (DateTime)item.fecha_nacimiento,
                            CarreraDatos.DevolverCarreraId((int)item.id_carrera),
                            GéneroDatos.DevolverGéneroId((int)item.id_genero), item.foto));
                    }

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
				using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
				{

					Estudiantes estudianteEF = contexto.Estudiantes.FirstOrDefault(p => p.id == id);
					contexto.Estudiantes.Remove(estudianteEF);
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


		public static List<EstudianteEntidad> DevolverListaCSV()
		{
			throw new NotImplementedException();
		}


	}

}
