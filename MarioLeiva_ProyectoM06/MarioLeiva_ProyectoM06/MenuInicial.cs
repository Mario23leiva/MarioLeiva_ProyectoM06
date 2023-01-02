using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using static System.Net.Mime.MediaTypeNames;

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
            String json = ConvertirDataGridViewAJson(dataGridViewFicheros, textBoxRutaArchivo.Text);
            CrearJSON crearJson = new CrearJSON(json);
            crearJson.ShowDialog();
        }

        public void botonExaminar_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog ruta = new FolderBrowserDialog();
            if (ruta.ShowDialog().Equals(DialogResult.OK))
            {
                cargarDatosEnDataGrid(ruta.SelectedPath);
            }

        }

        private void botonLeerJSON_Click(object sender, EventArgs e)
        {
            OpenFileDialog ruta = new OpenFileDialog();

            if (ruta.ShowDialog().Equals(DialogResult.OK))
            {
                MostrarJsonEnDataGridView(dataGridViewFicheros, ruta.FileName);
            }

        }

        // Clase para representar los datos de cada fila de la DataGridView
        public class Fila
        {
            public string Nombre { get; set; }
            public string Extension { get; set; }
            public string PesoArchivo { get; set; }
            public DateTime FechaModificacion { get; set; }
        }

        // Método que convierte los datos de una DataGridView en un archivo JSON
        public string ConvertirDataGridViewAJson(DataGridView dataGridView, string rutaArchivo)
        {
            // Crear una lista para almacenar las instancias de la clase Fila
            List<Fila> filas = new List<Fila>();

            // Recorrer las filas de la DataGridView y crear una instancia de la clase Fila para cada una
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                Fila fila = new Fila();
                fila.Nombre = row.Cells[0].Value.ToString();
                fila.Extension = row.Cells[1].Value.ToString();
                fila.PesoArchivo = row.Cells[2].Value.ToString();
                fila.FechaModificacion = DateTime.Parse(row.Cells[3].Value.ToString());
                filas.Add(fila);
            }

            // Serializar la lista a una cadena JSON
            string json = JsonConvert.SerializeObject(filas);

            return json;
        }

        // Método que muestra los datos de un archivo JSON en una DataGridView
        public void MostrarJsonEnDataGridView(DataGridView dataGridView, string rutaArchivo)
        {
            // Leer el archivo JSON en una cadena
            string json = File.ReadAllText(rutaArchivo);

            // Deserializar la cadena a una lista de instancias de la clase Fila
            List<Fila> filas = JsonConvert.DeserializeObject<List<Fila>>(json);

            // Asignar la lista como el origen de datos de la DataGridView
            dataGridView.DataSource = filas;
        }
        

        public void cargarDatosEnDataGrid(string ruta)
        {
            dataGridViewFicheros.DataSource = null;

            textBoxRutaArchivo.Text = ruta;
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
                    PesoArchivo = fi[i2].Length / 1024 + " Kb",
                    FechaModificacion = fi[i2].LastWriteTime


                });
                i2++;
            }

            dataGridViewFicheros.DataSource = directorio;
        }



        private void botonEliminar_Click(object sender, EventArgs e)
        {
            // Obtener la ruta del archivo o directorio seleccionado
            string ruta = textBoxRutaArchivo.Text+"\\"+dataGridViewFicheros.SelectedCells[0].Value.ToString();

            


            // Comprobar si la ruta corresponde a un archivo o a un directorio
            if (File.Exists(ruta))
            {
                // Es un archivo, eliminarlo
                File.Delete(ruta);
            }
            else if (Directory.Exists(ruta))
            {
                // Es un directorio, eliminarlo
                Directory.Delete(ruta);
            }

            // Actualizar la DataGridView para reflejar los cambios
            dataGridViewFicheros.DataSource = null;

            cargarDatosEnDataGrid(ruta);
            

        }
    }
}
