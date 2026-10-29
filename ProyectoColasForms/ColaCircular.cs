using ProyectoColasForms;
using System;
using System.Text;

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

        public string Representar()
        {
            var sb = new StringBuilder();
            sb.AppendLine("================ REPRESENTACIÓN VISUAL: COLA CIRCULAR ================");

            if (IsEmpty())
            {
                sb.AppendLine("   [ COLA CIRCULAR VACÍA ]");
                sb.AppendLine("=======================================================================");
                return sb.ToString();
            }

            sb.Append("  Arreglo Físico: ");
            for (int i = 0; i < capacidad; i++)
            {
                // Un índice está ocupado si su distancia al frente (circular) es menor que 'contador'
                bool ocupado = ((i - frente + capacidad) % capacidad) < contador;

                sb.Append(ocupado ? $"[{i}: {elementos[i]}] " : $"[{i}: --] ");
            }

            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine($"  Puntero FRENTE: Índice [{frente}] | Puntero FINAL: Índice [{final}]");
            sb.AppendLine($"  Elementos activos: {Size()} / Capacidad: {Capacity()}");
            sb.AppendLine("=======================================================================");
            return sb.ToString();
        }
    }
}
