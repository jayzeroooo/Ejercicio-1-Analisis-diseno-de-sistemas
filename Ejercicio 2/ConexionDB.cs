using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace Ejercicio_2
{
    // ── Producto: objeto que almacena la configuración ────────────────

        public class ConexionBD
        {
            public string Servidor { get; set; }
            public string BaseDeDatos { get; set; }
            public string SeguridadIntegrada { get; set; }
            public string CertificadoServidor { get; set; }

            // Arma la cadena de conexión con los valores del objeto
            public string ObtenerCadenaConexion() =>
                $"Data Source={Servidor};" +
                $"Initial Catalog={BaseDeDatos};" +
                $"Integrated Security={SeguridadIntegrada};" +
                $"Trust Server Certificate={CertificadoServidor};";

            public override string ToString() =>
                $"Data Source:              {Servidor}\n" +
                $"Initial Catalog:          {BaseDeDatos}\n" +
                $"Integrated Security:      {SeguridadIntegrada}\n" +
                $"Trust Server Certificate: {CertificadoServidor}\n" +
                $"\nCadena completa:\n{ObtenerCadenaConexion()}";
        }
}
