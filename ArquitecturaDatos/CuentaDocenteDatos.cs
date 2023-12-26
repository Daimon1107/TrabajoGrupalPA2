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
	public static class CuentaDocenteDatos
	{
        public static CuentaDocenteEntidad NuevoDocente(CuentaDocenteEntidad docente)
        {
			try
			{
                CuentasDocente docenteEF= new CuentasDocente();
				docenteEF.id = docente.Id;
				docenteEF.id_facultad = docente.Facultad.Id;
				docenteEF.id_datos = docente.Usuario.Id;
   
                using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
                {
                    contexto.CuentasDocente.Add(docenteEF);
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


        public static CuentaDocenteEntidad ActualizarDocente(CuentaDocenteEntidad docente)
        {
            try
            {
                CuentasDocente docenteEF = new CuentasDocente();
                docenteEF.id = docente.Id;
                docenteEF.id_facultad = docente.Facultad.Id;
                docenteEF.id_datos = docente.Usuario.Id;


                using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
                {
                    contexto.CuentasDocente.AddOrUpdate(docenteEF);
                    contexto.SaveChanges();
                }
                return docente;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<CuentaDocenteEntidad> DevolverListaDocentes()
        {
            try
            {
                List<CuentaDocenteEntidad> listaDocente = new List<CuentaDocenteEntidad>();

                using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
                {
                    var ms = contexto.CuentasDocente
                                     .Include("Facultad")
                                     .ToList();

                    foreach (var item in ms)
                    {
                        listaDocente.Add(new CuentaDocenteEntidad(item.id, FacultadDatos.DevolverFacultadId((int)item.id_facultad), 
                            UsuarioDatos.DevolverUsuarioId( (int)item.id_datos)));
                    }
                }
                return listaDocente;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static CuentaDocenteEntidad DevolverDocenteID(int id)
        {
            try
            {
                CuentaDocenteEntidad CuentaDocenteEntidad = new CuentaDocenteEntidad();
                using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
                {
                    var docenteEF = contexto.CuentasDocente
                                             .Include("Facultad")
                                             .FirstOrDefault(p => p.id == id);
                    CuentaDocenteEntidad.Id = docenteEF.id;
                    CuentaDocenteEntidad.Facultad = FacultadDatos.DevolverFacultadId((int) docenteEF.id_facultad);
                    CuentaDocenteEntidad.Usuario = UsuarioDatos.DevolverUsuarioId((int)docenteEF.id_datos);

                     }

                return CuentaDocenteEntidad;
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
                using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
                {
                    CuentasDocente docenteEF = contexto.CuentasDocente
                                                  .FirstOrDefault(p => p.id == id);
                    contexto.CuentasDocente.Remove(docenteEF);
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
