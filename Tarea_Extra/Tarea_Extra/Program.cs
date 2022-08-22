using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Estructura
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] titulo = new string[3];
            titulo[0] = "Nombre: ";
            titulo[1] = "Edad: ";
            titulo[2] = "Carrera: ";
            string[,] tabla = new string[3, 3];
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine("_______________");
                Console.WriteLine("Ejecuccion " + f);
                for (int c = 0; c < 3; c++)
                {
                    Console.WriteLine("Ingrese " + titulo[c]);
                    tabla[f, c] = Console.ReadLine();
                }
            }
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine("_______________");
                Console.WriteLine("Resultado: " + f);
                for (int c = 0; c < 3; c++)
                {
                    Console.WriteLine(titulo[c] + " : " + tabla[f, c]);
                }
                Console.WriteLine("_______________");
            }
        }
    }
}