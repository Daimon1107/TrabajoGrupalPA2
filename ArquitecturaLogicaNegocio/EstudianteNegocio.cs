using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArquitecturaDatos;
using ArquitecturaEntidades;

namespace ArquitecturaLogicaNegocio
{
    public static class EstudianteNegocio
    {
        public static EstudianteEntidad GuardarEstudiante(EstudianteEntidad estudiante)
        {
            if (estudiante.Id == 0)
            {
                return EstudianteDatos.NuevoEstudiante(estudiante);
            }
            return EstudianteDatos.ActualizarEstudiante(estudiante);

        }
<<<<<<< HEAD
=======

        public static EstudianteEntidad AñadirEstudianteCSV(EstudianteEntidad estudiante)
        {
            return EstudianteDatos.NuevoEstudianteCSV(estudiante);
        }
>>>>>>> 17643e0074c44032c439036b9a81f5b195ffa56f
        public static List<EstudianteEntidad> DevolverListaEstudiantes()
        {
             return EstudianteDatos.DevolverListaEstudiantes();
        }

        public static List<EstudianteEntidad> DevolverListaEstudiantesFiltro(FiltradorBuilderEntidad filtro) {
            return EstudianteDatos.DevolverListaEstudiantesFiltro(filtro);
        }

        public static EstudianteEntidad DevolverEstudianteId(int id)
        {
            return EstudianteDatos.DevolverEstudianteId(id);
        }

        public static bool EliminarEstudianteID(int id)
        {
            return EstudianteDatos.EliminarEstudiante(id);
        }
<<<<<<< HEAD
=======

>>>>>>> 17643e0074c44032c439036b9a81f5b195ffa56f
    }
}
