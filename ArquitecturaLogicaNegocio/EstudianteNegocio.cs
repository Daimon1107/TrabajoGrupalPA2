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
        public static EstudianteEntidad GuardarEstudiante(EstudianteEntidad Estudiantes)
        {
            if (Estudiantes.Id == 0)
            {
                return EstudianteDatos.NuevoEstudiante(Estudiantes);
            }
            return EstudianteDatos.ActualizarEstudiante(Estudiantes);

        }
        public static EstudianteEntidad AñadirEstudianteCSV(EstudianteEntidad Estudiantes)
        {
            return EstudianteDatos.NuevoEstudianteCSV(Estudiantes);
        }
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
    }
}
