// See https://aka.ms/new-console-template for more information

string a = null;
string b = "";
string c = string.Empty;
string d = "Hola\n\tamigo";
string e = @"Hola\n\tamigo";
Console.WriteLine(d);
Console.WriteLine(e);
var h = e.Substring(4, 6);
Console.WriteLine(h);
var i = e.Replace(h, "*");
Console.WriteLine(i);
var j = e.IndexOf("o", 2);
Console.WriteLine(j);
var f = "examen";
var g = "final";
f += g;
Console.WriteLine(f);

Console.WriteLine();

var n = "Carlos Perez";
var x = n.IndexOf(" ");
var nom = n.Substring(0, x);
Console.WriteLine(nom);

Console.WriteLine();

var y = "carlos; jose; renzo";
var z = y.Split(";");
foreach (var tex in z)
{
    Console.WriteLine(tex.Trim());
}

Console.WriteLine();

string aa = "Paciencia y constancia";
int cc = aa.IndexOf("cia");
Console.WriteLine(cc);
string bb = aa.Substring(cc, 2);
Console.WriteLine(bb);