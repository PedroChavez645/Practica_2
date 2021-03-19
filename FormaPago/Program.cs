using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaPago
{
    class Program
    {
        static void Main(string[] args)
        {
            //Debe pedir el precio del producto
            Console.WriteLine("Escriba el precio del producto");
            double precio = Convert.ToDouble(Console.ReadLine());

            //Debere pedir la forma de pago
            Console.WriteLine("Escriba la forma de pago: Tarjeta o Efectivo");
            String formaPago = (Console.ReadLine()).ToLower();
            //Si es tarjeta debera pedir el numero de tarjeta
            if(formaPago.Equals("tarjeta"))
            {
                Console.WriteLine("introduce tu numero de tarjeta");
                int num_tarjeta = Convert.ToInt32(Console.ReadLine());
                //Imprimir un mensaje "El producto con precio
                //<Precio> se ha pagado con el numero  de cuenta <numCuenta>
                Console.WriteLine("El prodcuto con precio " + precio + " se ha pagado con el numero de tarjeta " + num_tarjeta);
            }
            else if(formaPago.Equals("efectivo"))
            {
                //si el pago es en efectivo imprimira El producto con precio <precio> se ha pagado
                Console.WriteLine("El producto con precio " + precio + " se ha pagado");
            }
            else
            {
                //si elige diferente imprimir "No es un metodo correcto de pago"
                Console.WriteLine("No es un metodo correcto de pago");

            }
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
