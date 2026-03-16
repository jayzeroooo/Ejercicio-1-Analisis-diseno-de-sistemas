using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class ConexionBDBuilder
    {
        private readonly ConexionBD _config = new ConexionBD();

        public ConexionBDBuilder ConServidor(string servidor)
        {
            _config.Servidor = servidor;
            return this;
        }

        public ConexionBDBuilder ConBaseDeDatos(string bd)
        {
            _config.BaseDeDatos = bd;
            return this;
        }

        public ConexionBDBuilder ConSeguridadIntegrada(string valor)
        {
            _config.SeguridadIntegrada = valor;
            return this;
        }

        public ConexionBDBuilder ConCertificadoServidor(string valor)
        {
            _config.CertificadoServidor = valor;
            return this;
        }

        public ConexionBD Build() => _config;
    }

}