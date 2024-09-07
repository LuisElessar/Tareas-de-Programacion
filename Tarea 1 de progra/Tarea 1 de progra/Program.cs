using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_de_progra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre de la persona:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad de la persona:");
            int edad = int.Parse(Console.ReadLine());

            Soldado soldado = new Soldado(nombre, edad);

            soldado.EvaluarAptitud();

            Console.WriteLine("\nInformación del Soldado:");
            soldado.MostrarInformacion();
            Console.ReadLine();
        }
    }
}
