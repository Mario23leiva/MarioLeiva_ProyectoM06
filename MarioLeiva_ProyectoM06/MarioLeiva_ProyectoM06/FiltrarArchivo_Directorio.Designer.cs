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
            this.radioButtonTodo = new System.Windows.Forms.RadioButton();
            this.radioButtonArchivos = new System.Windows.Forms.RadioButton();
            this.radioButtonDirectorios = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDT = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(92, 205);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(77, 23);
            this.buttonAplicar.TabIndex = 11;
            this.buttonAplicar.Text = "Aplicar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            this.buttonAplicar.Click += new System.EventHandler(this.buttonAplicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtrar Por:";
            // 
            // radioButtonTodo
            // 
            this.radioButtonTodo.AutoSize = true;
            this.radioButtonTodo.Location = new System.Drawing.Point(92, 51);
            this.radioButtonTodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonTodo.Name = "radioButtonTodo";
            this.radioButtonTodo.Size = new System.Drawing.Size(50, 17);
            this.radioButtonTodo.TabIndex = 18;
            this.radioButtonTodo.TabStop = true;
            this.radioButtonTodo.Text = "Todo";
            this.radioButtonTodo.UseVisualStyleBackColor = true;
            this.radioButtonTodo.CheckedChanged += new System.EventHandler(this.radioButtonTodo_CheckedChanged);
            // 
            // radioButtonArchivos
            // 
            this.radioButtonArchivos.AutoSize = true;
            this.radioButtonArchivos.Location = new System.Drawing.Point(92, 81);
            this.radioButtonArchivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonArchivos.Name = "radioButtonArchivos";
            this.radioButtonArchivos.Size = new System.Drawing.Size(66, 17);
            this.radioButtonArchivos.TabIndex = 19;
            this.radioButtonArchivos.TabStop = true;
            this.radioButtonArchivos.Text = "Archivos";
            this.radioButtonArchivos.UseVisualStyleBackColor = true;
            this.radioButtonArchivos.CheckedChanged += new System.EventHandler(this.radioButtonArchivos_CheckedChanged);
            // 
            // radioButtonDirectorios
            // 
            this.radioButtonDirectorios.AutoSize = true;
            this.radioButtonDirectorios.Location = new System.Drawing.Point(92, 110);
            this.radioButtonDirectorios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonDirectorios.Name = "radioButtonDirectorios";
            this.radioButtonDirectorios.Size = new System.Drawing.Size(75, 17);
            this.radioButtonDirectorios.TabIndex = 20;
            this.radioButtonDirectorios.TabStop = true;
            this.radioButtonDirectorios.Text = "Directorios";
            this.radioButtonDirectorios.UseVisualStyleBackColor = true;
            this.radioButtonDirectorios.CheckedChanged += new System.EventHandler(this.radioButtonDirectorios_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 170);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBoxDT
            // 
            this.checkBoxDT.AutoSize = true;
            this.checkBoxDT.Location = new System.Drawing.Point(92, 139);
            this.checkBoxDT.Name = "checkBoxDT";
            this.checkBoxDT.Size = new System.Drawing.Size(116, 17);
            this.checkBoxDT.TabIndex = 23;
            this.checkBoxDT.Text = "Fecha de Creación";
            this.checkBoxDT.UseVisualStyleBackColor = true;
            this.checkBoxDT.CheckedChanged += new System.EventHandler(this.checkBoxDT_CheckedChanged);
            // 
            // FiltrarArchivo_Directorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 246);
            this.Controls.Add(this.checkBoxDT);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButtonDirectorios);
            this.Controls.Add(this.radioButtonArchivos);
            this.Controls.Add(this.radioButtonTodo);
            this.Controls.Add(this.buttonAplicar);
            this.Controls.Add(this.label1);
            this.Name = "FiltrarArchivo_Directorio";
            this.Text = "FiltrarArchivo_Directorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAplicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonTodo;
        private System.Windows.Forms.RadioButton radioButtonArchivos;
        private System.Windows.Forms.RadioButton radioButtonDirectorios;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxDT;
    }
}