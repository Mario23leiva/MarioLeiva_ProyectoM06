﻿using System;
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
    public partial class PantallaInicial : Form
    {
        public PantallaInicial()
        {
            InitializeComponent();
        }

        private void buttonEntrarAplicacion_Click(object sender, EventArgs e)
        {
            MenuInicial pantalla = new MenuInicial();
            this.Hide();
            pantalla.ShowDialog();
        }
    }
}
