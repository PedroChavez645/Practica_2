using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int num;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola {0}, cuantos años tienes?", nombre);
            num = int.Parse(System.Console.ReadLine());

            Console.WriteLine("Hola tu nombre es: " + nombre + " y tu edad es: " + num);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
