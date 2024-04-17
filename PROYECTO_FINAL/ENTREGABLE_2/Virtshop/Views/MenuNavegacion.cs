using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Virtshop - Menú de Navegación\n");

        // Muestra las opciones del menú
        MostrarMenu();

        // Solicita al usuario que seleccione una opción del menú
        SeleccionarOpcion();
    }

    static void MostrarMenu()
    {
        Console.WriteLine("1. Inicio");
        Console.WriteLine("2. Productos");
        Console.WriteLine("3. Proveedores");
        Console.WriteLine("4. Entrada de productos");
        Console.WriteLine("5. Salida de productos");
        Console.WriteLine("6. Movimientos de inventario");
        Console.WriteLine("7. Salir");
    }

    static void SeleccionarOpcion()
    {
        while (true)
        {
            Console.Write("\nSeleccione una opción del menú: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Has seleccionado la opción de Inicio.");
                    // Aquí puedes redirigir al usuario a la sección de Inicio de tu página web
                    break;
                case "2":
                    Console.WriteLine("Has seleccionado la opción de Productos.");
                    // Aquí puedes redirigir al usuario a la sección de Productos de tu página web
                    break;
                case "3":
                    Console.WriteLine("Has seleccionado la opción de Proveedores.");
                    // Aquí puedes redirigir al usuario a la sección de Proveedores de tu página web
                    break;
                case "4":
                    Console.WriteLine("Has seleccionado la opción de Entrada de productos.");
                    // Aquí puedes redirigir al usuario a la sección de Entrada de productos de tu página web
                    break;
                case "5":
                    Console.WriteLine("Has seleccionado la opción de Salida de productos.");
                    // Aquí puedes redirigir al usuario a la sección de Salida de productos de tu página web
                    break;
                case "6":
                    Console.WriteLine("Has seleccionado la opción de Movimientos de inventario.");
                    // Aquí puedes redirigir al usuario a la sección de Movimientos de inventario de tu página web
                    break;
                case "7":
                    Console.WriteLine("¡Hasta luego!");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida del menú.");
                    break;
            }
        }
    }
}
