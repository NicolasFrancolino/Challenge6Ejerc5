using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6Ejerc5
{
    class Pilas<T>
    {
        public Stack<T> pila = new Stack<T>();

        public void Apilar(T objeto)
        {
            pila.Push(objeto);
        }

        public T Desapilar()
        {
            return pila.Pop();
        }


        public void MostrarPila()
        {
            foreach (T objeto in pila)
            {
                Console.WriteLine(objeto);
            }
            
        }
    }
}
