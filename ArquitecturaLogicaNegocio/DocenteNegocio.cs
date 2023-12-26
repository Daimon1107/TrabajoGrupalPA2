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
            docenteE = UsuarioDatos.ComprobarSesiónVálida(docenteE.Usuario, docenteE.C);

            if(docenteE == null) {
                return false;
            }


            return true;
        }

        public static CuentaDocenteEntidad GuardarDocente(CuentaDocenteEntidad CuentasDocente)
        {
             if (CuentasDocente.Id == 0)
            {

                return CuentaDocenteDatos.NuevoDocente(CuentasDocente);
               
            }

            return CuentaDocenteDatos.ActualizarDocente(CuentasDocente);
        }

        public static List<CuentaDocenteEntidad> DevolverListaDocentes()
        {
            return CuentaDocenteDatos.DevolverListaDocentes();
        }

        public static CuentaDocenteEntidad DevolverDocenteId(int id)
        {
            return CuentaDocenteDatos.DevolverDocenteID(id);
        }

        public static bool EliminarDocenteID(int id)
        {
            return CuentaDocenteDatos.EliminarDocenteId(id);
        }
    }
}
