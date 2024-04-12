using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vocales
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra; int vocales, i;

            vocales = 0;

            Console.Write("\nIngrese la palabra: ");
            palabra = Console.ReadLine();

            for (i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == 'a' || palabra[i] == 'A'
                    || palabra[i] == 'e' || palabra[i] == 'E'
                    || palabra[i] == 'i' || palabra[i] == 'I'
                    || palabra[i] == 'o' || palabra[i] == 'O'
                    || palabra[i] == 'u' || palabra[i] == 'U')
                {
                    vocales = vocales + 1;
                }


            }
            Console.Write("La cantidad de vocales que posee la palabra ingresada, es de " + vocales);
            Console.Read();
        }
    }
}