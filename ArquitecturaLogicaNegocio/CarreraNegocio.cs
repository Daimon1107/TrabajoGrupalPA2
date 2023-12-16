using ArquitecturaDatos;
using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaLogicaNegocio {
    public static class CarreraNegocio {

        public static CarreraEntidad GuardarCarrera(CarreraEntidad carrera)
        {
            if (carrera.Id == 0) {
                return CarreraDatos.NuevaCarrera(carrera);
            
            }
            return CarreraDatos.ActualizarCarrera(carrera);

        }
        public static List<CarreraEntidad> DevolverCarreras() {
            return CarreraDatos.DevolverListaCarreras();
        }

        public static CarreraEntidad DevolverCarreraID(int id) 
        {

            return CarreraDatos.DevolverCarreraId(id);
        }

        public static bool EliminarCarreraId(int id) 
        {
            return CarreraDatos.EliminarCarrera(id);
        }
    }
}
