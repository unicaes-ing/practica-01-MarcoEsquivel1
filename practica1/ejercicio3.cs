using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class ejercicio3
    {
        public void ejer3()
        {
            decimal num1, num2, sum, res, mul, div;
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("El numero 1 es {0} y el 2 es {1}", num1, num2);
            sum = num1 + num2;
            res = num1 - num2;
            div = num1 / num2;
            mul = num1 * num2;
            Console.WriteLine();
            Console.WriteLine("El resultado de la suma es: " + sum);
            Console.WriteLine("El resultado de la resta es: " + res);
            Console.WriteLine("El resultado de la division es: " + div);
            Console.WriteLine("El resultado de la multiplicacion es: " + mul);
            Console.ReadKey();
        }
    }
}
