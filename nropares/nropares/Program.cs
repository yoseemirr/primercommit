using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace VERIFICANDO_NUMEROS_PARES
{
class Program
{
static void Main(string[] args)
{
int Numero;

Console.Title = "Programación II 2024 - VERIFICANDO NUMEROS PARES";

Console.Write("\nIngrese un numero:");
Numero = int.Parse(Console.ReadLine());
if (Numero < 0)
{

Console.Write("\n\tNúmero Negativo...Ingrese unmnumero positivo");

}
else if (Numero % 2 == 0)
{

Console.Write("\n\tEl número (" + Numero + ") es par.");

if (Numero >= 10 && Numero <= 100)
{

Console.Write("\n\tEl número (" + Numero + ") se encuentra en el rango [10-100]");

}
else
{

Console.Write("\n\tEl número (" + Numero + ") NO esta en el rango [10-00]");

}
}
else
{
Console.Write("\n\tEl número ingresado es impar...");
}
Console.ReadKey();
}
}
}