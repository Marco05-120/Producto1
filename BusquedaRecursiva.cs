using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto1
{
    internal class BusquedaRecursiva
    {
        public static Estudiante BuscarPorId(Estudiante[] estudiantes, int id, int index = 0)
        {
            if (index >= estudiantes.Length || estudiantes[index] == null)
                return null; // No encontrado

            if (estudiantes[index].Id == id)
                return estudiantes[index];

            return BuscarPorId(estudiantes, id, index + 1);
        }
    }
}
