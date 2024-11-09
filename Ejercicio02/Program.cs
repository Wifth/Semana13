using Ejercicio02;

class Program
{
    static void Main()
    {
        MostrarMenu();
        string opcion = Console.ReadLine().ToLower();

        MostrarDesayunoSeleccionado(opcion);
    }

    static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("Elige un tipo de desayuno:");
        Console.WriteLine("1. Continental");
        Console.WriteLine("2. Buffet");
        Console.WriteLine("3. Americano");
        Console.WriteLine("4. Inglés");
        Console.Write("Ingresa el número del desayuno que deseas elegir (1-4): ");
    }

    static void MostrarDesayunoSeleccionado(string opcion)
    {
        Desayuno desayunoSeleccionado = null;

        switch (opcion)
        {
            case "1":
                desayunoSeleccionado = new Desayuno("Continental", 30.0, 2);
                break;
            case "2":
                desayunoSeleccionado = new Desayuno("Buffet", 50.0, 1);
                break;
            case "3":
                desayunoSeleccionado = new Desayuno("Americano", 15.0, 5);
                break;
            case "4":
                desayunoSeleccionado = new Desayuno("Inglés", 25.0, 3);
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, elige un número entre 1 y 4.");
                return;
        }

        Console.Clear();
        Console.WriteLine($"Has seleccionado el desayuno: {desayunoSeleccionado.Nombre}");
        Console.WriteLine($"Precio: S/{desayunoSeleccionado.Precio}");
        Console.WriteLine($"Se sirve durante {desayunoSeleccionado.Dias} días.");

        Console.ReadKey();
    }
}

