﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisisNumerico.Entidades;

namespace AnalisisNumerico.UI
{
    public partial class InicioForm : Form
    {
        private readonly IMetodosRaices metodosRaices;

        public InicioForm(IMetodosRaices metodosRaices)
        {
            this.metodosRaices = metodosRaices;

            InitializeComponent();
        }

        private void InicioForm_Load(object sender, EventArgs e)
        {

        }

        private void bISECCIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Biseccion FormularioBiseccion = new Biseccion();
            FormularioBiseccion.Owner = this;
            FormularioBiseccion.ShowDialog();
        }
    }
}
