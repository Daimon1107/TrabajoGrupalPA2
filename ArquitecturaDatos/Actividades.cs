//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArquitecturaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Actividades
    {
        public int id { get; set; }
        public string nombreAct { get; set; }
        public Nullable<System.DateTime> fechaAct { get; set; }
        public Nullable<int> id_tesis { get; set; }
    
        public virtual Maestro_Tesis Maestro_Tesis { get; set; }
    }
}