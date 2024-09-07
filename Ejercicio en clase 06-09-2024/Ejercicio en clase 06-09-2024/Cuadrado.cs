using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_en_clase_06_09_2024
{
   class Cuadrado:Figura
    {
        private float lado;
        public Cuadrado(float lado)
        {
            this.lado = lado;
        }
        public override float CalcularArea()
        {
            return lado * lado;
        }
    }
}

