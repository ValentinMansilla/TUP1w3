using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transporte.Vistas
{
    public partial class FrmCargaYDescarga : Form
    {
        public FrmCargaYDescarga()
        {
            InitializeComponent();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            txtCantidad.Text = String.Empty;
        }

        private void FrmCargaYDescarga_Load(object sender, EventArgs e)
        {

        }

        private void chkReparacion_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }


        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void chkViaje_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cboPatente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void cboTipoCarga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
