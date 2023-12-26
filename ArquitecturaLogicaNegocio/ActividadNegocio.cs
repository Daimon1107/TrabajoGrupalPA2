using ArquitecturaDatos;
using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLogicaNegocio
{
    public static class ActividadNegocio
    {
        public static List<ActividadEntidad> DevolverListaActividades(int id_tesis)
        {
            return ActividadDatos.DevolverListaActividades(id_tesis);
        }
        public static ActividadEntidad DevolverActividadId(int id)
        {
            return ActividadDatos.DevolverActividadId(id);
        }
    }
}
