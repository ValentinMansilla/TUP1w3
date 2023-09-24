namespace Transporte_Clase_1.Vistas
{
    partial class frmNuevoViaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            cboCarga = new ComboBox();
            label1 = new Label();
            txtCantidad = new TextBox();
            dgvDetalles = new DataGridView();
            colIdCamion = new DataGridViewTextBoxColumn();
            colTipoCarga = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPeso = new DataGridViewTextBoxColumn();
            colQuitar = new DataGridViewButtonColumn();
            lblTipoDeCarga = new Label();
            label6 = new Label();
            btnSalir = new Button();
            lblCamión = new Label();
            label5 = new Label();
            lblEstado = new Label();
            chkReparacion = new CheckBox();
            txtPatente = new TextBox();
            chkActivo = new CheckBox();
            cboCamion = new ComboBox();
            txtPeso = new TextBox();
            lblTotal = new Label();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(813, 225);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cboCarga
            // 
            cboCarga.FormattingEnabled = true;
            cboCarga.Location = new Point(199, 169);
            cboCarga.Name = "cboCarga";
            cboCarga.Size = new Size(264, 33);
            cboCarga.TabIndex = 2;
            cboCarga.SelectedIndexChanged += cboCarga_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(591, 618);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 3;
            label1.Text = "kg";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtCantidad.Location = new Point(491, 172);
            txtCantidad.MaxLength = 10;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(150, 28);
            txtCantidad.TabIndex = 4;
            txtCantidad.Text = "Cantidad";
            txtCantidad.TextAlign = HorizontalAlignment.Center;
            txtCantidad.Click += txtCantidad_Click;
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { colIdCamion, colTipoCarga, colCantidad, colPeso, colQuitar });
            dgvDetalles.Location = new Point(47, 225);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowHeadersWidth = 62;
            dgvDetalles.RowTemplate.Height = 33;
            dgvDetalles.Size = new Size(745, 343);
            dgvDetalles.TabIndex = 5;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick;
            // 
            // colIdCamion
            // 
            colIdCamion.HeaderText = "";
            colIdCamion.MinimumWidth = 8;
            colIdCamion.Name = "colIdCamion";
            colIdCamion.ReadOnly = true;
            colIdCamion.Visible = false;
            colIdCamion.Width = 75;
            // 
            // colTipoCarga
            // 
            colTipoCarga.HeaderText = "Carga";
            colTipoCarga.MinimumWidth = 8;
            colTipoCarga.Name = "colTipoCarga";
            colTipoCarga.ReadOnly = true;
            colTipoCarga.Width = 200;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 8;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 150;
            // 
            // colPeso
            // 
            colPeso.HeaderText = "Peso";
            colPeso.MinimumWidth = 8;
            colPeso.Name = "colPeso";
            colPeso.ReadOnly = true;
            colPeso.Width = 150;
            // 
            // colQuitar
            // 
            colQuitar.HeaderText = "Quitar";
            colQuitar.MinimumWidth = 8;
            colQuitar.Name = "colQuitar";
            colQuitar.ReadOnly = true;
            colQuitar.Width = 175;
            // 
            // lblTipoDeCarga
            // 
            lblTipoDeCarga.AutoSize = true;
            lblTipoDeCarga.Location = new Point(47, 177);
            lblTipoDeCarga.Name = "lblTipoDeCarga";
            lblTipoDeCarga.Size = new Size(132, 25);
            lblTipoDeCarga.TabIndex = 3;
            lblTipoDeCarga.Text = "Tipo de Carga: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(317, 618);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 3;
            label6.Text = "Carga total:";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(813, 534);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCamión
            // 
            lblCamión.AutoSize = true;
            lblCamión.Location = new Point(47, 28);
            lblCamión.Name = "lblCamión";
            lblCamión.Size = new Size(82, 25);
            lblCamión.TabIndex = 3;
            lblCamión.Text = "Camión: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 70);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 3;
            label5.Text = "Patente: ";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(47, 117);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(75, 25);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado: ";
            // 
            // chkReparacion
            // 
            chkReparacion.AutoSize = true;
            chkReparacion.Location = new Point(293, 115);
            chkReparacion.Name = "chkReparacion";
            chkReparacion.Size = new Size(125, 29);
            chkReparacion.TabIndex = 1;
            chkReparacion.Text = "Reparación";
            chkReparacion.UseVisualStyleBackColor = true;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(199, 67);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(131, 31);
            txtPatente.TabIndex = 4;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(199, 115);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(88, 29);
            chkActivo.TabIndex = 1;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // cboCamion
            // 
            cboCamion.FormattingEnabled = true;
            cboCamion.Location = new Point(199, 28);
            cboCamion.Name = "cboCamion";
            cboCamion.Size = new Size(264, 33);
            cboCamion.TabIndex = 2;
            cboCamion.SelectedIndexChanged += cboCamion_SelectedIndexChanged;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtPeso.Location = new Point(670, 172);
            txtPeso.MaxLength = 10;
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(122, 28);
            txtPeso.TabIndex = 4;
            txtPeso.Text = "Peso";
            txtPeso.TextAlign = HorizontalAlignment.Center;
            txtPeso.Click += txtPeso_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(426, 611);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(31, 33);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "0";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(813, 479);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmNuevoViaje
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 655);
            ControlBox = false;
            Controls.Add(lblTotal);
            Controls.Add(dgvDetalles);
            Controls.Add(txtPatente);
            Controls.Add(txtPeso);
            Controls.Add(txtCantidad);
            Controls.Add(lblCamión);
            Controls.Add(label5);
            Controls.Add(lblTipoDeCarga);
            Controls.Add(lblEstado);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(cboCamion);
            Controls.Add(cboCarga);
            Controls.Add(chkReparacion);
            Controls.Add(chkActivo);
            Controls.Add(btnAceptar);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Name = "frmNuevoViaje";
            Text = "Nuevo Viaje";
            Load += frmNuevoViaje_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private ComboBox cboCarga;
        private Label label1;
        private TextBox txtCantidad;
        private DataGridView dgvDetalles;
        private Label lblTipoDeCarga;
        private Label label6;
        private Button btnSalir;
        private Label lblCamión;
        private Label label5;
        private Label lblEstado;
        private CheckBox chkReparacion;
        private TextBox txtPatente;
        private CheckBox chkActivo;
        private ComboBox cboCamion;
        private DataGridViewTextBoxColumn colIdCamion;
        private DataGridViewTextBoxColumn colTipoCarga;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPeso;
        private DataGridViewButtonColumn colQuitar;
        private TextBox txtPeso;
        private Label lblTotal;
        private Button btnAceptar;
    }
}