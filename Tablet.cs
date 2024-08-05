using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Actividad_Herencia
{
    internal class Tablet : Producto
    {
        public List<Tablet> listOrdenador = new List<Tablet>();
        public int Id { get; set; }
        public Tablet(int id, string nombre, double precio, int stock)
        {
            Id = id;
            Name = nombre;
            Price = precio;
            Stock = stock;
        }
        public void RegistrarTablet()
        {
            int id = 10020;
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
                listOrdenador.Add(new Tablet(id, nombre, precio, stock));
            }
            Console.Clear();
            Console.WriteLine("Productos registrados correctamente.");
            Console.WriteLine("\nPresione cualquier tecla para continuar: ");
        }
        public void MostrarTablets()
        {
            Console.WriteLine("\nInformación de los ordenadores registrados: ");
            foreach (Tablet tablet in listOrdenador)
            {
                Console.WriteLine($"\nEl ID del producto: {tablet.Id}");
                Console.WriteLine($"El nombre del producto: {tablet.Name}");
                Console.WriteLine($"El precio del producto: Q{tablet.Price}");
                Console.WriteLine($"El stock del producto: {tablet.Stock} unidades");
            }
        }
    }
}
