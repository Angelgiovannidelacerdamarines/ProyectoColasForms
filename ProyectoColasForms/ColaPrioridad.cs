using System;

namespace ProyectoColasForms
{
    public class ColaPrioridad : IColaPrioridad
    {
        // Nodo interno: no depende de NodoPrioridad.cs
        private class NodoP
        {
            public int Valor;
            public int Prioridad;
            public NodoP? Siguiente;

            public NodoP(int valor, int prioridad)
            {
                Valor = valor;
                Prioridad = prioridad;
            }
        }

        private NodoP? frente;
        private NodoP? final;
        private int contador;

        public bool IsEmpty() => frente == null;
        public bool IsFull() => false;
        public int Size() => contador;
        public int Capacity() => -1; // ilimitada

        // Prioridad por defecto (1 = baja) cuando no se especifica
        public void Enqueue(int valor) => Enqueue(valor, 1);

        // Mayor número = mayor prioridad. A igual prioridad, se respeta el orden de llegada (FIFO).
        public void Enqueue(int valor, int prioridad)
        {
            NodoP nuevo = new NodoP(valor, prioridad);

            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else if (prioridad > frente.Prioridad)
            {
                // Tiene más prioridad que todos: pasa al frente
                nuevo.Siguiente = frente;
                frente = nuevo;
            }
            else
            {
                // Avanza mientras los siguientes tengan prioridad >= a la nueva
                NodoP actual = frente;
                while (actual.Siguiente != null && actual.Siguiente.Prioridad >= prioridad)
                    actual = actual.Siguiente;

                nuevo.Siguiente = actual.Siguiente;
                actual.Siguiente = nuevo;

                if (nuevo.Siguiente == null)
                    final = nuevo;
            }

            contador++;
        }

        public int Dequeue()
        {
            if (frente == null)
                throw new InvalidOperationException("La cola de prioridad está VACÍA (underflow).");

            int valor = frente.Valor;
            frente = frente.Siguiente;

            if (frente == null)
                final = null;

            contador--;
            return valor;
        }

        public int Peek()
        {
            if (frente == null)
                throw new InvalidOperationException("La cola de prioridad está VACÍA.");
            return frente.Valor;
        }

        public int Front() => Peek();

        public int Rear()
        {
            if (final == null)
                throw new InvalidOperationException("La cola de prioridad está VACÍA.");
            return final.Valor;
        }

        // Posición 1..n desde el frente, o -1
        public int Search(int valor)
        {
            NodoP? actual = frente;
            int posicion = 1;

            while (actual != null)
            {
                if (actual.Valor == valor)
                    return posicion;
                actual = actual.Siguiente;
                posicion++;
            }
            return -1;
        }

        public void Clear()
        {
            frente = null;
            final = null;
            contador = 0;
        }

        public void Display()
        {
            Console.WriteLine("\n============= REPRESENTACIÓN VISUAL: COLA DE PRIORIDAD =============");

            if (IsEmpty())
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("   [ COLA DE PRIORIDAD VACÍA ]");
                Console.ResetColor();
                Console.WriteLine("====================================================================");
                return;
            }

            Console.Write("  FRONT -> ");
            NodoP? actual = frente;
            while (actual != null)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"[ {actual.Valor} | P:{actual.Prioridad} ]");
                Console.ResetColor();

                if (actual.Siguiente != null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(" ---> ");
                    Console.ResetColor();
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine(" <- REAR");

            Console.WriteLine($"\n  Elementos: {Size()} | Capacidad: Ilimitada | Mayor número = mayor prioridad");
            Console.WriteLine("====================================================================\n");
        }
    }
}