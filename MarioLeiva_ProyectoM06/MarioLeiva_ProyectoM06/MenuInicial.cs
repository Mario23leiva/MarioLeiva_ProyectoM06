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

        public string nombreArchivo, filtrar = "Todo", ordenar = "NombreAscendente";
        string filaSeleccionada;
        public DateTime cutoffDate { get; set; }
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
            if (crearArchivo_Directorio.ShowInTaskbar)
            {
                cargarDatosEnDataGrid(textBoxRutaArchivo.Text);
            }
            
        }

        private void botonOrdenar_Click(object sender, EventArgs e)
        {
            OrdenarArchivo_Directorio ordenarArchivo_Directorio = new OrdenarArchivo_Directorio();
            ordenarArchivo_Directorio.ShowDialog();
            if (ordenarArchivo_Directorio.ShowInTaskbar)
            {
                ordenar = ordenarArchivo_Directorio.ordenar;
                cargarDatosEnDataGrid(textBoxRutaArchivo.Text);
            }
        }

        private void botonFiltrar_Click(object sender, EventArgs e)
        {
            FiltrarArchivo_Directorio filtrarArchivo_Directorio = new FiltrarArchivo_Directorio(filtrar);
            filtrarArchivo_Directorio.ShowDialog();
            
            if (filtrarArchivo_Directorio.ShowInTaskbar)
            {
                filtrar = filtrarArchivo_Directorio.filtro;
                cargarDatosEnDataGrid(textBoxRutaArchivo.Text);
            }
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            filaSeleccionada = cogerRutaCompleta();
            ModificarArchivo_Directorio modificarArchivo_Directorio = new ModificarArchivo_Directorio(filaSeleccionada, textBoxRutaArchivo.Text);
            modificarArchivo_Directorio.ShowDialog();
            if (modificarArchivo_Directorio.ShowInTaskbar)
            {
                cargarDatosEnDataGrid(textBoxRutaArchivo.Text);
            }

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

        public class Fila
        {
            public string Nombre { get; set; }
            public string Extension { get; set; }
            public string PesoArchivo { get; set; }
            public DateTime FechaModificacion { get; set; }
        }

        public string ConvertirDataGridViewAJson(DataGridView dataGridView, string rutaArchivo)
        {

            List<Fila> filas = new List<Fila>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                Fila fila = new Fila();
                fila.Nombre = row.Cells[0].Value.ToString();
                fila.Extension = row.Cells[1].Value.ToString();
                fila.PesoArchivo = row.Cells[2].Value.ToString();
                fila.FechaModificacion = DateTime.Parse(row.Cells[3].Value.ToString());
                filas.Add(fila);
            }
            string json = JsonConvert.SerializeObject(filas);

            return json;
        }
        public void MostrarJsonEnDataGridView(DataGridView dataGridView, string rutaArchivo)
        {
            
            string json = File.ReadAllText(rutaArchivo);
            List<Fila> filas = JsonConvert.DeserializeObject<List<Fila>>(json);
            dataGridView.DataSource = filas;
        }
        

        public void cargarDatosEnDataGrid(string ruta)
        {
            dataGridViewFicheros.DataSource = null;

            textBoxRutaArchivo.Text = ruta;
            string path = textBoxRutaArchivo.Text;

            DirectoryInfo d = new DirectoryInfo(textBoxRutaArchivo.Text);
            DirectoryInfo[] di = d.GetDirectories();
            FileInfo[] fi = d.GetFiles();
            List<Fichero> directorio = new List<Fichero>();
            if (filtrar.Equals("Todo") || filtrar.Equals("Directorios"))
            {
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
            }

            if (filtrar.Equals("Todo") || filtrar.Equals("Archivos"))
            {
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
            }
            if (ordenar.Equals("NombreAscendente"))
            {
                directorio = directorio.OrderBy(o => o.Nombre).ToList();
            }
            else if (ordenar.Equals("NombreDescendente"))
            {
                directorio = directorio.OrderByDescending(o => o.Nombre).ToList();
            }
            else if (ordenar.Equals("FechaAscendente"))
            {
                directorio = directorio.OrderBy(o => o.FechaModificacion).ToList();
            }
            else if (ordenar.Equals("FechaDescendente"))
            {
                directorio = directorio.OrderByDescending(o => o.FechaModificacion).ToList();
            }
            else if (ordenar.Equals("TipoAscendente"))
            {
                directorio = directorio.OrderBy(o => o.Extension).ToList();
            }
            else if (ordenar.Equals("TipoDescendente"))
            {
                directorio = directorio.OrderByDescending(o => o.Extension).ToList();
            }
            else if (ordenar.Equals("TamañoAscendente"))
            {
                directorio = directorio.OrderBy(o => o.PesoArchivo).ToList();
            }
            else if (ordenar.Equals("TamañoDescendente"))
            {
                directorio = directorio.OrderByDescending(o => o.PesoArchivo).ToList();
            }

            directorio = directorio.Where(f => f.FechaModificacion.Day.CompareTo(cutoffDate.Day) > 0 && f.FechaModificacion.Month.CompareTo(cutoffDate.Month) > 0 && f.FechaModificacion.Year.CompareTo(cutoffDate.Year) > 0).ToList();




            dataGridViewFicheros.DataSource = directorio;
        }




        private void botonEliminar_Click(object sender, EventArgs e)
        {


            string ruta = cogerRutaCompleta();
            


            if (File.Exists(ruta))
            {
                File.Delete(ruta);
                MessageBox.Show("Se ha eliminado correctamente");
                dataGridViewFicheros.DataSource = null;
                cargarDatosEnDataGrid(textBoxRutaArchivo.Text);
            }
            else if (Directory.Exists(ruta))
            {
                Directory.Delete(ruta);
                MessageBox.Show("Se ha eliminado correctamente");
                dataGridViewFicheros.DataSource = null;
                cargarDatosEnDataGrid(textBoxRutaArchivo.Text);
            }

            else
            {
                MessageBox.Show("Error\nSelecciona el nombre del elemento a eliminar");
            }
        }

        public string cogerRutaCompleta()
        {
            int w = dataGridViewFicheros.SelectedCells[0].RowIndex;
            string i = dataGridViewFicheros.Rows[w].Cells[0].Value.ToString();
            string ruta = textBoxRutaArchivo.Text + "\\" + i;
            return ruta;
        }
    }
}
