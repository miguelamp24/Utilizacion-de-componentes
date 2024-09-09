namespace Utilizacion_de_componentes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnWMP = new System.Windows.Forms.Button();
            this.btnWB = new System.Windows.Forms.Button();
            this.picWB = new System.Windows.Forms.PictureBox();
            this.picWMP = new System.Windows.Forms.PictureBox();
            this.picPDF = new System.Windows.Forms.PictureBox();
            this.btnSalir2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Location = new System.Drawing.Point(90, 197);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(146, 54);
            this.btnPDF.TabIndex = 0;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnWMP
            // 
            this.btnWMP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnWMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWMP.Location = new System.Drawing.Point(320, 197);
            this.btnWMP.Name = "btnWMP";
            this.btnWMP.Size = new System.Drawing.Size(146, 54);
            this.btnWMP.TabIndex = 1;
            this.btnWMP.Text = "Windows Media Player";
            this.btnWMP.UseVisualStyleBackColor = false;
            this.btnWMP.Click += new System.EventHandler(this.btnWMP_Click);
            // 
            // btnWB
            // 
            this.btnWB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnWB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWB.Location = new System.Drawing.Point(550, 197);
            this.btnWB.Name = "btnWB";
            this.btnWB.Size = new System.Drawing.Size(146, 54);
            this.btnWB.TabIndex = 2;
            this.btnWB.Text = "Web browser";
            this.btnWB.UseVisualStyleBackColor = false;
            this.btnWB.Click += new System.EventHandler(this.btnWB_Click);
            // 
            // picWB
            // 
            this.picWB.Image = global::Utilizacion_de_componentes.Properties.Resources.descargar;
            this.picWB.Location = new System.Drawing.Point(551, 55);
            this.picWB.Name = "picWB";
            this.picWB.Size = new System.Drawing.Size(145, 126);
            this.picWB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWB.TabIndex = 5;
            this.picWB.TabStop = false;
            // 
            // picWMP
            // 
            this.picWMP.Image = global::Utilizacion_de_componentes.Properties.Resources.descargar__1_;
            this.picWMP.Location = new System.Drawing.Point(320, 55);
            this.picWMP.Name = "picWMP";
            this.picWMP.Size = new System.Drawing.Size(146, 126);
            this.picWMP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWMP.TabIndex = 4;
            this.picWMP.TabStop = false;
            // 
            // picPDF
            // 
            this.picPDF.Image = global::Utilizacion_de_componentes.Properties.Resources.pdf;
            this.picPDF.Location = new System.Drawing.Point(90, 55);
            this.picPDF.Name = "picPDF";
            this.picPDF.Size = new System.Drawing.Size(145, 126);
            this.picPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPDF.TabIndex = 3;
            this.picPDF.TabStop = false;
            // 
            // btnSalir2
            // 
            this.btnSalir2.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.Location = new System.Drawing.Point(320, 286);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(146, 54);
            this.btnSalir2.TabIndex = 6;
            this.btnSalir2.Text = "Salir";
            this.btnSalir2.UseVisualStyleBackColor = false;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(786, 389);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.picWB);
            this.Controls.Add(this.picWMP);
            this.Controls.Add(this.picPDF);
            this.Controls.Add(this.btnWB);
            this.Controls.Add(this.btnWMP);
            this.Controls.Add(this.btnPDF);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picWB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnWMP;
        private System.Windows.Forms.Button btnWB;
        private System.Windows.Forms.PictureBox picPDF;
        private System.Windows.Forms.PictureBox picWMP;
        private System.Windows.Forms.PictureBox picWB;
        private System.Windows.Forms.Button btnSalir2;
    }
}

