using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace Ejercicio_2

{
    class Program
    {
        static void Main()
        {
            // Construimos con los datos exactos de tu servidor
            ConexionBD config = new ConexionBDBuilder()
                .ConServidor("msi")
                .ConBaseDeDatos("SistemaDB")
                .ConSeguridadIntegrada("True")
                .ConCertificadoServidor("True")
                .Build();

            Console.WriteLine("=== Configuracion de Base de Datos ===");
            Console.WriteLine(config);

            // Probamos la conexión real
            using (SqlConnection conexion = new SqlConnection(config.ObtenerCadenaConexion()))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("\n Conexion exitosa a SistemaDB");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n Error: {ex.Message}");
                }
            }
        }
    }
}
