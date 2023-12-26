using ArquitecturaDatos;
using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLogicaNegocio {
    public class DocenteNegocio {
        public static bool ComprobarSesiónVálida(CuentaDocenteEntidad docenteE) {
            docenteE = DocenteDatos.ComprobarSesiónVálida(docenteE);

            if(docenteE == null) {
                return false;
            }


            return true;
        }

        public static CuentaDocenteEntidad GuardarDocente(CuentaDocenteEntidad docente)
        {
             if (docente.Id == 0)
            {

                return DocenteDatos.NuevoDocente(docente);
               
            }

            return DocenteDatos.ActualizarDocente(docente);
        }

        public static List<CuentaDocenteEntidad> DevolverListaDocentes()
        {
            return DocenteDatos.DevolverListaDocentes();
        }

        public static CuentaDocenteEntidad DevolverDocenteId(int id)
        {
            return DocenteDatos.DevolverDocenteID(id);
        }

        public static bool EliminarDocenteID(int id)
        {
            return DocenteDatos.EliminarDocenteId(id);
        }
    }
}
