using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class ejercicio2
    {
        public void ejer2()
        {
            string nombre, cargo, correo, fechaContratacion;
            int edad;
            decimal sueldo;
            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el cargo del empleado");
            cargo = Console.ReadLine();
            Console.WriteLine("Ingrese el correo del empleado");
            correo = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del empleado");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de contratacion del empleado");
            fechaContratacion = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado");
            sueldo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Empleado: " + nombre);
            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("Correo: " + correo);
            Console.WriteLine("Fecha de contratacion: " + fechaContratacion);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("sueldo: $" + nombre);
            Console.ReadKey();
        }
    }
}
