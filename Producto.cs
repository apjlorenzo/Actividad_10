using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Herencia
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public void PedirProductos()
        {
            Console.Write("Ingrese el tipo de producto que quiere ingresar (1.Teléfono, 2.Ordenador, 3.Tablet): ");
            int tipoProducto = int.Parse(Console.ReadLine());            
         
        }
    }
}
