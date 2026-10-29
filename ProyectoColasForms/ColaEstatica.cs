using ProyectoColasForms;
using System;
using System.Text;

namespace ProyectoColasForms
{
    public class ColaEstatica : ICola
    {
        private readonly int[] elementos;
        private int final;
        private readonly int capacidad;
        private int contador;

        public ColaEstatica(int tamano)
        {
            capacidad = tamano;
            elementos = new int[capacidad];
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
                throw new InvalidOperationException("La cola está LLENA (overflow).");

            final++;
            elementos[final] = valor;
            contador++;
        }

        // El frente siempre está en el índice 0 (se desplaza a la izquierda)
        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La cola está VACÍA (underflow).");

            int valorDesencolado = elementos[0];

            for (int i = 0; i < final; i++)
                elementos[i] = elementos[i + 1];

            final--;
            contador--;
            return valorDesencolado;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La cola está VACÍA.");
            return elementos[0];
        }

        public int Front() => Peek();

        public int Rear()
        {
            if (IsEmpty())
                throw new InvalidOperationException("La cola está VACÍA.");
            return elementos[final];
        }

        // Posición 1..n desde el frente, o -1 si no existe
        public int Search(int valor)
        {
            for (int i = 0; i <= final; i++)
            {
                if (elementos[i] == valor)
                    return i + 1;
            }
            return -1;
        }

        public void Clear()
        {
            final = -1;
            contador = 0;
        }

        public string Representar()
        {
            var sb = new StringBuilder();
            sb.AppendLine("================ REPRESENTACIÓN VISUAL DE LA COLA ================");

            if (IsEmpty())
            {
                sb.AppendLine("   [ COLA VACÍA ]");
                sb.AppendLine("==================================================================");
                return sb.ToString();
            }

            sb.Append("  FRONT (Frente) --> ");
            for (int i = 0; i <= final; i++)
                sb.Append($"[ {elementos[i]} ] ");
            sb.AppendLine("<-- REAR (Último)");

            sb.AppendLine();
            sb.AppendLine($"  Capacidad total: {Capacity()} | Elementos actuales: {Size()}");
            sb.AppendLine("==================================================================");
            return sb.ToString();
        }
    }
}