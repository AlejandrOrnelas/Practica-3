using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligonos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int CantLados;
            double tamanoLado, perimetro;
            String entrada;

            //Pedir el numero de lados
            Console.WriteLine("Dame la cantidad de lados a desear");
            CantLados = Convert.ToInt32(Console.ReadLine());

            //Pedir la medida de uno de los lados
            Console.WriteLine("Dame la medida de unode los lados deseados");
            entrada = Console.ReadLine();
            tamanoLado = Convert.ToDouble(Console.ReadLine());

            //Calcular el perimetro 
            perimetro = CantLados * tamanoLado;

            //Mostramos el resultado
            Console.WriteLine("El permietro que da como resultado es: {0}, perimetro", perimetro);
        }
    }
}
