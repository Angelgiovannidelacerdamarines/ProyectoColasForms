#nullable disable

namespace ProyectoColasForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpConfig = new GroupBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            lblCapacidadCrear = new Label();
            numCapacidad = new NumericUpDown();
            btnCrear = new Button();
            lblActiva = new Label();
            txtVista = new TextBox();
            grpOperaciones = new GroupBox();
            lblValor = new Label();
            txtValor = new TextBox();
            lblPrioridad = new Label();
            txtPrioridad = new TextBox();
            lblAyudaPrioridad = new Label();
            btnEnqueue = new Button();
            btnDequeue = new Button();
            btnPeek = new Button();
            btnRear = new Button();
            btnIsEmpty = new Button();
            btnIsFull = new Button();
            btnSize = new Button();
            btnCapacity = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnVaciar = new Button();
            btnLimpiarLog = new Button();
            grpLog = new GroupBox();
            rtbLog = new RichTextBox();
            grpConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).BeginInit();
            grpOperaciones.SuspendLayout();
            grpLog.SuspendLayout();
            SuspendLayout();
            //
            // grpConfig
            //
            grpConfig.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpConfig.Controls.Add(lblTipo);
            grpConfig.Controls.Add(cmbTipo);
            grpConfig.Controls.Add(lblCapacidadCrear);
            grpConfig.Controls.Add(numCapacidad);
            grpConfig.Controls.Add(btnCrear);
            grpConfig.Location = new Point(12, 12);
            grpConfig.Name = "grpConfig";
            grpConfig.Size = new Size(876, 62);
            grpConfig.TabIndex = 0;
            grpConfig.TabStop = false;
            grpConfig.Text = "Configuración de la cola";
            //
            // lblTipo
            //
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(15, 28);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(77, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo de cola:";
            //
            // cmbTipo
            //
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] {
            "Cola Estática (arreglo fijo con desplazamiento)",
            "Cola Dinámica (nodos y referencias)",
            "Cola Circular (arreglo fijo, reutilización modular %)",
            "Cola de Prioridad (nodos ordenados por prioridad)"});
            cmbTipo.Location = new Point(100, 24);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(340, 23);
            cmbTipo.TabIndex = 1;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            //
            // lblCapacidadCrear
            //
            lblCapacidadCrear.AutoSize = true;
            lblCapacidadCrear.Location = new Point(460, 28);
            lblCapacidadCrear.Name = "lblCapacidadCrear";
            lblCapacidadCrear.Size = new Size(63, 15);
            lblCapacidadCrear.TabIndex = 2;
            lblCapacidadCrear.Text = "Capacidad:";
            //
            // numCapacidad
            //
            numCapacidad.Location = new Point(530, 24);
            numCapacidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCapacidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCapacidad.Name = "numCapacidad";
            numCapacidad.Size = new Size(70, 23);
            numCapacidad.TabIndex = 3;
            numCapacidad.Value = new decimal(new int[] { 5, 0, 0, 0 });
            //
            // btnCrear
            //
            btnCrear.Location = new Point(620, 22);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(150, 27);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear cola nueva";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            //
            // lblActiva
            //
            lblActiva.AutoSize = true;
            lblActiva.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblActiva.Location = new Point(12, 82);
            lblActiva.Name = "lblActiva";
            lblActiva.Size = new Size(94, 19);
            lblActiva.TabIndex = 1;
            lblActiva.Text = "Cola activa: -";
            //
            // txtVista
            //
            txtVista.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtVista.BackColor = Color.FromArgb(30, 30, 30);
            txtVista.Font = new Font("Consolas", 11F);
            txtVista.ForeColor = Color.FromArgb(120, 220, 255);
            txtVista.Location = new Point(12, 108);
            txtVista.Multiline = true;
            txtVista.Name = "txtVista";
            txtVista.ReadOnly = true;
            txtVista.ScrollBars = ScrollBars.Both;
            txtVista.Size = new Size(876, 190);
            txtVista.TabIndex = 2;
            txtVista.TabStop = false;
            txtVista.WordWrap = false;
            //
            // grpOperaciones
            //
            grpOperaciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpOperaciones.Controls.Add(lblValor);
            grpOperaciones.Controls.Add(txtValor);
            grpOperaciones.Controls.Add(lblPrioridad);
            grpOperaciones.Controls.Add(txtPrioridad);
            grpOperaciones.Controls.Add(lblAyudaPrioridad);
            grpOperaciones.Controls.Add(btnEnqueue);
            grpOperaciones.Controls.Add(btnDequeue);
            grpOperaciones.Controls.Add(btnPeek);
            grpOperaciones.Controls.Add(btnRear);
            grpOperaciones.Controls.Add(btnIsEmpty);
            grpOperaciones.Controls.Add(btnIsFull);
            grpOperaciones.Controls.Add(btnSize);
            grpOperaciones.Controls.Add(btnCapacity);
            grpOperaciones.Controls.Add(lblBuscar);
            grpOperaciones.Controls.Add(txtBuscar);
            grpOperaciones.Controls.Add(btnBuscar);
            grpOperaciones.Controls.Add(btnVaciar);
            grpOperaciones.Controls.Add(btnLimpiarLog);
            grpOperaciones.Location = new Point(12, 304);
            grpOperaciones.Name = "grpOperaciones";
            grpOperaciones.Size = new Size(876, 156);
            grpOperaciones.TabIndex = 3;
            grpOperaciones.TabStop = false;
            grpOperaciones.Text = "Operaciones";
            //
            // lblValor
            //
            lblValor.AutoSize = true;
            lblValor.Location = new Point(15, 32);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(73, 15);
            lblValor.TabIndex = 0;
            lblValor.Text = "Valor entero:";
            //
            // txtValor
            //
            txtValor.Location = new Point(100, 28);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(90, 23);
            txtValor.TabIndex = 1;
            //
            // lblPrioridad
            //
            lblPrioridad.AutoSize = true;
            lblPrioridad.Location = new Point(210, 32);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(58, 15);
            lblPrioridad.TabIndex = 2;
            lblPrioridad.Text = "Prioridad:";
            //
            // txtPrioridad
            //
            txtPrioridad.Location = new Point(275, 28);
            txtPrioridad.Name = "txtPrioridad";
            txtPrioridad.Size = new Size(60, 23);
            txtPrioridad.TabIndex = 2;
            txtPrioridad.Text = "1";
            //
            // lblAyudaPrioridad
            //
            lblAyudaPrioridad.AutoSize = true;
            lblAyudaPrioridad.ForeColor = Color.DimGray;
            lblAyudaPrioridad.Location = new Point(345, 32);
            lblAyudaPrioridad.Name = "lblAyudaPrioridad";
            lblAyudaPrioridad.Size = new Size(173, 15);
            lblAyudaPrioridad.TabIndex = 3;
            lblAyudaPrioridad.Text = "(1 = Baja, 5 = Media, 10 = Alta)";
            //
            // btnEnqueue
            //
            btnEnqueue.Location = new Point(590, 26);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(120, 27);
            btnEnqueue.TabIndex = 3;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            //
            // btnDequeue
            //
            btnDequeue.Location = new Point(720, 26);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(120, 27);
            btnDequeue.TabIndex = 4;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            //
            // btnPeek
            //
            btnPeek.Location = new Point(15, 68);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(120, 27);
            btnPeek.TabIndex = 5;
            btnPeek.Text = "Peek (Front)";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            //
            // btnRear
            //
            btnRear.Location = new Point(145, 68);
            btnRear.Name = "btnRear";
            btnRear.Size = new Size(120, 27);
            btnRear.TabIndex = 6;
            btnRear.Text = "Rear";
            btnRear.UseVisualStyleBackColor = true;
            btnRear.Click += btnRear_Click;
            //
            // btnIsEmpty
            //
            btnIsEmpty.Location = new Point(275, 68);
            btnIsEmpty.Name = "btnIsEmpty";
            btnIsEmpty.Size = new Size(120, 27);
            btnIsEmpty.TabIndex = 7;
            btnIsEmpty.Text = "IsEmpty";
            btnIsEmpty.UseVisualStyleBackColor = true;
            btnIsEmpty.Click += btnIsEmpty_Click;
            //
            // btnIsFull
            //
            btnIsFull.Location = new Point(405, 68);
            btnIsFull.Name = "btnIsFull";
            btnIsFull.Size = new Size(120, 27);
            btnIsFull.TabIndex = 8;
            btnIsFull.Text = "IsFull";
            btnIsFull.UseVisualStyleBackColor = true;
            btnIsFull.Click += btnIsFull_Click;
            //
            // btnSize
            //
            btnSize.Location = new Point(535, 68);
            btnSize.Name = "btnSize";
            btnSize.Size = new Size(120, 27);
            btnSize.TabIndex = 9;
            btnSize.Text = "Size";
            btnSize.UseVisualStyleBackColor = true;
            btnSize.Click += btnSize_Click;
            //
            // btnCapacity
            //
            btnCapacity.Location = new Point(665, 68);
            btnCapacity.Name = "btnCapacity";
            btnCapacity.Size = new Size(120, 27);
            btnCapacity.TabIndex = 10;
            btnCapacity.Text = "Capacity";
            btnCapacity.UseVisualStyleBackColor = true;
            btnCapacity.Click += btnCapacity_Click;
            //
            // lblBuscar
            //
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(15, 116);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(79, 15);
            lblBuscar.TabIndex = 11;
            lblBuscar.Text = "Buscar valor:";
            //
            // txtBuscar
            //
            txtBuscar.Location = new Point(100, 112);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(90, 23);
            txtBuscar.TabIndex = 12;
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            //
            // btnBuscar
            //
            btnBuscar.Location = new Point(205, 110);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 27);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Search";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            //
            // btnVaciar
            //
            btnVaciar.Location = new Point(590, 110);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(120, 27);
            btnVaciar.TabIndex = 14;
            btnVaciar.Text = "Vaciar cola";
            btnVaciar.UseVisualStyleBackColor = true;
            btnVaciar.Click += btnVaciar_Click;
            //
            // btnLimpiarLog
            //
            btnLimpiarLog.Location = new Point(720, 110);
            btnLimpiarLog.Name = "btnLimpiarLog";
            btnLimpiarLog.Size = new Size(120, 27);
            btnLimpiarLog.TabIndex = 15;
            btnLimpiarLog.Text = "Limpiar registro";
            btnLimpiarLog.UseVisualStyleBackColor = true;
            btnLimpiarLog.Click += btnLimpiarLog_Click;
            //
            // grpLog
            //
            grpLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpLog.Controls.Add(rtbLog);
            grpLog.Location = new Point(12, 466);
            grpLog.Name = "grpLog";
            grpLog.Size = new Size(876, 162);
            grpLog.TabIndex = 4;
            grpLog.TabStop = false;
            grpLog.Text = "Registro de operaciones";
            //
            // rtbLog
            //
            rtbLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbLog.BackColor = SystemColors.Window;
            rtbLog.Font = new Font("Consolas", 10F);
            rtbLog.Location = new Point(10, 22);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.Size = new Size(856, 130);
            rtbLog.TabIndex = 0;
            rtbLog.TabStop = false;
            rtbLog.Text = "";
            //
            // Form1
            //
            AcceptButton = btnEnqueue;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 640);
            Controls.Add(grpLog);
            Controls.Add(grpOperaciones);
            Controls.Add(txtVista);
            Controls.Add(lblActiva);
            Controls.Add(grpConfig);
            MinimumSize = new Size(916, 679);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema interactivo de estructuras de datos: Colas";
            grpConfig.ResumeLayout(false);
            grpConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();
            grpOperaciones.ResumeLayout(false);
            grpOperaciones.PerformLayout();
            grpLog.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpConfig;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private Label lblCapacidadCrear;
        private NumericUpDown numCapacidad;
        private Button btnCrear;
        private Label lblActiva;
        private TextBox txtVista;
        private GroupBox grpOperaciones;
        private Label lblValor;
        private TextBox txtValor;
        private Label lblPrioridad;
        private TextBox txtPrioridad;
        private Label lblAyudaPrioridad;
        private Button btnEnqueue;
        private Button btnDequeue;
        private Button btnPeek;
        private Button btnRear;
        private Button btnIsEmpty;
        private Button btnIsFull;
        private Button btnSize;
        private Button btnCapacity;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnVaciar;
        private Button btnLimpiarLog;
        private GroupBox grpLog;
        private RichTextBox rtbLog;
    }
}
