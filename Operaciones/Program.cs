using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_1, num_2, resultado;
            string linea;

            Console.WriteLine("Por favor escribe un numero");
            linea = Console.ReadLine();
            num_1 = int.Parse(linea);

            Console.WriteLine("Por favor escribe un segundo numero");
            linea = Console.ReadLine();
            num_2 = int.Parse(linea);

            
            resultado = num_1 + num_2;
            Console.WriteLine("La suma es {0}: ", resultado);

            resultado = num_1 - num_2;
            Console.WriteLine("La resta es {0}: ", resultado);

            resultado = num_1 * num_2;
            Console.WriteLine("La multiplicacion es {0}: ", resultado);

            resultado = num_1 % num_2;
            Console.WriteLine("La division es {0}: ", resultado);


            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
