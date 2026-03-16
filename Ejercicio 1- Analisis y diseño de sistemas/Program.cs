using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1__Analisis_y_diseño_de_sistemas
{
    internal class Program
    {
        static void Main()
        {
            // Se construye el pedido en etapas, igual que en el proceso real
            Pedido pedido = new PedidoBuilder()
                .ConCliente("Ana López")
                .AgregarProducto("Laptop")
                .AgregarProducto("Mouse inalambrico")
                .ConDireccion("Brrio. El Calvario La palmera")
                .ConMetodoPago("Tarjeta de credito o debito")
                .ConDescuento(0.10m)   // 10 %
                .ConImpuesto(0.13m)    // 13 % IVA
                .Build();

            Console.WriteLine("Resumen del pedido");
            Console.WriteLine(pedido);
        }
    }
}