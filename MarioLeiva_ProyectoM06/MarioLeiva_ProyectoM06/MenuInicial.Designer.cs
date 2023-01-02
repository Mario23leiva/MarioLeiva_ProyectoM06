namespace MarioLeiva_ProyectoM06
{
    partial class MenuInicial
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
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonOrdenar = new System.Windows.Forms.Button();
            this.botonFiltrar = new System.Windows.Forms.Button();
            this.botonCrearJSON = new System.Windows.Forms.Button();
            this.botonLeerJSON = new System.Windows.Forms.Button();
            this.botonExaminar = new System.Windows.Forms.Button();
            this.botonCrear = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.textBoxRutaArchivo = new System.Windows.Forms.TextBox();
            this.dataGridViewFicheros = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFicheros)).BeginInit();
            this.SuspendLayout();
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(951, 380);
            this.botonModificar.Margin = new System.Windows.Forms.Padding(4);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(151, 62);
            this.botonModificar.TabIndex = 0;
            this.botonModificar.Text = "Modificar archivo/directorio";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonOrdenar
            // 
            this.botonOrdenar.Location = new System.Drawing.Point(16, 101);
            this.botonOrdenar.Margin = new System.Windows.Forms.Padding(4);
            this.botonOrdenar.Name = "botonOrdenar";
            this.botonOrdenar.Size = new System.Drawing.Size(151, 62);
            this.botonOrdenar.TabIndex = 1;
            this.botonOrdenar.Text = "Ordenar";
            this.botonOrdenar.UseVisualStyleBackColor = true;
            this.botonOrdenar.Click += new System.EventHandler(this.botonOrdenar_Click);
            // 
            // botonFiltrar
            // 
            this.botonFiltrar.Location = new System.Drawing.Point(175, 101);
            this.botonFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.botonFiltrar.Name = "botonFiltrar";
            this.botonFiltrar.Size = new System.Drawing.Size(151, 62);
            this.botonFiltrar.TabIndex = 2;
            this.botonFiltrar.Text = "Filtrar";
            this.botonFiltrar.UseVisualStyleBackColor = true;
            this.botonFiltrar.Click += new System.EventHandler(this.botonFiltrar_Click);
            // 
            // botonCrearJSON
            // 
            this.botonCrearJSON.Location = new System.Drawing.Point(951, 486);
            this.botonCrearJSON.Margin = new System.Windows.Forms.Padding(4);
            this.botonCrearJSON.Name = "botonCrearJSON";
            this.botonCrearJSON.Size = new System.Drawing.Size(151, 62);
            this.botonCrearJSON.TabIndex = 3;
            this.botonCrearJSON.Text = "Crear JSON";
            this.botonCrearJSON.UseVisualStyleBackColor = true;
            this.botonCrearJSON.Click += new System.EventHandler(this.botonCrearJSON_Click);
            // 
            // botonLeerJSON
            // 
            this.botonLeerJSON.Location = new System.Drawing.Point(951, 590);
            this.botonLeerJSON.Margin = new System.Windows.Forms.Padding(4);
            this.botonLeerJSON.Name = "botonLeerJSON";
            this.botonLeerJSON.Size = new System.Drawing.Size(151, 62);
            this.botonLeerJSON.TabIndex = 4;
            this.botonLeerJSON.Text = "Leer JSON";
            this.botonLeerJSON.UseVisualStyleBackColor = true;
            this.botonLeerJSON.Click += new System.EventHandler(this.botonLeerJSON_Click);
            // 
            // botonExaminar
            // 
            this.botonExaminar.Location = new System.Drawing.Point(16, 15);
            this.botonExaminar.Margin = new System.Windows.Forms.Padding(4);
            this.botonExaminar.Name = "botonExaminar";
            this.botonExaminar.Size = new System.Drawing.Size(151, 62);
            this.botonExaminar.TabIndex = 5;
            this.botonExaminar.Text = "Examinar";
            this.botonExaminar.UseVisualStyleBackColor = true;
            this.botonExaminar.Click += new System.EventHandler(this.botonExaminar_Click);
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(951, 278);
            this.botonCrear.Margin = new System.Windows.Forms.Padding(4);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(151, 62);
            this.botonCrear.TabIndex = 6;
            this.botonCrear.Text = "Crear archivo/directorio";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(951, 170);
            this.botonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(151, 62);
            this.botonEliminar.TabIndex = 7;
            this.botonEliminar.Text = "Eliminar archivo/directorio";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // textBoxRutaArchivo
            // 
            this.textBoxRutaArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRutaArchivo.Location = new System.Drawing.Point(175, 32);
            this.textBoxRutaArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRutaArchivo.Name = "textBoxRutaArchivo";
            this.textBoxRutaArchivo.Size = new System.Drawing.Size(767, 26);
            this.textBoxRutaArchivo.TabIndex = 9;
            // 
            // dataGridViewFicheros
            // 
            this.dataGridViewFicheros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFicheros.Location = new System.Drawing.Point(17, 171);
            this.dataGridViewFicheros.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewFicheros.Name = "dataGridViewFicheros";
            this.dataGridViewFicheros.RowHeadersWidth = 51;
            this.dataGridViewFicheros.Size = new System.Drawing.Size(925, 480);
            this.dataGridViewFicheros.TabIndex = 10;
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 666);
            this.Controls.Add(this.dataGridViewFicheros);
            this.Controls.Add(this.textBoxRutaArchivo);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonCrear);
            this.Controls.Add(this.botonExaminar);
            this.Controls.Add(this.botonLeerJSON);
            this.Controls.Add(this.botonCrearJSON);
            this.Controls.Add(this.botonFiltrar);
            this.Controls.Add(this.botonOrdenar);
            this.Controls.Add(this.botonModificar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuInicial";
            this.Text = "MenuInicial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFicheros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonOrdenar;
        private System.Windows.Forms.Button botonFiltrar;
        private System.Windows.Forms.Button botonCrearJSON;
        private System.Windows.Forms.Button botonLeerJSON;
        private System.Windows.Forms.Button botonExaminar;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.TextBox textBoxRutaArchivo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.DataGridView dataGridViewFicheros;
    }
}