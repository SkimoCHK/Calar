using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenxd.Clases
{
    public class Nodo
    {
        public Perro Perrito;
        public Nodo Siguiente;

        public Nodo(Perro perrito)
        {
            Perrito = perrito;
            Siguiente = null;
        }

        public Nodo (Perro perrito, Nodo siguiente)
        {
            Perrito = perrito;
            Siguiente = siguiente;
        }
    }
}
