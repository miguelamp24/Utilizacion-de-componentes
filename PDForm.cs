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
    public partial class PDForm : Form
    {
        private string ruta = "";
        public PDForm()
        {
            InitializeComponent();
        }

        private void PDForm_Load(object sender, EventArgs e)
        {
            string pdfpath = @"C:\Users\ajmer\Documents\VS\Videos\Documento sin título.PDF";
            axPDF.src = pdfpath;
        }

        private void axPDF_Enter(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
