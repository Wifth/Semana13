// See https://aka.ms/new-console-template for more information

using Ejercicio02;
byte opcion;
string regresar;
Desayuno d = new Desayuno();
do
{
    Console.WriteLine("Menu");
    Console.WriteLine();
    Console.WriteLine("1. Crear");
    Console.WriteLine(".2 Lista");
    Console.WriteLine("3. Eliminar");
    Console.WriteLine("4. Cerrar");
    Console.WriteLine();
    Console.Write("Ingrese una opcion: ");

    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)
    {
        Console.Write("Error: Ingrese opción: ");
    }

    switch (opcion)
    {
        case 0: Environment.Exit(0); break;
        case 1: d.Crear(); break;
        case 2: d.Eliminar(); break;
        case 3: d.Lista(); break;
    }
    Console.Write("\nDesea regresar al menú? [si]: ");
    regresar = Console.ReadLine().ToLower();
    Console.Clear();
}  while (regresar == "si");

//crear: crear un desayuno
//lista: cuantos días se sirven los desayunos
//elimina: eliminar un desayuno