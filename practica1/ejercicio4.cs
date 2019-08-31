using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class ejercicio4
    {
        //Marco René Esquivel Juárez
        //10-Julio
        public void ejer4()
        {
            decimal trimestre1, trimestre2, trimestre3, promedio;
            Console.WriteLine("Ingrese las ventas del primer trimestre del año pasado");
            trimestre1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese las ventas del segundo trimestre del año pasado");
            trimestre2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese las ventas del trimestre trimestre del año pasado");
            trimestre3 = Convert.ToDecimal(Console.ReadLine());
            promedio = (trimestre1 + trimestre2 + trimestre3) / 3;
            Console.WriteLine("El promedio de ventas es : $" + promedio);
            Console.ReadKey();
        }
    }
}
