using Transporte_Clase_1.Vistas;

namespace Transporte_Clase_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void nuevoViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoViaje nuevoViaje = new frmNuevoViaje();
            nuevoViaje.ShowDialog();
        }
    }
}