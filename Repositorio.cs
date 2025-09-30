using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto1
{
    internal class Repositorio<T>
    {
        private T[] elementos; 
        private int contador;

        public Repositorio(int capacidad)
        {
            elementos = new T[capacidad];
            contador = 0;
        }
        public bool Agregar(T item)
        {
            if (contador < elementos.Length)
            {
                elementos[contador] = item;
                contador++;
                return true;
            }
            return false; // No hay espacio
        }
        public bool Eliminar(int index)
        {
            if (index >= 0 && index < contador)
            {
                for (int i = index; i < contador - 1; i++)
                {
                    elementos[i] = elementos[i + 1];
                }
                contador--;
                return true;
            }
            return false;
        }

        public T[] Listar()
        {
            T[] lista = new T[contador];
            Array.Copy(elementos, lista, contador);
            return lista;
        }
        public T Obtener(int index)
        {
            if (index >= 0 && index < contador)
                return elementos[index];
            return default(T);
        }

        // Cantidad actual
        public int Count => contador;

        // Capacidad máxima
        public int Capacidad => elementos.Length;
    }
}
