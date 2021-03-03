using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar 3 variables de tipo INT
            int perimetro_a = 10;
            int perimetro_b = 10;
            int perimetro_c = 7;

            //2.-- Crear una variable de tipo INT la cual guardara la SUMA y la obtención del perimetro
            int suma = perimetro_a + perimetro_b + perimetro_c;

            //3.- Mostrar en pantalla el valor de SUMA "El perimetro del triangulo es: "
            Console.WriteLine("El perimetro del triangulo es: " + suma);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
