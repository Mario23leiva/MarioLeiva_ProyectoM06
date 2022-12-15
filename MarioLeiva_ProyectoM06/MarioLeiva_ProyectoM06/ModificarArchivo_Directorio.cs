using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarioLeiva_ProyectoM06
{
    public partial class ModificarArchivo_Directorio : Form
    {
        string nombreArchivo;

        public string ValorCelda { get; set; }

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

            this.Close();

        }


    }
}
