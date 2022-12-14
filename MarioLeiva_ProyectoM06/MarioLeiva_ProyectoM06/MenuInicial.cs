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
    public partial class MenuInicial : Form
    {
        
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            
            CrearArchivo_Directorio f1 = new CrearArchivo_Directorio(textBoxRutaArchivo.Text);
            f1.texto2 = textBoxRutaArchivo.Text;
            f1.Show();
        }

        private void botonOrdenar_Click(object sender, EventArgs e)
        {
            OrdenarArchivo_Directorio pantalla = new OrdenarArchivo_Directorio();
            pantalla.ShowDialog();
        }

        private void botonFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarArchivo_Directorio pantalla = new FiltrarArchivo_Directorio();
            pantalla.ShowDialog();
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            ModificarArchivo_Directorio pantalla = new ModificarArchivo_Directorio();
            pantalla.ShowDialog();
        }

        private void botonCrearJSON_Click(object sender, EventArgs e)
        {
            CrearJSON pantalla = new CrearJSON();
            pantalla.ShowDialog();
        }

        public void botonExaminar_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog ruta = new FolderBrowserDialog();

            if (ruta.ShowDialog().Equals(DialogResult.OK))
            {
                textBoxRutaArchivo.Text = ruta.SelectedPath;
                string path = textBoxRutaArchivo.Text;
                string a = Path.GetDirectoryName(path);
                DirectoryInfo f = new DirectoryInfo(textBoxRutaArchivo.Text);
                DirectoryInfo[] aa = f.GetDirectories();
                List<Fichero> lista = new List<Fichero>();

                for (int i = 0; i < aa.Length; i++)
                {
                    lista.Add(new Fichero()
                    {
                        Nombre = aa[i].Name,
                        FechaModificacion = aa[i].LastWriteTime,
                        Extension = aa[i].Extension
                        
                    });
                }

                dataGridViewFicheros.DataSource = lista;
            }
        }
    }
}
