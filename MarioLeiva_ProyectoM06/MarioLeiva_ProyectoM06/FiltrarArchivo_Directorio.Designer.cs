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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxTodo = new System.Windows.Forms.CheckBox();
            this.checkBoxArchivos = new System.Windows.Forms.CheckBox();
            this.checkBoxDIrectorios = new System.Windows.Forms.CheckBox();
            this.checkBoxFCreacion = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(125, 226);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(100, 28);
            this.buttonAplicar.TabIndex = 11;
            this.buttonAplicar.Text = "Aplicar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtrar Por:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 176);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // checkBoxTodo
            // 
            this.checkBoxTodo.AutoSize = true;
            this.checkBoxTodo.Checked = true;
            this.checkBoxTodo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTodo.Location = new System.Drawing.Point(46, 62);
            this.checkBoxTodo.Name = "checkBoxTodo";
            this.checkBoxTodo.Size = new System.Drawing.Size(62, 20);
            this.checkBoxTodo.TabIndex = 13;
            this.checkBoxTodo.Text = "Todo";
            this.checkBoxTodo.UseVisualStyleBackColor = true;
            // 
            // checkBoxArchivos
            // 
            this.checkBoxArchivos.AutoSize = true;
            this.checkBoxArchivos.Location = new System.Drawing.Point(46, 88);
            this.checkBoxArchivos.Name = "checkBoxArchivos";
            this.checkBoxArchivos.Size = new System.Drawing.Size(81, 20);
            this.checkBoxArchivos.TabIndex = 14;
            this.checkBoxArchivos.Text = "Archivos";
            this.checkBoxArchivos.UseVisualStyleBackColor = true;
            // 
            // checkBoxDIrectorios
            // 
            this.checkBoxDIrectorios.AutoSize = true;
            this.checkBoxDIrectorios.Location = new System.Drawing.Point(46, 114);
            this.checkBoxDIrectorios.Name = "checkBoxDIrectorios";
            this.checkBoxDIrectorios.Size = new System.Drawing.Size(94, 20);
            this.checkBoxDIrectorios.TabIndex = 15;
            this.checkBoxDIrectorios.Text = "Directorios";
            this.checkBoxDIrectorios.UseVisualStyleBackColor = true;
            // 
            // checkBoxFCreacion
            // 
            this.checkBoxFCreacion.AutoSize = true;
            this.checkBoxFCreacion.Location = new System.Drawing.Point(46, 140);
            this.checkBoxFCreacion.Name = "checkBoxFCreacion";
            this.checkBoxFCreacion.Size = new System.Drawing.Size(143, 20);
            this.checkBoxFCreacion.TabIndex = 16;
            this.checkBoxFCreacion.Text = "Fecha de Creación";
            this.checkBoxFCreacion.UseVisualStyleBackColor = true;
            // 
            // FiltrarArchivo_Directorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 286);
            this.Controls.Add(this.checkBoxFCreacion);
            this.Controls.Add(this.checkBoxDIrectorios);
            this.Controls.Add(this.checkBoxArchivos);
            this.Controls.Add(this.checkBoxTodo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonAplicar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FiltrarArchivo_Directorio";
            this.Text = "FiltrarArchivo_Directorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAplicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxTodo;
        private System.Windows.Forms.CheckBox checkBoxArchivos;
        private System.Windows.Forms.CheckBox checkBoxDIrectorios;
        private System.Windows.Forms.CheckBox checkBoxFCreacion;
    }
}