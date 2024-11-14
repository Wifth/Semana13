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
        public int Dias { get; set; }
        public double Precio { get; set; }

        public Desayuno(string nombre, double precio, int dias)
        {
            Nombre = nombre;
            Precio = precio;
            Dias = dias;
        }
        public override string ToString()
        {
            return $"Desayuno: {Nombre}, Precio: S/{Precio}, Servido durante {Dias} días.";
        }
    }
}
