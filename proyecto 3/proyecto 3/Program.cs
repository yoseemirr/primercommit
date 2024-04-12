using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_3
{
    class Program
    {
        static void Main(string[] args)
        {//declaracion de variable
            Double num1;
            Double num2;
            Double resultado;
            //asignacion
            Console.Write("Ingrese un numero  "); 
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero  "); 
            num2 = double.Parse(Console.ReadLine());
            
          //asignacion al total
            resultado = num1+num2;
                //muestro el total
                Console.Write("El resultado es: "+ resultado);
            //mantengo el resultado en pantalla
            Console.ReadKey();
        }
    }
}
