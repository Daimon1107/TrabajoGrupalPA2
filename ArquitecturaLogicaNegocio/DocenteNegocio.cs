using ArquitecturaDatos;
using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLogicaNegocio {
    public class DocenteNegocio {
        public static bool ComprobarSesiónVálida(DocenteEntidad docenteE) {
            docenteE = DocenteDatos.ComprobarSesiónVálida(docenteE);

            if(docenteE == null) {
                return false;
            }


            return true;
        }

        public static DocenteEntidad GuardarDocente(DocenteEntidad docente)
        {
             if (docente.Id == 0)
            {

                return DocenteDatos.NuevoDocente(docente);
               
            }

            return DocenteDatos.ActualizarDocente(docente);
        }

        public static List<DocenteEntidad> DevolverListaDocentes()
        {
            return DocenteDatos.DevolverListaDocentes();
        }

        public static DocenteEntidad DevolverDocenteId(int id)
        {
            return DocenteDatos.DevolverDocenteID(id);
        }

        public static bool EliminarDocenteID(int id)
        {
            return DocenteDatos.EliminarDocenteId(id);
        }
    }
}
