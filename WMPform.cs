using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilizacion_de_componentes
{
    public partial class WMPform : Form
    {
        private string ruta = "";
        public WMPform()
        {
            InitializeComponent();
        }

        private void WMPform_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void axWMP_Enter(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lblRuta.Text = ruta;
            }
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            axWMP.URL = ruta;
            axWMP.Ctlcontrols.play();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.stop();
        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.pause();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
