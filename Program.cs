using Actividad_Herencia;
Telefono telefono = new Telefono(0,null,0,0);
bool menuCondition = true;
do
{
    Console.Clear();
    Console.WriteLine("___MENU___");
    Console.WriteLine("1. Agregar nuevos productos.");
    Console.WriteLine("2. Mostrar todos los productos registrados.");
    Console.WriteLine("3. Buscar producto por nombre.");
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
                Console.ReadKey();
                break;
            case 2:
                Console.Clear();
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