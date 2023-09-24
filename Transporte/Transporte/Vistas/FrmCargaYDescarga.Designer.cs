namespace Transporte.Vistas
{
    partial class FrmCargaYDescarga
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
            dgvTransporte = new DataGridView();
            nroCarga = new DataGridViewTextBoxColumn();
            ColPatente = new DataGridViewTextBoxColumn();
            ColTipo = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColSubtotal = new DataGridViewTextBoxColumn();
            cboTipoCarga = new ComboBox();
            txtTotal = new TextBox();
            btnSalir = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCantidad = new TextBox();
            chkActivo = new CheckBox();
            chkReparacion = new CheckBox();
            chkViaje = new CheckBox();
            label1 = new Label();
            label6 = new Label();
            lblCamion = new Label();
            txtPatente = new TextBox();
            cboCamion = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvTransporte).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(638, 82);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 30);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvTransporte
            // 
            dgvTransporte.AllowUserToAddRows = false;
            dgvTransporte.AllowUserToDeleteRows = false;
            dgvTransporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransporte.Columns.AddRange(new DataGridViewColumn[] { nroCarga, ColPatente, ColTipo, ColCantidad, ColSubtotal });
            dgvTransporte.Location = new Point(22, 135);
            dgvTransporte.Margin = new Padding(2);
            dgvTransporte.Name = "dgvTransporte";
            dgvTransporte.ReadOnly = true;
            dgvTransporte.RowHeadersWidth = 62;
            dgvTransporte.RowTemplate.Height = 33;
            dgvTransporte.Size = new Size(694, 190);
            dgvTransporte.TabIndex = 1;
            // 
            // nroCarga
            // 
            nroCarga.HeaderText = "Carga";
            nroCarga.MinimumWidth = 8;
            nroCarga.Name = "nroCarga";
            nroCarga.ReadOnly = true;
            nroCarga.Visible = false;
            nroCarga.Width = 150;
            // 
            // ColPatente
            // 
            ColPatente.HeaderText = "Patente";
            ColPatente.MinimumWidth = 8;
            ColPatente.Name = "ColPatente";
            ColPatente.ReadOnly = true;
            ColPatente.Width = 150;
            // 
            // ColTipo
            // 
            ColTipo.HeaderText = "Tipo de Carga";
            ColTipo.MinimumWidth = 8;
            ColTipo.Name = "ColTipo";
            ColTipo.ReadOnly = true;
            ColTipo.Width = 200;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.MinimumWidth = 8;
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            ColCantidad.Width = 150;
            // 
            // ColSubtotal
            // 
            ColSubtotal.HeaderText = "Subtotal(kg)";
            ColSubtotal.MinimumWidth = 8;
            ColSubtotal.Name = "ColSubtotal";
            ColSubtotal.ReadOnly = true;
            ColSubtotal.Width = 150;
            // 
            // cboTipoCarga
            // 
            cboTipoCarga.FormattingEnabled = true;
            cboTipoCarga.Location = new Point(118, 86);
            cboTipoCarga.Margin = new Padding(2);
            cboTipoCarga.Name = "cboTipoCarga";
            cboTipoCarga.Size = new Size(221, 23);
            cboTipoCarga.TabIndex = 2;
            cboTipoCarga.SelectedIndexChanged += cboTipoCarga_SelectedIndexChanged;
            // 
            // txtTotal
            // 
            txtTotal.AccessibleRole = AccessibleRole.None;
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(485, 361);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(106, 23);
            txtTotal.TabIndex = 4;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(638, 354);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(78, 30);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 40);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Patente";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 65);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Estado";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-273, -112);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 88);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 3;
            label5.Text = "Tipo de Carga: ";
            label5.Click += label5_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtCantidad.Location = new Point(360, 86);
            txtCantidad.Margin = new Padding(2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(106, 23);
            txtCantidad.TabIndex = 4;
            txtCantidad.Text = "Cantidad";
            txtCantidad.TextAlign = HorizontalAlignment.Center;
            txtCantidad.Click += txtCantidad_TextChanged;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(96, 63);
            chkActivo.Margin = new Padding(2);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 5;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            chkActivo.CheckedChanged += chkActivo_CheckedChanged;
            // 
            // chkReparacion
            // 
            chkReparacion.AutoSize = true;
            chkReparacion.Location = new Point(161, 63);
            chkReparacion.Margin = new Padding(2);
            chkReparacion.Name = "chkReparacion";
            chkReparacion.Size = new Size(85, 19);
            chkReparacion.TabIndex = 5;
            chkReparacion.Text = "Reparación";
            chkReparacion.UseVisualStyleBackColor = true;
            chkReparacion.CheckedChanged += chkReparacion_CheckedChanged;
            // 
            // chkViaje
            // 
            chkViaje.AutoSize = true;
            chkViaje.Location = new Point(273, 63);
            chkViaje.Margin = new Padding(2);
            chkViaje.Name = "chkViaje";
            chkViaje.Size = new Size(67, 19);
            chkViaje.TabIndex = 5;
            chkViaje.Text = "De viaje";
            chkViaje.UseVisualStyleBackColor = true;
            chkViaje.CheckedChanged += chkViaje_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(404, 369);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Carga Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(595, 369);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 3;
            label6.Text = "Kg";
            // 
            // lblCamion
            // 
            lblCamion.AutoSize = true;
            lblCamion.Location = new Point(21, 9);
            lblCamion.Margin = new Padding(2, 0, 2, 0);
            lblCamion.Name = "lblCamion";
            lblCamion.Size = new Size(49, 15);
            lblCamion.TabIndex = 3;
            lblCamion.Text = "Camión";
            lblCamion.Click += label2_Click;
            // 
            // txtPatente
            // 
            txtPatente.AccessibleRole = AccessibleRole.None;
            txtPatente.Enabled = false;
            txtPatente.Location = new Point(96, 36);
            txtPatente.Margin = new Padding(2);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(106, 23);
            txtPatente.TabIndex = 4;
            // 
            // cboCamion
            // 
            cboCamion.FormattingEnabled = true;
            cboCamion.Location = new Point(96, 6);
            cboCamion.Margin = new Padding(2);
            cboCamion.Name = "cboCamion";
            cboCamion.Size = new Size(221, 23);
            cboCamion.TabIndex = 2;
            cboCamion.SelectedIndexChanged += cboTipoCarga_SelectedIndexChanged;
            // 
            // FrmCargaYDescarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 392);
            ControlBox = false;
            Controls.Add(chkViaje);
            Controls.Add(chkReparacion);
            Controls.Add(chkActivo);
            Controls.Add(txtCantidad);
            Controls.Add(txtPatente);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(lblCamion);
            Controls.Add(label2);
            Controls.Add(cboCamion);
            Controls.Add(cboTipoCarga);
            Controls.Add(btnSalir);
            Controls.Add(dgvTransporte);
            Controls.Add(btnAgregar);
            Margin = new Padding(2);
            Name = "FrmCargaYDescarga";
            Text = "CargaYDescarga";
            Load += FrmCargaYDescarga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private DataGridView dgvTransporte;
        private ComboBox cboTipoCarga;
        private TextBox txtTotal;
        private Button btnSalir;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCantidad;
        private CheckBox chkActivo;
        private CheckBox chkReparacion;
        private CheckBox chkViaje;
        private Label label1;
        private Label label6;
        private DataGridViewTextBoxColumn nroCarga;
        private DataGridViewTextBoxColumn ColPatente;
        private DataGridViewTextBoxColumn ColTipo;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColSubtotal;
        private Label lblCamion;
        private TextBox txtPatente;
        private ComboBox cboCamion;
    }
}