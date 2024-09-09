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
    public partial class WBform : Form
    {
        public WBform()
        {
            InitializeComponent();
        }

        private void wbPagina_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void WBform_Load(object sender, EventArgs e)
        {
            string url = "www.google.com";
            wbPagina.Navigate(url);
        }
    }
}
