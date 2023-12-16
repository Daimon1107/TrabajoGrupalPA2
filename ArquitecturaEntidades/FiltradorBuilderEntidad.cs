using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquitecturaEntidades
{
    public class FiltradorBuilderEntidad
    {
        private StringBuilder filtro = new StringBuilder();
        private List<SqlParameter> parametros = new List<SqlParameter>();
        private int contadorParametros = 0;

        private void AñadirParametro(string nombreParametro, string parametro)
        {
            if (contadorParametros == 0)
            {
                filtro.Append($"WHERE {nombreParametro} LIKE @{nombreParametro}");
                contadorParametros++;
            }
            else
            {
                filtro.Append($" AND {nombreParametro} LIKE @{nombreParametro}");
                contadorParametros++;
            }
            parametros.Add(new SqlParameter($"@{nombreParametro}", "%" + parametro + "%"));
        }

        public FiltradorBuilderEntidad AñadirCédula(string cédula)
        {
            AñadirParametro("cedula", cédula);
            return this;
        }

        public FiltradorBuilderEntidad AñadirApellido(string apellido)
        {
            AñadirParametro("apellido", apellido);
            return this;
        }
        public FiltradorBuilderEntidad AñadirNombre(string nombre)
        {
            AñadirParametro("nombre", nombre);
            return this;
        }

        public FiltradorBuilderEntidad AñadirCarrera(string id_carrera)
        {
            AñadirParametro("id_carrera", id_carrera);
            return this;
        }

        public FiltradorBuilderEntidad AñadirGénero(string id_género)
        {
            AñadirParametro("id_genero", id_género);
            return this;
        }

        public FiltradorBuilderEntidad AñadirAñoAP(string añoAP)
        {
            AñadirParametro("añoAP", añoAP);
            return this;
        }

        public FiltradorBuilderEntidad AñadirMesAP(string mesAP)
        {
            AñadirParametro("mesAP", mesAP);
            return this;
        }
        public FiltradorBuilderEntidad AñadirIdDocente(string id_Docente)
        {
            AñadirParametro("id_docente", id_Docente);
            return this;
        }

        public string ConstruirTextoFiltro()
        {
            return filtro.ToString();
        }
        public SqlParameter[] ConstruirParametros()
        {
            SqlParameter[] parametrosArray = new SqlParameter[parametros.Count];
            for (int i = 0; i < parametrosArray.Length; i++)
            {
                parametrosArray[i] = parametros[i];
            }

            return parametrosArray;
        }
    }
}