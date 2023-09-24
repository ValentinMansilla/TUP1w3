using Transporte.Vistas;

namespace Transporte
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cargasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoTransporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargaYDescarga nuevo = new FrmCargaYDescarga();
            nuevo.ShowDialog();
        }
    }
}