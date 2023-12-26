using ArquitecturaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLogicaNegocio {
    public class InformeNegocio {
        public static object DevolverListaInformes(int id) {
            return InformeDatos.DevolverListaInformes(id);
        }
    }
}
