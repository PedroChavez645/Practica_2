using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mensaje de Bienvenida
            string orden;
            int cantidad;
            double total;
            const double normal = 2.00, desc1 = 1.75, desc2 = 1.5;
            Console.WriteLine(" Bienvenido a bazar Cat Shop ");
            Console.WriteLine(" 1 a  50  latas: $" + normal + "    c/u");
            Console.WriteLine(" 51 a 100  latas: $" + desc1 + " c/u");
            Console.WriteLine(" 101 o más  latas: $" + desc2 + "  c/u");
    

            //Pedir la cantidad de latas
            Console.WriteLine("Cuantas latas desea adquirir?");
            orden = Console.ReadLine();

            //Guardar en una variable la cantidad de latas
            cantidad = Convert.ToInt32(orden);

            //Hacer una operacion que multiplique la cantidad * precio de cada lata

            Console.WriteLine("---Ticket---");
            Console.WriteLine("        Cantidad        Precio        Total");

            if (cantidad < 51)
            {
                total = cantidad * normal;
                Console.WriteLine("        {0} latas        ${1}        =  $ {2}", cantidad, normal, total);
            }

            if (cantidad > 50 && cantidad < 101)
            {
                total = cantidad * desc1;
                Console.WriteLine("        {0} latas       ${1}        =  $ {2}", cantidad, desc1, total);
            }

            if (cantidad > 100)
            {
                total = cantidad * desc2;
                Console.WriteLine("        {0} latas       ${1}        =  $ {2}", cantidad, desc2, total);
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Preciona cualquier tecla para confirmar compra");
            Console.ReadKey();
        }
    }
}
