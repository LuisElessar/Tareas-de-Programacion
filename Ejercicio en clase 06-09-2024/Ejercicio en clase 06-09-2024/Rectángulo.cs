using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_en_clase_06_09_2024
{
class Rectángulo:Figura
    {
        private float ancho;
        private float largo;

        public Rectángulo(float ancho, float largo)
        {
            this.ancho = ancho;
            this.largo = largo;
        }
        public override float CalcularArea()
        {
            return ancho * largo;
        }
    }
}
