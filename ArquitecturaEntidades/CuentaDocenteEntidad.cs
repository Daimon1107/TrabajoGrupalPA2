using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaEntidades
{
	public class CuentaDocenteEntidad
	{
        public int Id { get; set; }
        public FacultadEntidad Facultad { get; set; }
        public UsuarioEntidad Usuario { get; set; }

        public CuentaDocenteEntidad()
        {
                
        }

        public CuentaDocenteEntidad(int id, FacultadEntidad facultad, UsuarioEntidad usuario)
        {
            Id = id;
            Facultad = facultad;
            Usuario = usuario;
        }
    }
}
