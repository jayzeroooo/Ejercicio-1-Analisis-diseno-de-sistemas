using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1__Analisis_y_diseño_de_sistemas
{
    public class PedidoBuilder
    {
        private readonly Pedido _pedido = new Pedido();

        public PedidoBuilder ConCliente(string nombre)
        {
            _pedido.Cliente = nombre;
            return this;       // permite encadenamiento fluido
        }

        public PedidoBuilder AgregarProducto(string producto)
        {
            _pedido.Productos.Add(producto);
            return this;
        }

        public PedidoBuilder ConDireccion(string direccion)
        {
            _pedido.DireccionEnvio = direccion;
            return this;
        }

        public PedidoBuilder ConMetodoPago(string metodo)
        {
            _pedido.MetodoPago = metodo;
            return this;
        }

        public PedidoBuilder ConDescuento(decimal porcentaje)
        {
            _pedido.Descuento = porcentaje;
            return this;
        }

        public PedidoBuilder ConImpuesto(decimal porcentaje)
        {
            _pedido.Impuesto = porcentaje;
            return this;
        }

        // Devuelve el objeto final construido
        public Pedido Build() => _pedido;
    }

}
