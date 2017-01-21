using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo8Ejercicio5
{
    class Program
    {
        //Hacer un programa que le solicite al usuario dos cadenas y luego las muestre en orden alfabético.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la primera cadena: ");
            string cad1 = Console.ReadLine();
            Console.WriteLine("Digite la segunda cadena: ");
            string cad2 = Console.ReadLine();

            string cad3 = cad1 + cad2;
            Console.WriteLine("\nUnion de cadenas: \n" + cad3);

            char[] arregloCaracteres = new char[cad3.Length];
            cad3.CopyTo(0, arregloCaracteres, 0, arregloCaracteres.Length);
            Array.Sort(arregloCaracteres);

            Console.WriteLine("\nunion de cadenas ordenada por caracteres: ");
            for (int i = 0; i < arregloCaracteres.Length; i++)
            {
                if (arregloCaracteres[i] != ' ')
                    Console.Write(arregloCaracteres[i]);
            }
            Console.ReadKey();
        }
    }
}
