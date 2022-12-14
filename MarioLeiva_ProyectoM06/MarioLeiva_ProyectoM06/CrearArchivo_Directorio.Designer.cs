namespace MarioLeiva_ProyectoM06
{
    partial class CrearArchivo_Directorio
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
            this.radioButtonArchivo = new System.Windows.Forms.RadioButton();
            this.radioButtonDirectorio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxasdasd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButtonArchivo
            // 
            this.radioButtonArchivo.AutoSize = true;
            this.radioButtonArchivo.Location = new System.Drawing.Point(62, 66);
            this.radioButtonArchivo.Name = "radioButtonArchivo";
            this.radioButtonArchivo.Size = new System.Drawing.Size(61, 17);
            this.radioButtonArchivo.TabIndex = 0;
            this.radioButtonArchivo.Text = "Archivo";
            this.radioButtonArchivo.UseVisualStyleBackColor = true;
            this.radioButtonArchivo.CheckedChanged += new System.EventHandler(this.radioButtonArchivo_CheckedChanged);
            // 
            // radioButtonDirectorio
            // 
            this.radioButtonDirectorio.AutoSize = true;
            this.radioButtonDirectorio.Checked = true;
            this.radioButtonDirectorio.Location = new System.Drawing.Point(196, 66);
            this.radioButtonDirectorio.Name = "radioButtonDirectorio";
            this.radioButtonDirectorio.Size = new System.Drawing.Size(70, 17);
            this.radioButtonDirectorio.TabIndex = 1;
            this.radioButtonDirectorio.TabStop = true;
            this.radioButtonDirectorio.Text = "Directorio";
            this.radioButtonDirectorio.UseVisualStyleBackColor = true;
            this.radioButtonDirectorio.CheckedChanged += new System.EventHandler(this.radioButtonDirectorio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona que elemento quieres crear";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(59, 121);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(95, 13);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre Directorio:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(62, 137);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(204, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(124, 195);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Añadir";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxasdasd
            // 
            this.textBoxasdasd.Location = new System.Drawing.Point(37, 219);
            this.textBoxasdasd.Name = "textBoxasdasd";
            this.textBoxasdasd.Size = new System.Drawing.Size(270, 20);
            this.textBoxasdasd.TabIndex = 8;
            // 
            // CrearArchivo_Directorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(330, 251);
            this.Controls.Add(this.textBoxasdasd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonDirectorio);
            this.Controls.Add(this.radioButtonArchivo);
            this.Name = "CrearArchivo_Directorio";
            this.Text = "CrearArchivo_Directorio";
            this.Load += new System.EventHandler(this.CrearArchivo_Directorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonArchivo;
        private System.Windows.Forms.RadioButton radioButtonDirectorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.TextBox textBoxasdasd;
    }
}