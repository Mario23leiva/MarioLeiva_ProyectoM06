namespace MarioLeiva_ProyectoM06
{
    partial class ModificarArchivo_Directorio
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreAntiguo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNombreNuevo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antiguo nombre Archivo/Directorio:";
            // 
            // textBoxNombreAntiguo
            // 
            this.textBoxNombreAntiguo.Enabled = false;
            this.textBoxNombreAntiguo.Location = new System.Drawing.Point(48, 89);
            this.textBoxNombreAntiguo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombreAntiguo.Name = "textBoxNombreAntiguo";
            this.textBoxNombreAntiguo.Size = new System.Drawing.Size(225, 22);
            this.textBoxNombreAntiguo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNombreNuevo
            // 
            this.textBoxNombreNuevo.Location = new System.Drawing.Point(48, 172);
            this.textBoxNombreNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombreNuevo.Name = "textBoxNombreNuevo";
            this.textBoxNombreNuevo.Size = new System.Drawing.Size(225, 22);
            this.textBoxNombreNuevo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nuevo nombre Archivo/Directorio:";
            // 
            // ModificarArchivo_Directorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 294);
            this.Controls.Add(this.textBoxNombreNuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNombreAntiguo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModificarArchivo_Directorio";
            this.Text = "ModificarArchivo_Directorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreAntiguo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNombreNuevo;
        private System.Windows.Forms.Label label2;
    }
}