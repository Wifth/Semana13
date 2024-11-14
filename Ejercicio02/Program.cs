using Ejercicio02;


class Program
{
    static Desayuno[] desayunos = new Desayuno[10];
    static int contador = 0;  

    static void Main(string[] args)
    {
        byte opcion;
        string regresar;

        do
        {
            Console.WriteLine("===Menú===");
            Console.WriteLine("1. Crear Desayuno");
            Console.WriteLine("2. Listar Desayunos");
            Console.WriteLine("3. Eliminar Desayuno");
            Console.WriteLine("4. Fin");
            Console.Write("Ingrese una opción: ");

            while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
            {
                Console.Write("Opción inválida. Ingrese una opción entre 1 y 4: ");
            }

            switch (opcion)
            {
                case 1:
                    CrearDesayuno();
                    break;
                case 2:
                    ListarDesayunos();
                    break;
                case 3:
                    EliminarDesayuno();
                    break;
                case 4:
                    Console.WriteLine("¡Adiós! Gracias por su visita");
                    break;
            }

            Console.Write("\n¿Desea regresar al menú? [si]: ");
            regresar = Console.ReadLine().ToLower();
            Console.Clear();

        } while (regresar == "si");
    }

    static void CrearDesayuno()
    {
        if (contador < desayunos.Length)
        {
            Console.Write("Ingrese el nombre del desayuno: ");
            string nombre = Console.ReadLine();

            int dias;
            Console.Write("Ingrese la cantidad de días en los que se sirve: ");
            while (!int.TryParse(Console.ReadLine(), out dias) || dias <= 0)
            {
                Console.Write("Valor inválido. Ingrese un número positivo para los días: ");
            }

            double precio;
            Console.Write("Ingrese el precio del desayuno en soles: ");
            while (!double.TryParse(Console.ReadLine(), out precio) || precio <= 0)
            {
                Console.Write("Valor inválido. Ingrese un número positivo para el precio: ");
            }

            desayunos[contador] = new Desayuno(nombre, dias, precio);
            contador++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Desayuno creado exitosamente!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El arreglo de desayunos está lleno.");
            Console.ResetColor();
        }
    }
