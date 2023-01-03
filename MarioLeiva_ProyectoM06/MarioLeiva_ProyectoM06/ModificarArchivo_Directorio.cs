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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarioLeiva_ProyectoM06
{
    public partial class ModificarArchivo_Directorio : Form
    {
        string ruta1, rutaEntera, tipoArchivo;
        

        public string ValorCelda { get; set; }

        public ModificarArchivo_Directorio()
        {
            InitializeComponent();
        }

        public ModificarArchivo_Directorio(string texto, string ruta)
        {
            InitializeComponent();
            ruta1 = ruta;
            rutaEntera = texto;


            if (Path.GetExtension(rutaEntera).Equals(""))
            {
                tipoArchivo = "direcory";
                textBoxNombreAntiguo.Text = Path.GetFileName(rutaEntera);
            }
            else
            {
                textBoxNombreAntiguo.Text = Path.GetFileName(rutaEntera);
                tipoArchivo = "file";
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tipoArchivo.Equals("file"))
            {
                string nombreNuevo = ruta1 + "\\" + textBoxNombreNuevo.Text + Path.GetExtension(rutaEntera);
                if (File.Exists(nombreNuevo))
                {
                    MessageBox.Show("Ya existe un archivo con ese nombre");
                    return;
                }
                File.Move(ruta1 + "\\" + textBoxNombreAntiguo.Text, nombreNuevo);
                MessageBox.Show("Modificado correctamente");
                this.Close();
            }
            else
            {
                string nombreNuevo = ruta1 + "\\" + textBoxNombreNuevo.Text;
                if (Directory.Exists(nombreNuevo))
                {
                    MessageBox.Show("Ya existe un directorio con ese nombre");
                    return;
                }
                Directory.Move(ruta1 + "\\" + textBoxNombreAntiguo.Text, nombreNuevo);
                MessageBox.Show("Modificado correctamente");
                this.Close();
            }





        }


    }
}
