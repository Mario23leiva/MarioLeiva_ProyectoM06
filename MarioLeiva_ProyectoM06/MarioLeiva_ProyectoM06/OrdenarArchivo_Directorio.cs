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
        public OrdenarArchivo_Directorio()
        {
            InitializeComponent();
        }

        public OrdenarArchivo_Directorio(string orden)
        {
            InitializeComponent();
            ordenar = orden;
        }



        private void radioButtonNombre_CheckedChanged(object sender, EventArgs e)
        {
            ordenar = radioButtonNombre.Text;
        }

        private void radioButtonFecha_CheckedChanged(object sender, EventArgs e)
        {
            ordenar = radioButtonFecha.Text;
        }

        private void radioButtonTipo_CheckedChanged(object sender, EventArgs e)
        {
            ordenar = radioButtonTipo.Text;
        }

        private void radioButtonSize_CheckedChanged(object sender, EventArgs e)
        {
            ordenar = radioButtonSize.Text;
        }

        private void buttonAplicar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orden aplicado correctamente");
            this.Close();
        }
        
    }
}
