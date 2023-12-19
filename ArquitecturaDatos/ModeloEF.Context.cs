
namespace ArquitecturaDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TareaGrupalEntities : DbContext
    {
        public TareaGrupalEntities()
            : base("name=TareaGrupalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Carreras> Carreras { get; set; }
        public virtual DbSet<Docente> Docente { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Facultad> Facultad { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Informes> Informes { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
