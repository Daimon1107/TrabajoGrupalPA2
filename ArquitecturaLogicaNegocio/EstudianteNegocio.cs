using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArquitecturaDatos;
using ArquitecturaEntidades;

namespace ArquitecturaLogicaNegocio {
    public static class EstudianteNegocio {
        //public static EstudianteTesisEntidad GuardarEstudiante(EstudianteTesisEntidad estudiante)
        //{
        //    if (estudiante.Id == 0)
        //    {
        //        return EstudianteDatos.NuevoEstudiante(estudiante);
        //    }
        //    return EstudianteDatos.ActualizarEstudiante(estudiante);

        //}
        public static EstudianteTesisEntidad AñadirEstudianteCSV(EstudianteTesisEntidad estudiante) {
            return EstudianteDatos.NuevoEstudianteCSV(estudiante);
        }
        public static List<EstudianteTesisEntidad> DevolverListaEstudiantes() {
            return EstudianteDatos.DevolverListaEstudiantes();
        }

        public static List<EstudianteTesisEntidad> DevolverListaEstudiantes(FiltradorBuilderEntidad filtro) {
            return EstudianteDatos.DevolverListaEstudiantesFiltro(filtro);
        }

        //    public static EstudianteTesisEntidad DevolverEstudianteId(int id)
        //    {
        //        return EstudianteDatos.DevolverEstudianteId(id);
        //    }

        //    public static bool EliminarEstudianteID(int id)
        //    {
        //        return EstudianteDatos.EliminarEstudiante(id);
        //    }
        //}
    }
}
