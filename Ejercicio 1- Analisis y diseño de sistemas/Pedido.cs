using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1__Analisis_y_diseño_de_sistemas
{
    public class Pedido
    {
        public string Cliente { get; set; }
        public List<string> Productos { get; set; } = new List<string>();
        public string DireccionEnvio { get; set; }
        public string MetodoPago { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }

        public override string ToString() =>
            $"Cliente: {Cliente}\n" +
            $"Productos: {string.Join(", ", Productos)}\n" +
            $"Envío a: {DireccionEnvio}\n" +
            $"Pago: {MetodoPago}\n" +
            $"Descuento: {Descuento:P0} | Impuesto: {Impuesto:P0}";
    }
}
