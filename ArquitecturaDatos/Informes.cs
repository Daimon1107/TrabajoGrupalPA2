//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArquitecturaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Informes
    {
        public int id { get; set; }
        public Nullable<int> mes { get; set; }
        public Nullable<int> año { get; set; }
        public Nullable<int> id_estudiante { get; set; }
    
        public virtual EstudiantesTesis EstudiantesTesis { get; set; }
    }
}
