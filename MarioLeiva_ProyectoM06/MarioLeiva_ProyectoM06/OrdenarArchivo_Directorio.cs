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
    public partial class OrdenarArchivo_Directorio : Form
    {
        public string ordenar { get; set; }
        string orden = "Ascendente";
        
        public OrdenarArchivo_Directorio()
        {
            InitializeComponent();
            ordenar = "NombreAscendente";
        }



        private void radioButtonNombre_CheckedChanged(object sender, EventArgs e)
        {
            ordenar = radioButtonNombre.Text+orden;
        }

        private void radioButtonFecha_CheckedChanged(object sender, EventArgs e)
        {
            ordenar = "Fecha" + orden;
        }

        private void radioButtonTipo_CheckedChanged(object sender, EventArgs e)
        {
            ordenar = "Tipo" + orden;
        }

        private void radioButtonSize_CheckedChanged(object sender, EventArgs e)
        {
            ordenar = "Tamaño" + orden;
        }

        private void buttonAplicar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orden aplicado correctamente");
            this.Close();
        }

        private void ascendente_CheckedChanged(object sender, EventArgs e)
        {
            orden = ascendente.Text;
        }

        private void descendente_CheckedChanged(object sender, EventArgs e)
        {
            orden = descendente.Text;
        }
    }
}
