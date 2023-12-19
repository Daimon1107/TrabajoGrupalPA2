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
		public static List<GéneroEntidad> DevolverGéneros()
		{
			try
			{
				List<GéneroEntidad> listaGéneros = new List<GéneroEntidad>();
				List<Genero> listaEstudiantesLINQ = new List<Genero>();
				using (TareaGrupalEntities contexto = new TareaGrupalEntities())
				{
					var resultado = from g in contexto.Genero
									select g;

					listaEstudiantesLINQ = resultado.ToList();
				}

				foreach (var item in listaEstudiantesLINQ)
				{
					listaGéneros.Add(new GéneroEntidad(item.id, item.nombre));
				}

				return listaGéneros;


			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
