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
        public static CuentaDocenteEntidad NuevoDocente(CuentaDocenteEntidad docente) {
            try {
                CuentasDocente docenteEF = new CuentasDocente();
                docenteEF.Usuarios.id = docente.Id;
                docenteEF.Usuarios.nombre = docente.Nombre;
                docenteEF.Usuarios.apellido = docente.Apellido;
                docenteEF.Usuarios.cedula = docente.Cedula;
                docenteEF.Usuarios.fecha_nacimiento = docente.FechaNacimiento;
                docenteEF.id_facultad = docente.Id_Facultad;


                using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
                    contexto.CuentasDocente.Add(docenteEF);
                    contexto.SaveChanges();
                }

                docente.Id = docenteEF.Usuarios.id;
                return docente;
            } catch (Exception) {

                throw;
            }
        }


        public static CuentaDocenteEntidad ActualizarDocente(CuentaDocenteEntidad docente) {
            try {
                CuentasDocente docenteEF = new CuentasDocente();
                docenteEF.Usuarios.id = docente.Id;
                docenteEF.Usuarios.nombre = docente.Nombre;
                docenteEF.Usuarios.apellido = docente.Apellido;
                docenteEF.Usuarios.cedula = docente.Cedula;
                docenteEF.Usuarios.fecha_nacimiento= docente.FechaNacimiento;
                docenteEF.id_facultad = docente.Id_Facultad;

                using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
                    contexto.CuentasDocente.AddOrUpdate(docenteEF);
                    contexto.SaveChanges();
                }
                return docente;
            } catch (Exception) {

                throw;
            }
        }

        public static List<CuentaDocenteEntidad> DevolverListaDocentes() {
            try {
                List<CuentaDocenteEntidad> listaDocente = new List<CuentaDocenteEntidad>();

                using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
                    var ms = contexto.CuentasDocente
                                     .Include("Facultad")
                                     .ToList();

                    foreach (var item in ms) {
                        listaDocente.Add(new CuentaDocenteEntidad(item.id, (int) item.id_facultad,
                            item.Facultades.nombre, (int) item.id_datos, item.Usuarios.cedula,
                            item.Usuarios.nombre,
                            item.Usuarios.apellido,
                           (DateTime) item.Usuarios.fecha_nacimiento, (bool) item.Usuarios.rol, item.Usuarios.usuario, item.Usuarios.contraseña));
                    }
                }
                return listaDocente;

            } catch (Exception) {

                throw;
            }
        }

        public static CuentaDocenteEntidad DevolverDocenteID(int id) {
            try {
                CuentaDocenteEntidad docenteEntidad = new CuentaDocenteEntidad();
                using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
                    var docenteEF = contexto.CuentasDocente
                                             .Include("Facultad")
                                             .FirstOrDefault(p => p.id == id);
                    docenteEntidad.Id = docenteEF.Usuarios.id;
                    docenteEntidad.Nombre = docenteEF.Usuarios.nombre;
                    docenteEntidad.Apellido = docenteEF.Usuarios.apellido;
                    docenteEntidad.Cedula = docenteEF.Usuarios.cedula;
                    docenteEntidad.FechaNacimiento = (DateTime) docenteEF.Usuarios.fecha_nacimiento;
                    docenteEntidad.Id_Facultad = (int) docenteEF.id_facultad;


                }

                return docenteEntidad;
            } catch (Exception) {

                throw;
            }
        }

        public static bool EliminarDocenteId(int id) {
            try {
                using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
                    CuentasDocente docenteEF = contexto.CuentasDocente
                                                  .FirstOrDefault(p => p.id == id);
                    contexto.CuentasDocente.Remove(docenteEF);
                    contexto.SaveChanges();
                    return true;
                }

            } catch (Exception) {
                return false;
                throw;
            }
        }

        public static CuentaDocenteEntidad ComprobarSesiónVálida(CuentaDocenteEntidad docenteE) {
            try {
                using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
                    var docente = contexto.CuentasDocente.FirstOrDefault(d => (d.Usuarios.usuario == docenteE.Usuario && d.Usuarios.contraseña == docenteE.Contraseña));

                    if (docente == null) {
                        return null;
                    }

                    docenteE.Id = docente.id;

                    return docenteE;
                }
            } catch (Exception) {

                throw;
            }
            return null;
        }

        public static List<CuentaDocenteEntidad> DevolverListaDocente() {
            try {
                List<CuentaDocenteEntidad> listaDocentes = new List<CuentaDocenteEntidad>();
                List<CuentasDocente> listaEstudiantesLINQ = new List<CuentasDocente>();
                using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
                    var resultado = from e in contexto.CuentasDocente
                                    select e;

                    listaEstudiantesLINQ = resultado.ToList();
                }

                //foreach (var item in listaEstudiantesLINQ)
                //{
                //	listaDocentes.Add(new DocenteEntidad(item.id, item.usuario));
                //}

                return listaDocentes;


            } catch (Exception) {
                throw;
            }
        }


    }


}
