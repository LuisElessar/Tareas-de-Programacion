using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_en_clase_06_09_2024
{
   class Círculo : Figura
    {
        private float radio;
        public Círculo(float radio)
        {
            this.radio = radio;
        }
        public override float CalcularArea()
        {
            return radio * radio * 3.14f;
        }
    }
}
