using ArquitecturaDatos;
using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDatos
{
	public static class DocenteDatos
	{
        public static DocenteEntidad NuevoDocente(DocenteEntidad docente)
        {
			try
			{
                Docente docenteEF= new Docente();
				docenteEF.id = docente.Id;
				docenteEF.nombre = docente.Nombre;
				docenteEF.apellido = docente.Apellido;
				docenteEF.cedula = docente.Cedula;
				docenteEF.fecha_naciemiento = docente.FechaNacimiento;
				docenteEF.id_facultad = docente.IdFacultad;


                using (TareaGrupalEntities contexto = new TareaGrupalEntities())
                {
                    contexto.Docente.Add(docenteEF);
                    contexto.SaveChanges();
                }

                docente.Id = docenteEF.id;
                return docente;
            }
			catch (Exception)
			{

				throw;
			}
        }


        public static DocenteEntidad ActualizarDocente(DocenteEntidad docente)
        {
            try
            {
                Docente docenteEF= new Docente();
                docenteEF.id = docente.Id;
                docenteEF.nombre = docente.Nombre;
                docenteEF.apellido = docente.Apellido;
                docenteEF.cedula = docente.Cedula;
                docenteEF.fecha_naciemiento = docente.FechaNacimiento;
                docenteEF.id_facultad = docente.IdFacultad;

                using (TareaGrupalEntities contexto = new TareaGrupalEntities())
                {
                    contexto.Docente.AddOrUpdate(docenteEF);
                    contexto.SaveChanges();
                }
                return docente;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<DocenteEntidad> DevolverListaDocentes()
        {
            try
            {
                List<DocenteEntidad> listaDocente = new List<DocenteEntidad>();

                using (TareaGrupalEntities contexto = new TareaGrupalEntities())
                {
                    var ms = contexto.Docente
                                     .Include("Facultad")
                                     .ToList();

                    foreach (var item in ms)
                    {
                        listaDocente.Add(new DocenteEntidad(item.id, item.cedula, 
                            item.nombre, item.apellido, 
                           (DateTime) item.fecha_naciemiento, (int)item.id_facultad));
                    }
                }
                return listaDocente;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DocenteEntidad DevolverDocenteID(int id)
        {
            try
            {
                DocenteEntidad docenteEntidad = new DocenteEntidad();
                using (TareaGrupalEntities contexto = new TareaGrupalEntities())
                {
                    var docenteEF = contexto.Docente
                                             .Include("Facultad")
                                             .FirstOrDefault(p => p.id == id);
                    docenteEntidad.Id = docenteEF.id;
                    docenteEntidad.Nombre = docenteEF.nombre;
                    docenteEntidad.Apellido = docenteEF.apellido;
                    docenteEntidad.Cedula = docenteEF.cedula;
                    docenteEntidad.FechaNacimiento = (DateTime)docenteEF.fecha_naciemiento;
                    docenteEntidad.IdFacultad= (int)docenteEF.id_facultad;


                     }

                return docenteEntidad;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool EliminarDocenteId(int id)
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

        public static DocenteEntidad ComprobarSesiónVálida(DocenteEntidad docenteE) {
			//try {
			//	using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
			//		var docente = contexto.Docente.FirstOrDefault(d => (d.usuario == docenteE.Usuario && d.contrasena == docenteE.Contraseña));

			//		if(docente == null) {
			//			return null;
			//		}

			//		docenteE.Id = docente.id;

			//		return docenteE;
			//	}
			//} catch (Exception) {

			//	throw;
			//}
			return null;
        }

  //      public static List<DocenteEntidad> DevolverListaDocente()
		//{
		//	try
		//	{
		//		List<DocenteEntidad> listaDocentes = new List<DocenteEntidad>();
		//		List<Docente> listaEstudiantesLINQ = new List<Docente>();
		//		using (TareaGrupalEntities contexto = new TareaGrupalEntities())
		//		{
		//			var resultado = from e in contexto.Docente
		//							select e;

		//			listaEstudiantesLINQ = resultado.ToList();
		//		}

		//		//foreach (var item in listaEstudiantesLINQ)
		//		//{
		//		//	listaDocentes.Add(new DocenteEntidad(item.id, item.usuario));
		//		//}

		//		return listaDocentes;


		//	}
		//	catch (Exception)
		//	{
		//		throw;
		//	}
		//}


    }


}
