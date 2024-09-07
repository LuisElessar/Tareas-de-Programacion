using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_en_clase_06_09_2024
{
 class Triángulo:Figura
    {
        private float Base;
        private float altura;

        public Triángulo(float Base, float altura)
        {
            this.Base = Base;
            this.altura = altura;
        }
        public override float CalcularArea()
        {
            return Base * altura / 2;
        }
    }
}
