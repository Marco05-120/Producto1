using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto1
{
    internal class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Calificacion { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Edad: {Edad}, Calificación: {Calificacion}";
        }
    }
}
