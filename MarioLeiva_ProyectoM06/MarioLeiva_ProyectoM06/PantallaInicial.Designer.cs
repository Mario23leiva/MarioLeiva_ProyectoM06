namespace MarioLeiva_ProyectoM06
{
    partial class PantallaInicial
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
            this.buttonEntrarAplicacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEntrarAplicacion
            // 
            this.buttonEntrarAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrarAplicacion.Location = new System.Drawing.Point(205, 89);
            this.buttonEntrarAplicacion.Name = "buttonEntrarAplicacion";
            this.buttonEntrarAplicacion.Size = new System.Drawing.Size(172, 118);
            this.buttonEntrarAplicacion.TabIndex = 0;
            this.buttonEntrarAplicacion.Text = "Directory and File For Ever";
            this.buttonEntrarAplicacion.UseVisualStyleBackColor = true;
            this.buttonEntrarAplicacion.Click += new System.EventHandler(this.buttonEntrarAplicacion_Click);
            // 
            // PantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 308);
            this.Controls.Add(this.buttonEntrarAplicacion);
            this.Name = "PantallaInicial";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEntrarAplicacion;
    }
}

