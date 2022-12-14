using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarioLeiva_ProyectoM06
{
    public partial class ModificarArchivo_Directorio : Form
    {
        string nombreArchivo;

        public ModificarArchivo_Directorio()
        {
            InitializeComponent();
        }

        public ModificarArchivo_Directorio(string texto)
        {
            InitializeComponent();
            this.nombreArchivo = texto;
            textBoxNombreAntiguo.Text = texto;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreNuevo = textBoxNombreNuevo.Text;
            MenuInicial menuInicial = new MenuInicial(nombreNuevo);
            menuInicial.Show();
            
        }
    }
}
