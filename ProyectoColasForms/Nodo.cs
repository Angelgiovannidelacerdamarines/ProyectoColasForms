namespace ProyectoColasForms
{
    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo? Siguiente { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }
}
