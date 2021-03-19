using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfChar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir el caracter
            
                Console.WriteLine("Por favor ingresa un character");
                char c = (char)Console.Read();
            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                {
                    Console.WriteLine("El caracter es la letra minuscula");
                }
            else
                {
                    Console.WriteLine("El caracter es letra mayuscula");
                }
            }
            else
            {
                Console.WriteLine("El caracter es un numero");
            }
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
