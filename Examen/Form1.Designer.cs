namespace Examen
{
    partial class ExamenConComponentesyClase
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
            this.controlUsuario1 = new ConvertidorGrados_Faren.ControlUsuario();
            this.SuspendLayout();
            // 
            // controlUsuario1
            // 
            this.controlUsuario1.Location = new System.Drawing.Point(12, 12);
            this.controlUsuario1.Name = "controlUsuario1";
            this.controlUsuario1.Size = new System.Drawing.Size(518, 306);
            this.controlUsuario1.TabIndex = 0;
            this.controlUsuario1.Load += new System.EventHandler(this.controlUsuario1_Load);
            // 
            // ExamenConComponentesyClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 334);
            this.Controls.Add(this.controlUsuario1);
            this.Name = "ExamenConComponentesyClase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examen Con componentes y librerias";
            this.ResumeLayout(false);

        }

        #endregion

        private ConvertidorGrados_Faren.ControlUsuario controlUsuario1;
    }
}

