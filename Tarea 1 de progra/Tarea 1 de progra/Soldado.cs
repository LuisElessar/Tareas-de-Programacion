using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_de_progra
{
    public class Soldado : Persona
    {
        public bool Apto { get; set; }

        public Soldado(string nombre, int edad) : base(nombre, edad) { }

        public void EvaluarAptitud()
        {
            if (Edad >= 18 && Edad <= 40)
            {
                Apto = true;
                Console.WriteLine($"{Nombre} es apto para enlistarse en el ejército.");
            }
            else
            {
                Apto = false;
                Console.WriteLine($"{Nombre} no es apto para enlistarse en el ejército.");
            }
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Apto: {(Apto ? "Sí" : "No")}");
        }
    }
}
