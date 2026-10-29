namespace ProyectoColasForms
{
    public partial class Form1 : Form
    {
        private ICola cola = null!;
        private string tituloCola = "";

        public Form1()
        {
            InitializeComponent();

            cmbTipo.SelectedIndex = 0;
            numCapacidad.Value = 5;
            CrearCola();
        }

        // ---------- CREACIÓN DE LA COLA ----------

        private void cmbTipo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Solo la cola estática y la circular usan capacidad fija
            bool usaCapacidad = cmbTipo.SelectedIndex == 0 || cmbTipo.SelectedIndex == 2;
            numCapacidad.Enabled = usaCapacidad;
            lblCapacidadCrear.Enabled = usaCapacidad;
        }

        private void btnCrear_Click(object? sender, EventArgs e)
        {
            CrearCola();
        }

        private void CrearCola()
        {
            int capacidad = (int)numCapacidad.Value;

            switch (cmbTipo.SelectedIndex)
            {
                case 0:
                    tituloCola = "COLA ESTÁTICA";
                    cola = new ColaEstatica(capacidad);
                    break;
                case 1:
                    tituloCola = "COLA DINÁMICA";
                    cola = new ColaDinamica();
                    break;
                case 2:
                    tituloCola = "COLA CIRCULAR";
                    cola = new ColaCircular(capacidad);
                    break;
                default:
                    tituloCola = "COLA DE PRIORIDAD";
                    cola = new ColaPrioridad();
                    break;
            }

            bool esPrioridad = cola is IColaPrioridad;
            txtPrioridad.Enabled = esPrioridad;
            lblPrioridad.Enabled = esPrioridad;
            lblAyudaPrioridad.Enabled = esPrioridad;

            string detalle = cola.Capacity() < 0 ? "capacidad ilimitada" : $"capacidad {cola.Capacity()}";
            lblActiva.Text = $"Cola activa: {tituloCola} ({detalle})";

            Log($"Se creó una {tituloCola} nueva ({detalle}).", Color.DimGray);
            Refrescar();
            txtValor.Focus();
        }

        // ---------- OPERACIONES ----------

        private void btnEnqueue_Click(object? sender, EventArgs e)
        {
            if (!LeerEntero(txtValor, "Valor", out int valor)) return;

            if (cola is IColaPrioridad cp)
            {
                if (!LeerEntero(txtPrioridad, "Prioridad", out int prio)) return;

                Ejecutar(() =>
                {
                    cp.Enqueue(valor, prio);
                    Log($"Encolado {valor} con prioridad {prio}.");
                });
            }
            else
            {
                Ejecutar(() =>
                {
                    cola.Enqueue(valor);
                    Log($"Encolado {valor}.");
                });
            }

            txtValor.Clear();
            txtValor.Focus();
        }

        private void btnDequeue_Click(object? sender, EventArgs e)
        {
            Ejecutar(() => Log($"Elemento atendido: {cola.Dequeue()}"));
        }

        private void btnPeek_Click(object? sender, EventArgs e)
        {
            Ejecutar(() => Log($"[FRONT]: {cola.Peek()}"));
        }

        private void btnRear_Click(object? sender, EventArgs e)
        {
            Ejecutar(() => Log($"[REAR]: {cola.Rear()}"));
        }

        private void btnIsEmpty_Click(object? sender, EventArgs e)
        {
            Ejecutar(() => Log($"¿Vacía?: {(cola.IsEmpty() ? "Sí" : "No")}"));
        }

        private void btnIsFull_Click(object? sender, EventArgs e)
        {
            Ejecutar(() => Log($"¿Llena?: {(cola.IsFull() ? "Sí" : "No")}"));
        }

        private void btnSize_Click(object? sender, EventArgs e)
        {
            Ejecutar(() => Log($"Size: {cola.Size()}"));
        }

        private void btnCapacity_Click(object? sender, EventArgs e)
        {
            Ejecutar(() =>
            {
                int cap = cola.Capacity();
                Log($"Capacity: {(cap < 0 ? "Ilimitada" : cap.ToString())}");
            });
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            if (!LeerEntero(txtBuscar, "Valor a buscar", out int buscado)) return;

            Ejecutar(() =>
            {
                int pos = cola.Search(buscado);
                Log(pos > 0
                    ? $"Valor {buscado} encontrado en la posición {pos} desde el frente."
                    : $"El valor {buscado} no está en la cola.");
            });
        }

        private void btnVaciar_Click(object? sender, EventArgs e)
        {
            Ejecutar(() =>
            {
                cola.Clear();
                Log("Cola vaciada.");
            });
        }

        private void btnLimpiarLog_Click(object? sender, EventArgs e)
        {
            rtbLog.Clear();
        }

        // Enter encola en las cajas de valor/prioridad y busca en la caja de búsqueda
        private void txtBuscar_Enter(object? sender, EventArgs e)
        {
            AcceptButton = btnBuscar;
        }

        private void txtBuscar_Leave(object? sender, EventArgs e)
        {
            AcceptButton = btnEnqueue;
        }

        // ---------- UTILIDADES ----------

        // Ejecuta una operación de la cola mostrando el error (underflow/overflow) en rojo si ocurre
        private void Ejecutar(Action accion)
        {
            try
            {
                accion();
            }
            catch (InvalidOperationException ex)
            {
                Log($"[ERROR] {ex.Message}", Color.Firebrick);
            }

            Refrescar();
        }

        private void Refrescar()
        {
            txtVista.Text = cola.Representar();
        }

        private bool LeerEntero(TextBox caja, string nombre, out int valor)
        {
            if (int.TryParse(caja.Text.Trim(), out valor)) return true;

            Log($"[ERROR] {nombre}: se esperaba un número entero.", Color.Firebrick);
            caja.Focus();
            caja.SelectAll();
            return false;
        }

        private void Log(string mensaje, Color? color = null)
        {
            rtbLog.SelectionStart = rtbLog.TextLength;
            rtbLog.SelectionLength = 0;
            rtbLog.SelectionColor = color ?? rtbLog.ForeColor;
            rtbLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {mensaje}{Environment.NewLine}");
            rtbLog.SelectionColor = rtbLog.ForeColor;
            rtbLog.ScrollToCaret();
        }
    }
}
