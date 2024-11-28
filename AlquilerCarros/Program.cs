public class program
{
     
    public void Main(string[] args)
    {
        int opcion = -1;
        do
        {
            Console.WriteLine("BIENVENIDO AL MENU");
            Console.WriteLine("1. Crear carro");
            Console.WriteLine("2. Listar carros");
            Console.WriteLine("3. Eliminar carro");
            Console.WriteLine();
            Console.WriteLine("4. Crear cliente");
            Console.WriteLine("5. Listar clientes");
            Console.WriteLine("6. Eliminar clientes");
            Console.WriteLine();
            Console.WriteLine("7. Crear alquiler");
            Console.WriteLine("8. Listar alquileres");
            Console.WriteLine("9. Carros a alquilar");
            Console.WriteLine("0. Salir");
            Console.WriteLine();

            Console.Write("Eliga una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nPresione una tecla para volver al menu...");
                    Console.ReadKey();
                    break;
                case 2:
                    break;
                case 3:
                    Console.WriteLine("\nPresione una tecla para volver al menu...");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("\nPresione una tecla para volver al menu...");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("\nPresione una tecla para volver al ...");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("\nPresione una tecla para volver al menu...");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine("\nPresione una tecla para volver al menu...");
                    Console.ReadKey();
                    break;
                case 8:
                    Console.WriteLine("\nPresione una tecla para volver al menu...");
                    Console.ReadKey();
                    break;
                case 9:
                    Console.WriteLine("\nPresione una tecla para volver al menu...");
                    Console.ReadKey();
                    break;
            }
        } while (opcion != 0);
    }
} 

