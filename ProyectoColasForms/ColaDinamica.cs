using ProyectoColasForms;
using System;

namespace ProyectoColasForms
{
    public class ColaDinamica : ICola
    {
        private Nodo? frente;
        private Nodo? final;
        private int contador;

        public ColaDinamica()
        {
            frente = null;
            final = null;
            contador = 0;
        }

        public bool IsEmpty() => frente == null;
        public bool IsFull() => false;          // limitada solo por la RAM
        public int Size() => contador;
        public int Capacity() => -1;            // -1 = ilimitada

        public void Enqueue(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);

            if (final == null)
            {
                frente = nuevoNodo;
                final = nuevoNodo;
            }
            else
            {
                final.Siguiente = nuevoNodo;
                final = nuevoNodo;
            }

            contador++;
        }

        public int Dequeue()
        {
            if (frente == null)
                throw new InvalidOperationException("La cola está VACÍA (underflow).");

            int valorDesencolado = frente.Valor;
            frente = frente.Siguiente;

            if (frente == null)
                final = null;

            contador--;
            return valorDesencolado;
        }

        public int Peek()
        {
            if (frente == null)
                throw new InvalidOperationException("La cola está VACÍA.");
            return frente.Valor;
        }

        public int Front() => Peek();

        public int Rear()
        {
            if (final == null)
                throw new InvalidOperationException("La cola está VACÍA.");
            return final.Valor;
        }

        // Posición 1..n desde el frente, o -1
        public int Search(int valor)
        {
            Nodo? actual = frente;
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
            Console.WriteLine("\n================ REPRESENTACIÓN VISUAL DE LA COLA DINÁMICA ================");

            if (IsEmpty())
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("   [ FRONT: null ] -> [ REAR: null ] (Cola Vacía)");
                Console.ResetColor();
                Console.WriteLine("==========================================================================");
                return;
            }

            Console.Write("  FRONT -> ");
            Nodo? actual = frente;
            while (actual != null)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"[ Nodo: {actual.Valor} ]");
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

            Console.WriteLine($"\n  Elementos en memoria: {Size()} | Capacidad: Ilimitada (memoria dinámica)");
            Console.WriteLine("==========================================================================\n");
        }
    }
}