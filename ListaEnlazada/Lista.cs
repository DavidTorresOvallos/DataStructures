using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazada
{
    public class Lista
    {
        private Nodo cabeza;
        private int longitud;
        private class Nodo
        {
            public Libro libro = null;
            public Nodo siguiente;
            public Nodo(Libro libro)
            {
                this.libro = libro;
            }
        }

        public void InsertarPrincipio(Libro libro)
        {
            Nodo nodo = new Nodo(libro);
            nodo.siguiente = cabeza;
            cabeza = nodo;
            longitud++;
        }

        public void InsertarFinal(Libro libro)
        {
            Nodo nodo = new Nodo(libro);
            if(cabeza == null)
            {
                cabeza = nodo;
            }
            else
            {
                Nodo puntero = cabeza;
                while(puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = nodo;
            }
            longitud++;
        }

        public void InsertarDespues(int n, Libro libro)
        {
            Nodo nodo = new Nodo(libro);
            if(cabeza == null)
            {
                cabeza = nodo;
            }
            else
            {
                Nodo puntero = cabeza;
                int contador = 0;
                while(contador < n && puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    contador++;
                }
                nodo.siguiente = puntero.siguiente;
                puntero.siguiente = nodo;
            }
            longitud++;
        }

        public Libro Obtener(int n)
        {
            if(cabeza == null)
            {
                return null;
            }
            else
            {
                Nodo puntero = cabeza;
                int contador = 0;
                while(contador < n && puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    contador++;
                }
                if(contador != n)
                {
                    return null;
                }
                else
                {
                    return puntero.libro;
                }
            }
        }

        public int Contar()
        {
            return longitud;
        }

        public bool EstaVacia()
        {
            return cabeza != null;
        }

        public void EliminarPrincipio()
        {
            if(cabeza != null)
            {
                Nodo primer = cabeza;
                cabeza = cabeza.siguiente;
                primer.siguiente = null;
                longitud--;
            }
        }

        public void EliminarUltimo()
        {
            if(cabeza != null)
            {
                if(cabeza.siguiente == null)
                {
                    cabeza = null;
                }
                Nodo puntero = cabeza;
                while (puntero.siguiente.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = null;
                longitud--;
            }
        }

        public void EliminarLibro(int n)
        {
            if(cabeza != null)
            {
                if(n == 0)
                {
                    Nodo primer = cabeza;
                    cabeza = cabeza.siguiente;
                    primer.siguiente = null;
                    longitud--;
                }
                else if(n < longitud)
                {
                    Nodo puntero = cabeza;
                    int contador = 0;
                    while (contador < (n - 1))
                    {
                        puntero = puntero.siguiente;
                        contador++;
                    }
                }
                Nodo temp = puntero.siguiente;
                puntero.siguiente = temp.siguiente;
                temp.siguiente = null;
                longitud--:
            }
        }
    }
}
