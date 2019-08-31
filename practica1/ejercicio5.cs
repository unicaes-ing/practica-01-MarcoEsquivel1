using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class ejercicio5
    {
        public void ejer5()
        {
            decimal iss, renta, afp, sueldo;
            string nombre;
            iss = 0.925m;
            renta = 0.90m;
            afp = 0.9275m;
            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado");
            sueldo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Empleado: {0}", nombre);
            Console.WriteLine("Sueldo bruto: {0}", sueldo.ToString("c2"));
            sueldo = sueldo * iss * renta * afp;
            Console.WriteLine("Nuevo sueldo: {0}", sueldo.ToString("c2"));
            Console.ReadKey();
        }
    }
}
