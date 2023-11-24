using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenxd.Clases
{
    public class ListaEnlazada
    {
        Nodo primerNodo;

        public bool ListaVacia()
        {
            return primerNodo == null ? true : false;
        }

        public void IngresarAlInicio(Perro perrito)
        {
            Nodo nodoNuevo = new Nodo(perrito);
            nodoNuevo.Siguiente = primerNodo;
            primerNodo = nodoNuevo;
        }

        public void IngresarAlMedio(Perro perrito, Nodo siguiente)
        {
            int contador = 0;

            Nodo nuevoNodo = new Nodo(perrito);
            nuevoNodo.Siguiente = siguiente;

            Nodo nodoActual = primerNodo;
            Nodo nodoAnterior = null;

            // Obtener longitud de la lista
            while (nodoActual != null)
            {
                contador++;
                nodoActual = nodoActual.Siguiente;
            }

            nodoActual = primerNodo;
            int longitud = contador / 2;
            int bucle = 0;

            // Llegar a la posición media de la lista
            while (bucle < longitud)
            {
                nodoAnterior = nodoActual;
                nodoActual = nodoActual.Siguiente;
                bucle++;
            }

            // Insertar el nuevo nodo entre el nodo anterior y el nodo actual
            nodoAnterior.Siguiente = nuevoNodo;
            nuevoNodo.Siguiente = nodoActual;
        }

        public void IngresarAlFinal(Perro perro)
        {
            Nodo nuevoNodo = new Nodo(perro);
            if (ListaVacia())
            {
                primerNodo = nuevoNodo;
                return;
            }

            
            Nodo actual = primerNodo;

            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            actual.Siguiente = nuevoNodo;

        }

        public void EliminarElemento(Perro perro)
        {
            if (ListaVacia())
            {
                Console.WriteLine("No existe ningun elemento");
                return;
            }

            while (primerNodo.Perrito != perro)
            {

                p

            }


        }





    }
}
