using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_en_clase_06_09_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string opcion = SeleccionarFigura();

                if (opcion == "5")
                {
                    Console.WriteLine("Programa terminado.");
                    break;
                }

                Figura figura = CrearFigura(opcion);

                if (figura != null)
                {
                    Console.WriteLine($"El área de la figura seleccionada es: {figura.CalcularArea()}");
                }
                else
                {
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                }
            }
        }

        static string SeleccionarFigura()
        {
            Console.WriteLine("Seleccione una figura:");
            Console.WriteLine("1. Rectángulo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Círculo");
            Console.WriteLine("4. Triángulo");
            Console.WriteLine("5. Salir");
            Console.Write("Ingrese el número de la opción: ");
            return Console.ReadLine();
        }

        static Figura CrearFigura(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la base del rectángulo: ");
                    float largo = float.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del rectángulo: ");
                    float ancho = float.Parse(Console.ReadLine());
                    return new Rectángulo(largo, ancho);

                case "2":
                    Console.Write("Ingrese el lado del cuadrado: ");
                    float lado = float.Parse(Console.ReadLine());
                    return new Cuadrado(lado);

                case "3":
                    Console.Write("Ingrese el radio del círculo: ");
                    float radio = float.Parse(Console.ReadLine());
                    return new Círculo(radio);

                case "4":
                    Console.Write("Ingrese la base del triángulo: ");
                    float Base = float.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    float altura = float.Parse(Console.ReadLine());
                    return new Triángulo(Base, altura);

                default:
                    return null;
            }
        }
    }
    }

