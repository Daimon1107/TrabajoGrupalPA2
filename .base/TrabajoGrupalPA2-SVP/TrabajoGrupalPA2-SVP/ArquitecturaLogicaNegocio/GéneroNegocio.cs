using ArquitecturaDatos;
using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLogicaNegocio {
    public class GéneroNegocio {
        public static List<GéneroEntidad> DevolverGéneros() {
             return GéneroDatos.DevolverGéneros();

        }
    }
}
