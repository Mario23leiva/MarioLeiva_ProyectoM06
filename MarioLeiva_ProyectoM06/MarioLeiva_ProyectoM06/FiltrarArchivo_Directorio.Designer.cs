namespace MarioLeiva_ProyectoM06
{
    partial class FiltrarArchivo_Directorio
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
            this.buttonAplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonSize = new System.Windows.Forms.RadioButton();
            this.radioButtonTipo = new System.Windows.Forms.RadioButton();
            this.radioButtonFecha = new System.Windows.Forms.RadioButton();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(94, 184);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(75, 23);
            this.buttonAplicar.TabIndex = 11;
            this.buttonAplicar.Text = "Aplicar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtrar Por:";
            // 
            // radioButtonSize
            // 
            this.radioButtonSize.AutoSize = true;
            this.radioButtonSize.Location = new System.Drawing.Point(35, 120);
            this.radioButtonSize.Name = "radioButtonSize";
            this.radioButtonSize.Size = new System.Drawing.Size(115, 17);
            this.radioButtonSize.TabIndex = 9;
            this.radioButtonSize.Text = "Fecha de Creación";
            this.radioButtonSize.UseVisualStyleBackColor = true;
            // 
            // radioButtonTipo
            // 
            this.radioButtonTipo.AutoSize = true;
            this.radioButtonTipo.Checked = true;
            this.radioButtonTipo.Location = new System.Drawing.Point(35, 51);
            this.radioButtonTipo.Name = "radioButtonTipo";
            this.radioButtonTipo.Size = new System.Drawing.Size(50, 17);
            this.radioButtonTipo.TabIndex = 8;
            this.radioButtonTipo.TabStop = true;
            this.radioButtonTipo.Text = "Todo";
            this.radioButtonTipo.UseVisualStyleBackColor = true;
            // 
            // radioButtonFecha
            // 
            this.radioButtonFecha.AutoSize = true;
            this.radioButtonFecha.Location = new System.Drawing.Point(35, 97);
            this.radioButtonFecha.Name = "radioButtonFecha";
            this.radioButtonFecha.Size = new System.Drawing.Size(75, 17);
            this.radioButtonFecha.TabIndex = 7;
            this.radioButtonFecha.Text = "Directorios";
            this.radioButtonFecha.UseVisualStyleBackColor = true;
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Location = new System.Drawing.Point(35, 74);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(66, 17);
            this.radioButtonNombre.TabIndex = 6;
            this.radioButtonNombre.Text = "Archivos";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // FiltrarArchivo_Directorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 232);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonAplicar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonSize);
            this.Controls.Add(this.radioButtonTipo);
            this.Controls.Add(this.radioButtonFecha);
            this.Controls.Add(this.radioButtonNombre);
            this.Name = "FiltrarArchivo_Directorio";
            this.Text = "FiltrarArchivo_Directorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAplicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSize;
        private System.Windows.Forms.RadioButton radioButtonTipo;
        private System.Windows.Forms.RadioButton radioButtonFecha;
        private System.Windows.Forms.RadioButton radioButtonNombre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}