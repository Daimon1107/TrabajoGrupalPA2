//------------------------------------------------------------------------------

namespace ArquitecturaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Docente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Docente()
        {
            this.Estudiante = new HashSet<Estudiante>();
        }
    
        public int id { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Nullable<System.DateTime> fecha_naciemiento { get; set; }
        public Nullable<int> id_facultad { get; set; }
    
        public virtual Facultad Facultad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estudiante> Estudiante { get; set; }
    }
}
