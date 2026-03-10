using System;

class Program
{
    static void Main()
    {
        ShowMainMenu();
    }

    static void ShowMainMenu()
    {
        int opcion = 0;

        while (opcion != 6)
        {
            Console.Clear();
            Console.WriteLine("===== SISTEMA DE BIBLIOTECA =====");
            Console.WriteLine("1. Gestión de Libros");
            Console.WriteLine("2. Gestión de Usuarios");
            Console.WriteLine("3. Gestión de Préstamos");
            Console.WriteLine("4. Búsquedas y Reportes");
            Console.WriteLine("5. Persistencia");
            Console.WriteLine("6. Salir");
            Console.WriteLine();
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ShowBooksMenu();
                    break;

                case 2:
                    Console.WriteLine("Entrando al menú de usuarios...");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Entrando al menú de préstamos...");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("Entrando al menú de búsquedas...");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("Entrando al menú de persistencia...");
                    Console.ReadKey();
                    break;

                case 6:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void ShowBooksMenu()
    {
        int opcion = 0;

        while (opcion != 5)
        {
            Console.Clear();
            Console.WriteLine("===== GESTIÓN DE LIBROS =====");
            Console.WriteLine("1. Agregar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Buscar libro");
            Console.WriteLine("4. Eliminar libro");
            Console.WriteLine("5. Volver");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Agregar libro...");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Listar libros...");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Buscar libro...");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("Eliminar libro...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}