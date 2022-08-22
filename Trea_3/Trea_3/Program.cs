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
            int elementos;
            Console.WriteLine("Ingrese el numero de registro que desea realizar: ");
            elementos = int.Parse(Console.ReadLine());
            string[] nombre = new string[elementos];
            string[] carrera = new string[elementos];
            string[] edad = new string[elementos];
            string[] gmail = new string[elementos];
            string[] telefono = new string[elementos];

            int registro;
            string control = "si";
            for (int i = 0; i < elementos; i++)
            {
                Console.WriteLine("------------------------------------------------------------------------");
                Console.Write("Ingrese el nombre: ");
                nombre[i] = Console.ReadLine();

                Console.Write("Ingrese la carrera: ");
                carrera[i] = Console.ReadLine();

                Console.Write("Ingrese su edad: ");
                edad[i] = Console.ReadLine();

                Console.Write("Ingrese su gmail: ");
                gmail[i] = Console.ReadLine();

                Console.Write("Ingrese su numero telefonico: ");
                telefono[i] = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------------------");
            }
            while (control == "si")

            {

                Console.Write("Ingrese el número de registro que desea consultar: ");
                registro = int.Parse(Console.ReadLine());
                Console.Write(value: "El nombre es: " + nombre[registro] + "\n");
                Console.Write("La carrera es: " + carrera[registro] + "\n");
                Console.Write(value: "La edad es: " + edad[registro] + "\n");
                Console.Write("El gmail es: " + gmail[registro] + "\n");
                Console.Write("El telefono es: " + telefono[registro] + "\n");
                Console.Write(" Desea continuar: ");
                control = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------------------");
            }



        }
    }
}