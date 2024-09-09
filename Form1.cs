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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWMP_Click(object sender, EventArgs e)
        {
            WMPform pDFwmp = new WMPform();
            pDFwmp.Show();         
        }

        private void btnWB_Click(object sender, EventArgs e)
        {
            WBform wBform = new WBform();
            wBform.Show();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            PDForm pPDform = new PDForm();
            pPDform.Show();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
