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
        private List<string> filtro = new List<string>();
        private List<SqlParameter> parametros = new List<SqlParameter>();

        private void AñadirParametro(string nombreParametro, string parametro)
        {
            if (filtro.Count == 0)
            {
                filtro.Add($"WHERE {nombreParametro} LIKE @{nombreParametro}");
            }
            else
            {
                filtro.Add($" AND {nombreParametro} LIKE @{nombreParametro}");
            }
            parametros.Add(new SqlParameter($"@{nombreParametro}", "%" + parametro + "%"));
        }

        public FiltradorBuilderEntidad AñadirCédula(string cédula)
        {
            LimpiarParámetro("cedula");
            AñadirParametro("cedula", cédula);
            return this;
        }

        public FiltradorBuilderEntidad AñadirApellido(string apellido)
        {
            LimpiarParámetro("apellido");
            AñadirParametro("apellido", apellido);
            return this;
        }
        public FiltradorBuilderEntidad AñadirNombre(string nombre)
        {
            LimpiarParámetro("nombre");
            AñadirParametro("nombre", nombre);
            return this;
        }

        public FiltradorBuilderEntidad AñadirCarrera(string id_carrera)
        {
            LimpiarParámetro("id_carrera");
            AñadirParametro("id_carrera", id_carrera);
            return this;
        }

        public FiltradorBuilderEntidad AñadirGénero(string id_género)
        {
            LimpiarParámetro("id_genero");
            AñadirParametro("id_genero", id_género);
            return this;
        }

        public FiltradorBuilderEntidad AñadirAñoAP(string añoAP)
        {
            LimpiarParámetro("añoAP");
            AñadirParametro("añoAP", añoAP);
            return this;
        }

        public FiltradorBuilderEntidad AñadirMesAP(string mesAP)
        {
            LimpiarParámetro("mesAP");
            AñadirParametro("mesAP", mesAP);
            return this;
        }
        public FiltradorBuilderEntidad AñadirIdDocente(string id_Docente)
        {
            LimpiarParámetro("id_docente");
            AñadirParametro("id_docente", id_Docente);
            return this;
        }

        public void LimpiarParámetro(string nombreFiltro)   {
            nombreFiltro = "@" + nombreFiltro;
            int indice = filtro.FindIndex(f => f.Contains(nombreFiltro));
            if(indice == -1) {
                return; 
            }
            filtro.RemoveAt(indice);
            if (indice == 0 && filtro.Count >= 1) {
                filtro[0] = filtro[0].Replace(" AND ", "WHERE ");
            }
            parametros.Remove(
                parametros.FirstOrDefault(p => p.ParameterName.ToString().Equals(nombreFiltro)));
        }

        public string ConstruirTextoFiltro()
        {
            string filtroResultado = "";
            foreach (var item in filtro)
            {
                filtroResultado += item;
            }

            return filtroResultado;
        }
        public SqlParameter[] ConstruirParametros()
        {
            SqlParameter[] parametrosArray = new SqlParameter[parametros.Count];
            for (int i = 0; i < parametrosArray.Length; i++)
            {
                parametrosArray[i] = new SqlParameter(parametros[i].ParameterName, 
                    parametros[i].Value);
            }

            return parametrosArray;
        }

    }
}