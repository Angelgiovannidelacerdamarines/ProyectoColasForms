namespace ProyectoColasForms
{
    public interface ICola
    {
        void Enqueue(int valor);
        int Dequeue();          // lanza InvalidOperationException si está vacía
        int Peek();             // lanza InvalidOperationException si está vacía
        int Rear();             // lanza InvalidOperationException si está vacía
        bool IsEmpty();
        bool IsFull();
        int Size();
        int Capacity();         // -1 = ilimitada (cola dinámica)
        int Search(int valor);  // posición desde el frente (1..n) o -1
        void Clear();
        string Representar();   // representación visual en texto (la muestra el formulario)
    }

    public interface IColaPrioridad : ICola
    {
        void Enqueue(int valor, int prioridad);
    }
}