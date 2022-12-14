namespace MarioLeiva_ProyectoM06
{
    partial class CrearJSON
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreJSON = new System.Windows.Forms.TextBox();
            this.textBoxContenidoJSON = new System.Windows.Forms.TextBox();
            this.botonGuardarJSON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contenido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre JSON:";
            // 
            // textBoxNombreJSON
            // 
            this.textBoxNombreJSON.Location = new System.Drawing.Point(12, 28);
            this.textBoxNombreJSON.Name = "textBoxNombreJSON";
            this.textBoxNombreJSON.Size = new System.Drawing.Size(191, 20);
            this.textBoxNombreJSON.TabIndex = 7;
            // 
            // textBoxContenidoJSON
            // 
            this.textBoxContenidoJSON.Location = new System.Drawing.Point(12, 75);
            this.textBoxContenidoJSON.Multiline = true;
            this.textBoxContenidoJSON.Name = "textBoxContenidoJSON";
            this.textBoxContenidoJSON.Size = new System.Drawing.Size(391, 412);
            this.textBoxContenidoJSON.TabIndex = 6;
            // 
            // botonGuardarJSON
            // 
            this.botonGuardarJSON.Location = new System.Drawing.Point(328, 493);
            this.botonGuardarJSON.Name = "botonGuardarJSON";
            this.botonGuardarJSON.Size = new System.Drawing.Size(75, 23);
            this.botonGuardarJSON.TabIndex = 5;
            this.botonGuardarJSON.Text = "Guardar";
            this.botonGuardarJSON.UseVisualStyleBackColor = true;
            // 
            // CrearJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombreJSON);
            this.Controls.Add(this.textBoxContenidoJSON);
            this.Controls.Add(this.botonGuardarJSON);
            this.Name = "CrearJSON";
            this.Text = "CrearJSON";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreJSON;
        private System.Windows.Forms.TextBox textBoxContenidoJSON;
        private System.Windows.Forms.Button botonGuardarJSON;
    }
}