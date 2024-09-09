namespace Utilizacion_de_componentes
{
    partial class PDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDForm));
            this.axPDF = new AxAcroPDFLib.AxAcroPDF();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // axPDF
            // 
            this.axPDF.Enabled = true;
            this.axPDF.Location = new System.Drawing.Point(34, 28);
            this.axPDF.Name = "axPDF";
            this.axPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPDF.OcxState")));
            this.axPDF.Size = new System.Drawing.Size(358, 335);
            this.axPDF.TabIndex = 0;
            this.axPDF.Enter += new System.EventHandler(this.axPDF_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(533, 183);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 389);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.axPDF);
            this.Name = "PDForm";
            this.Text = "PDForm";
            this.Load += new System.EventHandler(this.PDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axPDF;
        private System.Windows.Forms.Button btnSalir;
    }
}