using ArquitecturaDatos;
using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLogicaNegocio
{
    public static class FacultadNegocio
    {
        public static List<FacultadEntidad> DevolverListaFacultades()
        {
            return FacultadDatos.DevolverListaFacultades();
        }

        public static FacultadEntidad GuardarFacultad(FacultadEntidad facultad)
        {
            if (facultad.Id == 0)
            {
                return FacultadDatos.NuevaFacultad(facultad);
            }

            //TODO: Actualizar Facultad
            return FacultadDatos.ActualizarFacultad(facultad);
        }

        public static FacultadEntidad DevolverFacultadId(int id)
        {
            return FacultadDatos.DevolverFacultadId(id);
        }

        public static bool EliminarFacultadId(int id)
        {
            return FacultadDatos.EliminarFacultadId(id);
        }
    }
}
