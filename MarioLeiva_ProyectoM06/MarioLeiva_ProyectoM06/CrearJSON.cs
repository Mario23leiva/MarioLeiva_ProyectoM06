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

namespace MarioLeiva_ProyectoM06
{
    public partial class CrearJSON : Form
    {
        public CrearJSON()
        {
            InitializeComponent();
        }

        public CrearJSON(string json)
        {
            InitializeComponent();
            string infoJson = json;

            textBoxContenidoJSON.Text = infoJson;
        }

        private void textBoxContenidoJSON_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonGuardarJSON_Click(object sender, EventArgs e)
        {

            if (textBoxNombreJSON.Text!="")
            {
                FolderBrowserDialog ruta = new FolderBrowserDialog();

                if (ruta.ShowDialog().Equals(DialogResult.OK))
                {
                    ruta.SelectedPath = ruta.SelectedPath+"\\"+textBoxNombreJSON.Text+".json";
                    File.WriteAllText(ruta.SelectedPath, textBoxContenidoJSON.Text);
                }
                MessageBox.Show("JSON guardado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("El nombre del json está vacío, por favor introduce un nomrbe");
            }
            
        }
    }
}
