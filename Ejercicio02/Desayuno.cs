using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class Desayuno
    {
        public string Nombre { get; set; }
        public string Dias { get; set; }
        public double Precio { get; set; }

        static void Crear()
        {
            Console.WriteLine("Ingrese el nombre del plato a crear: ");
            string n = Console.ReadLine();
            Console.WriteLine("Ingrese el costo del plato: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los días en venta: ");

        }
        static void Eliminar()
        {
            
        }
        static void Lista()
        {

        }
    }
}
