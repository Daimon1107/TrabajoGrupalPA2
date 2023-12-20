using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDatos
{
    public static class FacultadDatos
    {

        public static FacultadEntidad DevolverFacultadId(int id) {
            //try {
            //    FacultadEntidad facultadEntidad = new FacultadEntidad();
            //    using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
            //        var facultadEF = contexto.Facultad.FirstOrDefault(p => p.id == id);

            //        facultadEntidad.Id = facultadEF.id;
            //        facultadEntidad.Nombre = facultadEF.nombre;


            //    }
            //    return facultadEntidad;

            //} catch (Exception) {

            //    throw;
            //}
            throw new NotImplementedException();


        }



        public static FacultadEntidad ActualizarFacultad(FacultadEntidad facultad) {
            //try {

            //    Facultad facultadEF = new Facultad();
            //    facultadEF.id = facultad.Id;
            //    facultadEF.nombre = facultad.Nombre;

            //    using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
            //        contexto.Facultad.AddOrUpdate(facultadEF);
            //        contexto.SaveChanges();
            //    }
            //    return facultad;
            //} catch (Exception) {

            //    throw;
            //}
            throw new NotImplementedException();
        }



        public static List<FacultadEntidad> DevolverListaFacultades() {
            //try {
            //    List<FacultadEntidad> listaFacultades = new List<FacultadEntidad>();
            //    using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
            //        var ms = contexto.Facultad.ToList();
            //        foreach (var item in ms) {
            //            listaFacultades.Add(new FacultadEntidad(item.id, item.nombre));


            //        }
            //    }

            //    return listaFacultades;

            //} catch (Exception) {

            //    throw;
            //}
            throw new NotImplementedException();
        }

        public static FacultadEntidad NuevaFacultad(FacultadEntidad facultad) {
            //try {
            //    Facultad facultadEF = new Facultad();
            //    facultadEF.id = facultad.Id;
            //    facultadEF.nombre = facultad.Nombre;

            //    using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
            //        contexto.Facultad.Add(facultadEF);
            //        contexto.SaveChanges();
            //    }

            //    facultad.Id = facultadEF.id;
            //    return facultad;

            //} catch (Exception) {

            //    throw;
            //}
            throw new NotImplementedException();

        }

        public static bool EliminarFacultadId(int id) {
            //try {

            //    using (TareaGrupalEntities contexto = new TareaGrupalEntities()) {
            //        Facultad facultadEF = contexto.Facultad.FirstOrDefault(p => p.id == id);
            //        contexto.Facultad.Remove(facultadEF);
            //        contexto.SaveChanges();
            //        return true;

            //    }
            //} catch (Exception) {
            //    return false;
            //    throw;
            //}
            throw new NotImplementedException();

        }

    }
}
