using ArquitecturaDatos;
using ArquitecturaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaDatos
{
	public static class GéneroDatos
	{
		public static List<GéneroEntidad> DevolverGéneros() {
			try {
				List<GéneroEntidad> listaGéneros = new List<GéneroEntidad>();
				List<Géneros> listaEstudiantesLINQ = new List<Géneros>();
				using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities()) {
					var resultado = from g in contexto.Géneros
                                    select g;

					listaEstudiantesLINQ = resultado.ToList();
				}

				foreach (var item in listaEstudiantesLINQ) {
					listaGéneros.Add(new GéneroEntidad(item.id, item.nombre));
				}

				return listaGéneros;


			} catch (Exception) {
				throw;
			}
		}

        public static GéneroEntidad DevolverGéneroId(int id_genero)
        {
			try
			{
				using (ProyectoFinalPAEntities contexto = new ProyectoFinalPAEntities())
				{
					Géneros géneroEF = contexto.Géneros.FirstOrDefault(g => g.id == id_genero);
					GéneroEntidad géneroE = new GéneroEntidad(géneroEF.id, géneroEF.nombre);
					return géneroE;

				}
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
