using Newtonsoft.Json;
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
using System.Xml.Linq;

namespace MarioLeiva_ProyectoM06
{
    public partial class MenuInicial : Form
    {

        public string nombreArchivo;
        string filaSeleccionada;
        public MenuInicial()
        {
            InitializeComponent();
        }

        public MenuInicial(string texto)
        {
            InitializeComponent();
            this.nombreArchivo = texto;
            filaSeleccionada = texto;
        }

        private void botonCrear_Click(object sender, EventArgs e)
        {
            
            CrearArchivo_Directorio crearArchivo_Directorio = new CrearArchivo_Directorio(textBoxRutaArchivo.Text);
            crearArchivo_Directorio.ShowDialog();
        }

        private void botonOrdenar_Click(object sender, EventArgs e)
        {
            OrdenarArchivo_Directorio ordenarArchivo_Directorio = new OrdenarArchivo_Directorio();
            ordenarArchivo_Directorio.ShowDialog();
        }

        private void botonFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarArchivo_Directorio filtrarArchivo_Directorio = new FiltrarArchivo_Directorio();
            filtrarArchivo_Directorio.ShowDialog();
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            filaSeleccionada = dataGridViewFicheros.SelectedCells[0].Value.ToString();
            ModificarArchivo_Directorio modificarArchivo_Directorio = new ModificarArchivo_Directorio(filaSeleccionada);
            modificarArchivo_Directorio.ShowDialog();
            
        }
        

        private void botonCrearJSON_Click(object sender, EventArgs e)
        {
            Fichero obj = new Fichero();

            foreach (DataGridViewRow row in dataGridViewFicheros.Rows)
            {
                
                obj.Nombre = row.Cells[0].Value.ToString();
                obj.Extension = row.Cells[1].Value.ToString();
                obj.PesoArchivo = row.Cells[2].Value.ToString();
                obj.FechaModificacion = DateTime.Parse(row.Cells[3].Value.ToString());
            }

            string json = JsonConvert.SerializeObject(obj);
            
            CrearJSON crearJSON = new CrearJSON(json);
            crearJSON.ShowDialog();
        }

        public void botonExaminar_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog ruta = new FolderBrowserDialog();

            if (ruta.ShowDialog().Equals(DialogResult.OK))
            {

                dataGridViewFicheros.DataSource = null;

                textBoxRutaArchivo.Text = ruta.SelectedPath;
                string path = textBoxRutaArchivo.Text;
                string a = Path.GetDirectoryName(path);

                DirectoryInfo d = new DirectoryInfo(textBoxRutaArchivo.Text);
                DirectoryInfo[] di = d.GetDirectories();
                FileInfo[] fi = d.GetFiles();
                List<Fichero> directorio = new List<Fichero>();

                

                int i = 0;
                while (i < di.Length)
                {
                    directorio.Add(new Fichero()
                    {
                        Nombre = di[i].Name,
                        Extension = di[i].Extension,
                        PesoArchivo = "Dir",
                        FechaModificacion = di[i].LastWriteTime
                        
                    });
                    i++;
                }

                int i2 = 0;
                while (i2 < fi.Length)
                {
                    directorio.Add(new Fichero()
                    {
                        Nombre = fi[i2].Name,
                        Extension = fi[i2].Extension,
                        PesoArchivo = fi[i2].Length/1024 +" Kb",
                        FechaModificacion = fi[i2].LastWriteTime
                        

                    });
                    i2++;
                }

                dataGridViewFicheros.DataSource = directorio;
            }
        }


        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtiene el elemento seleccionado en la GridView
            int filaSeleccionada = e.RowIndex;
            int columnaSeleccionada = e.ColumnIndex;
            string valorCelda = dataGridViewFicheros[columnaSeleccionada, filaSeleccionada].Value.ToString();

            // Abre el formulario secundario y le pasa los datos del elemento seleccionado
            ModificarArchivo_Directorio formularioSecundario = new ModificarArchivo_Directorio();
            formularioSecundario.ValorCelda = valorCelda;
            formularioSecundario.ShowDialog();
        }
    }
}
