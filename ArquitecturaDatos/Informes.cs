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
    
        public virtual Estudiante Estudiante { get; set; }
    }
}
