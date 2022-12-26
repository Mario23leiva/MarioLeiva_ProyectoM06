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
    }
}
