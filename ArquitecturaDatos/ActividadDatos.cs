using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDatos
{
    public static class ActividadDatos
    {


            public static List<ActividadEntidad> DevolverListaActividades(int id_tesis)
            {
                try
                {
                    List<ActividadEntidad> listaActividades = new List<ActividadEntidad>();
                    List<Actividades> listaActividadesEF = new List<Actividades>();
                    using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
                    {
                        var actividades = contexto.Actividades.ToList().FindAll(a => a.id_tesis == id_tesis);

                    foreach (var item in actividades)
                    {
                        listaActividades.Add(new ActividadEntidad(item.id, item.nombreAct,
                                                                (DateTime) item.fechaAct, 
                                                                Maestro_TesisDatos.DevolverMaestroId((int)item.id_tesis)));
                    }
                }

   

                return listaActividades;


                }
                catch (Exception)
                {
                    throw;
                }
            }
        public static ActividadEntidad DevolverActividadId(int id)
        {
            try
            {
                ActividadEntidad actividades = new ActividadEntidad();
                using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
                {
                    Actividades actividadesEF = contexto.Actividades.FirstOrDefault((e) => e.id == actividades.Id);

                    actividades.Id = actividadesEF.id;
                    actividades.NombreActividad = actividadesEF.nombreAct;
                    actividades.Tesis = Maestro_TesisDatos.DevolverMaestroId((int)actividadesEF.id_tesis);
                }

                return actividades;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    }


