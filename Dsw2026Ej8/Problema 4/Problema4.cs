using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_4
{
    internal class Problema4
    {
        public double CalcularPromedio(int? a, int? b, int? c)
        {
            //Mi iterpretación de este enunciado es que si hay valores que
            //son null o que hay que ignorar, entonces la cantidad de elementos
            //a tener en cuenta para el promedio disminuye, por ej. si hay c es
            //null o hay que ignorar (esta fuera de rango c < 0 ^ c > 10)
            //entonces el promedio quedaría (a+b)/2.

            double promedio = 0;
            int cantidad = (a == null ? 0 : 1) + (b == null ? 0 : 1) + (c == null ? 0 : 1); 

            a ??= 0;
            b ??= 0;
            c ??= 0;

            if(a < 0 || a > 10)
            {
                a = 0;
                cantidad -= 1;
            }
            if (b < 0 || b > 10)
            {
                b = 0;
                cantidad -= 1;
            }
            if (c < 0 || c > 10)
            {
                c = 0;
                cantidad -= 1;
            }

            promedio = (double)(a + b + c) / cantidad;

            return promedio;
        }


    }
}
