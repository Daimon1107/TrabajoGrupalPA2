using ArquitecturaDatos;
using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDatos
{
	public static class CarreraDatos
	{

        public static CarreraEntidad NuevaCarrera(CarreraEntidad carrera)
        {
			try
			{
				Carreras carreraEF = new Carreras();
				carreraEF.id = carrera.Id;
				carreraEF.nombre = carrera.Nombre;
				carreraEF.id_facultad = carrera.Id_Facultad;


				using (TareaGrupalEntities contexto = new TareaGrupalEntities())
				{ 
				contexto.Carreras.Add(carreraEF);
					contexto.SaveChanges();
				}

                carrera.Id = carreraEF.id;
                return carrera;

            }
			catch (Exception)
			{

				throw;
			}
        }
       
		public static CarreraEntidad ActualizarCarrera(CarreraEntidad carrera)
		{
			try
			{

                Carreras carreraEF = new Carreras();
                carreraEF.id = carrera.Id;
				carreraEF.nombre = carrera.Nombre;
				carreraEF.id_facultad = carrera.Id_Facultad;

				using (TareaGrupalEntities contexto = new TareaGrupalEntities())
				{ 
				contexto.Carreras.AddOrUpdate(carreraEF);
					contexto.SaveChanges();	
				}
				return carrera;
            }
			catch (Exception)
			{

				throw;
			}
		}

		public static List<CarreraEntidad> DevolverListaCarreras()
		{
			try
			{
				List<CarreraEntidad> listaCarreras = new List<CarreraEntidad>();
				using (TareaGrupalEntities contexto = new TareaGrupalEntities())
				{
					var ms = contexto.Carreras.Include("Facultad").ToList();
                    foreach (var item in ms)
                    {
						listaCarreras.Add(new CarreraEntidad(item.id, item.nombre, (int) item.id_facultad));
                    }

                }

				return listaCarreras;
			}
			catch (Exception)
			{

				throw;
			}
		}

		public static CarreraEntidad DevolverCarreraId(int id)
		{
			try
			{
				CarreraEntidad carreraEntidad = new CarreraEntidad();
				using (TareaGrupalEntities contexto = new TareaGrupalEntities())
				{ 
				var carreraEF = contexto.Carreras.Include("Facultad").FirstOrDefault(c => c.id == id);
					carreraEntidad.Id = carreraEF.id;
					carreraEntidad.Nombre = carreraEF.nombre;
					carreraEntidad.Id_Facultad = (int) carreraEF.id_facultad;
					carreraEntidad.Facultad = carreraEF.Facultad.nombre;

				}

				return carreraEntidad;
			}
			catch (Exception)
			{

				throw;
			}
		}


		public static bool EliminarCarrera(int id)
		{
			try
			{
				using (TareaGrupalEntities contexto = new TareaGrupalEntities()) 
				{ 
				Carreras carreraEF = contexto.Carreras.FirstOrDefault(c => c.id == id);
					contexto.Carreras.Remove(carreraEF);
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