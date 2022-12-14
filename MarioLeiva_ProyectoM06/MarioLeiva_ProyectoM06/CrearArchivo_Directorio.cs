using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MarioLeiva_ProyectoM06
{
    public partial class CrearArchivo_Directorio : Form
    {
        string texto;
        public CrearArchivo_Directorio()
        {
            InitializeComponent();
            
        }
        public CrearArchivo_Directorio(string texto)
        {
            InitializeComponent();
            this.texto = texto;
            textBoxasdasd.Text = texto;
        }


        private void CrearArchivo_Directorio_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonTxt_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonArchivo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonDirectorio_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MenuInicial menuInicial = new MenuInicial();
            textBoxasdasd.Text = texto;
            string ruta = textBoxasdasd.Text + "\\" + textBoxNombre.Text;
            if (radioButtonDirectorio.Checked)
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                    MessageBox.Show("Fichero Creado!!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya existe un fichero con ese nombre");
                }
            }
            else
            {
                if (!Directory.Exists(ruta))
                {
                    File.WriteAllText(ruta+".txt", "");
                    MessageBox.Show("Archivo Creado!!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya existe un fichero con ese nombre");
                }
                
            }
        }
    }
}
