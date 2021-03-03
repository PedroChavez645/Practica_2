using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_String
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            String ciudad;
            //1.- Pedir por consola el nombre de una persona
            Console.WriteLine("Por favor escribe tu nombre");
            nombre = Console.ReadLine();
            //2.- Pedir el nombre de una ciudad
            Console.WriteLine("Escribe tu ciudad");
            ciudad = Console.ReadLine();
            //3.- Mostrar en pantalla
            Console.WriteLine("Hola" + nombre + "bienvenido a " + ciudad);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }

    }
    }
