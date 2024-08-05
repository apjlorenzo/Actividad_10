using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Herencia
{
    public class Telefono : Producto
    {
        public List<Telefono> listTelefonos = new List<Telefono>();
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
            int id = 5020;
            Console.WriteLine("Ingrese la cantidad de productos que quiere registrar: ");
            int cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                id += 1;
                Console.Write("Ingrese el nombre del producto: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese el precio del producto: Q");
                double precio = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el stock del producto: ");
                int stock = int.Parse(Console.ReadLine());
                listTelefonos.Add(new Telefono(id, nombre, precio, stock));
            }
            Console.Clear();
            Console.WriteLine("Productos registrados correctamente.");
            Console.WriteLine("\nPresione cualquier tecla para continuar: ");
        }
        public void MostrarTelefonos()
        {
            Console.WriteLine("Información de los teléfonos registrados: ");
            foreach (Telefono telefono in listTelefonos)
            {
                Console.WriteLine($"\nEl ID del producto: {telefono.Id}");
                Console.WriteLine($"El nombre del producto: {telefono.Name}");
                Console.WriteLine($"El precio del producto: Q{telefono.Price}");
                Console.WriteLine($"El stock del producto: {telefono.Stock} unidades");
            }
            Console.WriteLine("Presione cualquier tecla para continuar: ");
            Console.ReadKey();
        }
    }
}
