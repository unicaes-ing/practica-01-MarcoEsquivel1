using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class ejercicio1
    {
        //Marco René Esquivel Juárez
        //10-Julio
        public void ejer1()
        {
            string nombre, especie;
            int edad;
            do
            {
                Console.WriteLine("Ingrese el nombre de su mascota: ");
                nombre = Console.ReadLine();
                Console.Clear();
            } while (nombre == "");
            do
            {
                Console.WriteLine("Ingrese la especie de su mascota: ");
                especie = Console.ReadLine();
                Console.Clear();
            } while (especie == "");
            do
            {
                Console.WriteLine("Ingrese la edad de su mascota: ");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (edad <= 0);

            Console.WriteLine("El nombre de la mascota es {0}, es de especie {1} y tiene una edad de {2} años", nombre, especie, edad);
            Console.ReadKey();
        }

    }
}
