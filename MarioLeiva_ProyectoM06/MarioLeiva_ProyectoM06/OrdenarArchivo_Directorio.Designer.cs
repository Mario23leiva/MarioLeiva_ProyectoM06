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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descendente = new System.Windows.Forms.RadioButton();
            this.ascendente = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Checked = true;
            this.radioButtonNombre.Location = new System.Drawing.Point(62, 44);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(62, 17);
            this.radioButtonNombre.TabIndex = 0;
            this.radioButtonNombre.TabStop = true;
            this.radioButtonNombre.Text = "Nombre";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            this.radioButtonNombre.CheckedChanged += new System.EventHandler(this.radioButtonNombre_CheckedChanged);
            // 
            // radioButtonFecha
            // 
            this.radioButtonFecha.AutoSize = true;
            this.radioButtonFecha.Location = new System.Drawing.Point(62, 67);
            this.radioButtonFecha.Name = "radioButtonFecha";
            this.radioButtonFecha.Size = new System.Drawing.Size(118, 17);
            this.radioButtonFecha.TabIndex = 1;
            this.radioButtonFecha.TabStop = true;
            this.radioButtonFecha.Text = "Fecha Modificación";
            this.radioButtonFecha.UseVisualStyleBackColor = true;
            this.radioButtonFecha.CheckedChanged += new System.EventHandler(this.radioButtonFecha_CheckedChanged);
            // 
            // radioButtonTipo
            // 
            this.radioButtonTipo.AutoSize = true;
            this.radioButtonTipo.Location = new System.Drawing.Point(62, 90);
            this.radioButtonTipo.Name = "radioButtonTipo";
            this.radioButtonTipo.Size = new System.Drawing.Size(100, 17);
            this.radioButtonTipo.TabIndex = 2;
            this.radioButtonTipo.TabStop = true;
            this.radioButtonTipo.Text = "Tipo de Archivo";
            this.radioButtonTipo.UseVisualStyleBackColor = true;
            this.radioButtonTipo.CheckedChanged += new System.EventHandler(this.radioButtonTipo_CheckedChanged);
            // 
            // radioButtonSize
            // 
            this.radioButtonSize.AutoSize = true;
            this.radioButtonSize.Location = new System.Drawing.Point(62, 113);
            this.radioButtonSize.Name = "radioButtonSize";
            this.radioButtonSize.Size = new System.Drawing.Size(66, 17);
            this.radioButtonSize.TabIndex = 3;
            this.radioButtonSize.TabStop = true;
            this.radioButtonSize.Text = "Tamañio";
            this.radioButtonSize.UseVisualStyleBackColor = true;
            this.radioButtonSize.CheckedChanged += new System.EventHandler(this.radioButtonSize_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordenar Por:";
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(63, 182);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(75, 23);
            this.buttonAplicar.TabIndex = 5;
            this.buttonAplicar.Text = "Aplicar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            this.buttonAplicar.Click += new System.EventHandler(this.buttonAplicar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ascendente);
            this.groupBox1.Controls.Add(this.descendente);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 37);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // descendente
            // 
            this.descendente.AutoSize = true;
            this.descendente.Location = new System.Drawing.Point(6, 14);
            this.descendente.Name = "descendente";
            this.descendente.Size = new System.Drawing.Size(89, 17);
            this.descendente.TabIndex = 0;
            this.descendente.Text = "Descendente";
            this.descendente.UseVisualStyleBackColor = true;
            this.descendente.CheckedChanged += new System.EventHandler(this.descendente_CheckedChanged);
            // 
            // ascendente
            // 
            this.ascendente.AutoSize = true;
            this.ascendente.Checked = true;
            this.ascendente.Location = new System.Drawing.Point(99, 14);
            this.ascendente.Name = "ascendente";
            this.ascendente.Size = new System.Drawing.Size(82, 17);
            this.ascendente.TabIndex = 1;
            this.ascendente.TabStop = true;
            this.ascendente.Text = "Ascendente";
            this.ascendente.UseVisualStyleBackColor = true;
            this.ascendente.CheckedChanged += new System.EventHandler(this.ascendente_CheckedChanged);
            // 
            // OrdenarArchivo_Directorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 226);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAplicar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonSize);
            this.Controls.Add(this.radioButtonTipo);
            this.Controls.Add(this.radioButtonFecha);
            this.Controls.Add(this.radioButtonNombre);
            this.Name = "OrdenarArchivo_Directorio";
            this.Text = "OrdenarArchivo_Directorio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ascendente;
        private System.Windows.Forms.RadioButton descendente;
    }
}