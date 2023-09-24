using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transporte_Clase_1.Entidades;

namespace Transporte_Clase_1.Vistas
{
    public partial class frmNuevoViaje : Form
    {
        private Viaje nuevoViaje = null;
        private Camion nuevoCamion = null;
        public frmNuevoViaje()
        {
            InitializeComponent();
            nuevoViaje = new Viaje();
        }

        private void frmNuevoViaje_Load(object sender, EventArgs e)
        {
            CargarCamion();
            CargarTipoDeCarga();
            chkActivo.Enabled = false;
            chkReparacion.Enabled = false;
            txtPatente.Enabled = false;
            btnAceptar.Enabled = false;
        }


        private void CargarTipoDeCarga()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=DESKTOP-N6A76JF\SQLVALEN;Initial Catalog=transporte;Integrated Security=True";
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_Consultar_Tipos_Carga";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            cnn.Close();

            cboCarga.DataSource = tabla;
            cboCarga.ValueMember = tabla.Columns[0].ColumnName;
            cboCarga.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void CargarCamion()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=DESKTOP-N6A76JF\SQLVALEN;Initial Catalog=transporte;Integrated Security=True";
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_Consultar_Camiones";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            cnn.Close();

            cboCamion.DataSource = tabla;
            cboCamion.ValueMember = tabla.Columns[0].ColumnName;
            cboCamion.DisplayMember = tabla.Columns[0].ColumnName;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cboCamion_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataRowView item = (DataRowView)cboCamion.SelectedItem;

            string patente = (string)item.Row.ItemArray[1];
            bool activo = (bool)item.Row.ItemArray[2];

            if (activo)
            {
                chkActivo.Checked = true;
                chkReparacion.Checked = false;
            }
            else if (!activo)
            {
                chkActivo.Checked = false;
                chkReparacion.Checked = true;
            }


            txtPatente.Text = patente;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCantidad_Click(object sender, EventArgs e)
        {

            txtCantidad.Text = String.Empty;
        }

        private void cboCarga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (chkReparacion.Checked)
            {
                MessageBox.Show("Seleccione un camión activo");
                cboCamion.Focus();
                return;
            }
            if (txtCantidad.Text == String.Empty || !int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Seleccione cantidad válida");
                txtCantidad.Focus();
                return;
            }
            if (txtPeso.Text == String.Empty || !double.TryParse(txtPeso.Text, out _))
            {
                MessageBox.Show("Seleccione un peso válido");
                txtPeso.Focus();
                return;
            }

            foreach (DataGridViewRow d in dgvDetalles.Rows)
            {
                if (d.Cells["colTipoCarga"].Value.ToString().Equals(cboCarga.Text))
                {
                    MessageBox.Show("Este elemento ya está cargado");
                    cboCarga.Focus();
                    return;
                }
            }



            DataRowView item = (DataRowView)cboCamion.SelectedItem;
            int id = (int)item.Row.ItemArray[0];
            string patente = (string)item.Row.ItemArray[1];
            bool estado = (bool)item.Row.ItemArray[2];
            double pesoMax = (double)item.Row.ItemArray[3];

            DataRowView item2 = (DataRowView)cboCarga.SelectedItem;
            double peso = Convert.ToDouble(txtPeso.Text);
            int codigo = (int)item2.Row.ItemArray[0];
            string nombre = (string)item2.Row.ItemArray[1];
            TipoCarga tipo = new TipoCarga(codigo, nombre);

            Carga carga = new Carga(peso, tipo);
            nuevoCamion = new Camion(id, patente, estado, pesoMax, carga);

            int cant = Convert.ToInt32(txtCantidad.Text);

            DetalleViaje nuevodetalle = new DetalleViaje(nuevoCamion, cant);

            nuevoViaje.AgregarDetalle(nuevodetalle);

            dgvDetalles.Rows.Add(new object[] { id, carga, cant, peso, "Quitar" });

            lblTotal.Text = nuevoViaje.CalcularTotal().ToString();

            ValidarPeso();

        }

        private void ValidarPeso()
        {
            if (Convert.ToDouble(lblTotal.Text) > nuevoCamion.PesoMaximo)
            {
                MessageBox.Show("La carga supera el peso máximo permitido");
                dgvDetalles.Focus();
                btnAceptar.Enabled = false;
                return;
            }
            else btnAceptar.Enabled = true;
        }

        private void txtPeso_Click(object sender, EventArgs e)
        {
            txtPeso.Text = String.Empty;
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                nuevoViaje.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);

                lblTotal.Text = nuevoViaje.CalcularTotal().ToString();
                ValidarPeso();
            }
        }
    }
}
