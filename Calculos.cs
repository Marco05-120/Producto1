using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto1
{
    internal class Calculos
    {
        public static double Promedio(Estudiante[] estudiantes)
        {
            double suma = 0;
            int count = 0;

            foreach (var e in estudiantes)
            {
                if (e != null)
                {
                    suma += e.Calificacion;
                    count++;
                }
            }

            return count > 0 ? suma / count : 0;
        }
    }
}
