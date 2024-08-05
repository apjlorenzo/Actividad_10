using Actividad_Herencia;
Telefono telefono = new Telefono(0,null,0,0);
bool menuCondition = true;
try
{
    do
    {
        Console.Clear();
        Console.WriteLine("___MENU___");
        Console.WriteLine("1. Agregar nuevos productos.");
        Console.WriteLine("2. Mostrar todos los productos registrados.");
        Console.WriteLine("3. Buscar producto por nombre.");
        Console.WriteLine("4. Salir");
        Console.Write("Escriba una opción: ");
        try
        {
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Ingrese el tipo de producto que quiere ingresar (1.Teléfono, 2.Ordenador, 3.Tablet): ");
                    int tipoProducto = int.Parse(Console.ReadLine());
                    if (tipoProducto == 1)
                    {
                        telefono.RegistrarTelefonos();
                    }
                    else if (tipoProducto == 2)
                    {

                    }
                    else if (tipoProducto == 3)
                    {

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("No es una opción válida");
                        Console.ReadKey();
                    }
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    telefono.MostrarTelefonos();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.ReadKey();
                    break;
                case 4:
                    menuCondition = false;
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    while (menuCondition);

}
finally
{
    Console.WriteLine("\nGracias por usar nuestro sistema...");
}