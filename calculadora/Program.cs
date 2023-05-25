using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            char operador;

            //enviamos un mensaje de bienvenida
            Console.WriteLine("Bienvenido a nuestro programa");
            Console.WriteLine("Este programa permite operaciones basicas sobre dos numeros");
            Console.WriteLine("----------------");

            Console.WriteLine("Introduzca el primer valor");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo valor");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indique la operación (*,+,-,/)");
            operador = char.Parse(Console.ReadLine());
            /*Identifique el tipo de operación a realizar haciendo uso del condicional IF*/

            if (operador == '*')
            {
                Console.WriteLine("La multiplicación es de: " + (num1 * num2));

            }
            if (operador == '/')
            {
                Console.WriteLine("La división es de: " + (num1 / num2));
            }
            if (operador == '+')
            {
                Console.WriteLine("La Suma es de: " + (num1 + num2));
            }
            if (operador == '-') 
            {
                Console.WriteLine("La resta es de: " + (num1 - num2));
            }

            Console.ReadLine();
        }
    }
}
