using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burguer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            int cantidadburger, cantidadpapas, cantidadbebida;
            double total;
            string linea;
            const double Precioburger = 45;
            const double Preciobebida = 15;
            const double Preciopapas = 20;

            //Solicitar Datos en la consola
            Console.WriteLine("Ingresa la cantidad de hamburguesas: ");
            linea = Console.ReadLine();
            cantidadburger = int.Parse(linea);

            Console.WriteLine("Ingresa la cantidad de papas: ");
            linea = Console.ReadLine();
            cantidadpapas = int.Parse(linea);

            Console.WriteLine("Ingresa la cantidad de bebidas: ");
            linea = Console.ReadLine();
            cantidadbebida = int.Parse(linea);

            //Calcular el total a pagar
            total = (cantidadburger * Precioburger) + (cantidadpapas * Preciopapas) + (cantidadbebida * Preciobebida);

            Console.WriteLine("El total a pagar es: " + total);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();






        }
    }
}
