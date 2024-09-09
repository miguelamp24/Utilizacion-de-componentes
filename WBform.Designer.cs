namespace Utilizacion_de_componentes
{
    partial class WBform
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
            this.wbPagina = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbPagina
            // 
            this.wbPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbPagina.Location = new System.Drawing.Point(0, 0);
            this.wbPagina.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPagina.Name = "wbPagina";
            this.wbPagina.Size = new System.Drawing.Size(799, 386);
            this.wbPagina.TabIndex = 0;
            this.wbPagina.Url = new System.Uri("https://www.youtube.com", System.UriKind.Absolute);
            this.wbPagina.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbPagina_DocumentCompleted);
            // 
            // WBform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 386);
            this.Controls.Add(this.wbPagina);
            this.Name = "WBform";
            this.Text = "WBform";
            this.Load += new System.EventHandler(this.WBform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbPagina;
    }
}