// See https://aka.ms/new-console-template for more information

using Ejercicio02;

Desayuno d = new Desayuno();
d.Nombre = "Continental";
d.Precio = 20.5;
d.Dias = "lun,mar,mier";

Console.WriteLine(d);

string[] lista = d.ListaDias();
foreach (string str in lista)
{
    Console.WriteLine(str);
}