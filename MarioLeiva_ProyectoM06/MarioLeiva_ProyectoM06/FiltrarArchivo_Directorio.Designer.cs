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
            this.radioButtonFC = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonAplicar
            // 
            this.buttonAplicar.Location = new System.Drawing.Point(122, 252);
            this.buttonAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAplicar.Name = "buttonAplicar";
            this.buttonAplicar.Size = new System.Drawing.Size(103, 28);
            this.buttonAplicar.TabIndex = 11;
            this.buttonAplicar.Text = "Aplicar";
            this.buttonAplicar.UseVisualStyleBackColor = true;
            this.buttonAplicar.Click += new System.EventHandler(this.buttonAplicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtrar Por:";
            // 
            // radioButtonTodo
            // 
            this.radioButtonTodo.AutoSize = true;
            this.radioButtonTodo.Location = new System.Drawing.Point(122, 63);
            this.radioButtonTodo.Name = "radioButtonTodo";
            this.radioButtonTodo.Size = new System.Drawing.Size(61, 20);
            this.radioButtonTodo.TabIndex = 18;
            this.radioButtonTodo.TabStop = true;
            this.radioButtonTodo.Text = "Todo";
            this.radioButtonTodo.UseVisualStyleBackColor = true;
            this.radioButtonTodo.CheckedChanged += new System.EventHandler(this.radioButtonTodo_CheckedChanged);
            // 
            // radioButtonArchivos
            // 
            this.radioButtonArchivos.AutoSize = true;
            this.radioButtonArchivos.Location = new System.Drawing.Point(122, 100);
            this.radioButtonArchivos.Name = "radioButtonArchivos";
            this.radioButtonArchivos.Size = new System.Drawing.Size(80, 20);
            this.radioButtonArchivos.TabIndex = 19;
            this.radioButtonArchivos.TabStop = true;
            this.radioButtonArchivos.Text = "Archivos";
            this.radioButtonArchivos.UseVisualStyleBackColor = true;
            this.radioButtonArchivos.CheckedChanged += new System.EventHandler(this.radioButtonArchivos_CheckedChanged);
            // 
            // radioButtonDirectorios
            // 
            this.radioButtonDirectorios.AutoSize = true;
            this.radioButtonDirectorios.Location = new System.Drawing.Point(122, 136);
            this.radioButtonDirectorios.Name = "radioButtonDirectorios";
            this.radioButtonDirectorios.Size = new System.Drawing.Size(93, 20);
            this.radioButtonDirectorios.TabIndex = 20;
            this.radioButtonDirectorios.TabStop = true;
            this.radioButtonDirectorios.Text = "Directorios";
            this.radioButtonDirectorios.UseVisualStyleBackColor = true;
            this.radioButtonDirectorios.CheckedChanged += new System.EventHandler(this.radioButtonDirectorios_CheckedChanged);
            // 
            // radioButtonFC
            // 
            this.radioButtonFC.AutoSize = true;
            this.radioButtonFC.Location = new System.Drawing.Point(122, 173);
            this.radioButtonFC.Name = "radioButtonFC";
            this.radioButtonFC.Size = new System.Drawing.Size(140, 20);
            this.radioButtonFC.TabIndex = 21;
            this.radioButtonFC.TabStop = true;
            this.radioButtonFC.Text = "Fecha de creación";
            this.radioButtonFC.UseVisualStyleBackColor = true;
            this.radioButtonFC.CheckedChanged += new System.EventHandler(this.radioButtonFC_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FiltrarArchivo_Directorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 303);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButtonFC);
            this.Controls.Add(this.radioButtonDirectorios);
            this.Controls.Add(this.radioButtonArchivos);
            this.Controls.Add(this.radioButtonTodo);
            this.Controls.Add(this.buttonAplicar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.RadioButton radioButtonFC;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}