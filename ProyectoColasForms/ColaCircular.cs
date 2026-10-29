using ProyectoColasForms;
using System;

namespace ProyectoColasForms
{
    public class ColaCircular : ICola
    {
        private readonly int[] elementos;
        private int frente;
        private int final;
        private readonly int capacidad;
        private int contador;

        public ColaCircular(int tamano)
        {
            capacidad = tamano;
            elementos = new int[capacidad];
            frente = 0;
            final = -1;
            contador = 0;
        }

        public bool IsEmpty() => contador == 0;
        public bool IsFull() => contador == capacidad;
        public int Size() => contador;
        public int Capacity() => capacidad;

        public void Enqueue(int valor)
        {
            if (IsFull())
                throw new InvalidOperationException("La cola circular está LLENA (overflow).");

            final = (final + 1) % capacidad;
            elementos[final] = valor;
            contador++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La cola circular está VACÍA (underflow).");

            int valorDesencolado = elementos[frente];
            frente = (frente + 1) % capacidad;
            contador--;
            return valorDesencolado;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La cola circular está VACÍA.");
            return elementos[frente];
        }

        public int Front() => Peek();

        public int Rear()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La cola circular está VACÍA.");
            return elementos[final];
        }

        // Posición lógica 1..n desde el frente, o -1
        public int Search(int valor)
        {
            for (int i = 0; i < contador; i++)
            {
                int idx = (frente + i) % capacidad;
                if (elementos[idx] == valor)
                    return i + 1;
            }
            return -1;
        }

        public void Clear()
        {
            frente = 0;
            final = -1;
            contador = 0;
        }

        public void Display()
        {
            Console.WriteLine("\n================ REPRESENTACIÓN VISUAL: COLA CIRCULAR ================");

            if (IsEmpty())
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("   [ COLA CIRCULAR VACÍA ]");
                Console.ResetColor();
                Console.WriteLine("=======================================================================");
                return;
            }

            Console.Write("  Arreglo Físico: ");
            for (int i = 0; i < capacidad; i++)
            {
                // Un índice está ocupado si su distancia al frente (circular) es menor que 'contador'
                bool ocupado = ((i - frente + capacidad) % capacidad) < contador;

                Console.ForegroundColor = ocupado ? ConsoleColor.Cyan : ConsoleColor.DarkGray;
                Console.Write(ocupado ? $"[{i}: {elementos[i]}] " : $"[{i}: --] ");
                Console.ResetColor();
            }

            Console.WriteLine($"\n\n  Puntero FRENTE: Índice [{frente}] | Puntero FINAL: Índice [{final}]");
            Console.WriteLine($"  Elementos activos: {Size()} / Capacidad: {Capacity()}");
            Console.WriteLine("=======================================================================\n");
        }
    }
}
