namespace MarioLeiva_ProyectoM06
{
    partial class OrdenarArchivo_Directorio
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
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.radioButtonFecha = new System.Windows.Forms.RadioButton();
            this.radioButtonTipo = new System.Windows.Forms.RadioButton();
            this.radioButtonSize = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Checked = true;
            this.radioButtonNombre.Location = new System.Drawing.Point(30, 44);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(62, 17);
            this.radioButtonNombre.TabIndex = 0;
            this.radioButtonNombre.TabStop = true;
            this.radioButtonNombre.Text = "Nombre";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            // 
            // radioButtonFecha
            // 
            this.radioButtonFecha.AutoSize = true;
            this.radioButtonFecha.Location = new System.Drawing.Point(30, 67);
            this.radioButtonFecha.Name = "radioButtonFecha";
            this.radioButtonFecha.Size = new System.Drawing.Size(118, 17);
            this.radioButtonFecha.TabIndex = 1;
            this.radioButtonFecha.TabStop = true;
            this.radioButtonFecha.Text = "Fecha Modificación";
            this.radioButtonFecha.UseVisualStyleBackColor = true;
            // 
            // radioButtonTipo
            // 
            this.radioButtonTipo.AutoSize = true;
            this.radioButtonTipo.Location = new System.Drawing.Point(30, 90);
            this.radioButtonTipo.Name = "radioButtonTipo";
            this.radioButtonTipo.Size = new System.Drawing.Size(100, 17);
            this.radioButtonTipo.TabIndex = 2;
            this.radioButtonTipo.TabStop = true;
            this.radioButtonTipo.Text = "Tipo de Archivo";
            this.radioButtonTipo.UseVisualStyleBackColor = true;
            // 
            // radioButtonSize
            // 
            this.radioButtonSize.AutoSize = true;
            this.radioButtonSize.Location = new System.Drawing.Point(30, 113);
            this.radioButtonSize.Name = "radioButtonSize";
            this.radioButtonSize.Size = new System.Drawing.Size(66, 17);
            this.radioButtonSize.TabIndex = 3;
            this.radioButtonSize.TabStop = true;
            this.radioButtonSize.Text = "Tamañio";
            this.radioButtonSize.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordenar Por:";
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(40, 136);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(75, 23);
            this.buttonAplicar.TabIndex = 5;
            this.buttonAplicar.Text = "Aplicar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            // 
            // OrdenarArchivo_Directorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 182);
            this.Controls.Add(this.buttonAplicar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonSize);
            this.Controls.Add(this.radioButtonTipo);
            this.Controls.Add(this.radioButtonFecha);
            this.Controls.Add(this.radioButtonNombre);
            this.Name = "OrdenarArchivo_Directorio";
            this.Text = "OrdenarArchivo_Directorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonNombre;
        private System.Windows.Forms.RadioButton radioButtonFecha;
        private System.Windows.Forms.RadioButton radioButtonTipo;
        private System.Windows.Forms.RadioButton radioButtonSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAplicar;
    }
}