using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Herencia
{
    public class Telefono : Producto
    {
        List<Telefono> listTelefonos = new List<Telefono>();
        int id = 5020;
        public int Id { get; set; }
        public Telefono(int id, string nombre, double precio, int stock)
        {
            Id = id;
            Name = nombre;
            Price = precio;
            Stock = stock;
        }
        public void RegistrarTelefonos()
        {
            Console.WriteLine("Ingrese la cantidad de productos que quiere registrar: ");
            int cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                id += 1;
                Console.Write("Ingrese el nombre del producto: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese el precio del producto: ");
                double precio = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el stock del producto: ");
                int stock = int.Parse(Console.ReadLine());
                listTelefonos.Add(new Telefono(id, nombre, precio, stock));
            }
        }
    }
}
