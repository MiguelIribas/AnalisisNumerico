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
        private readonly IMetodosCerrados metodosRaices;

        public InicioForm(IMetodosCerrados metodosRaices)
        {
            this.metodosRaices = metodosRaices;

            InitializeComponent();
        }

        private void InicioForm_Load(object sender, EventArgs e)
        {

        }

        private void MetodosCerradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioMetodosCerrados FormularioMetodosCerrados = Program.container.GetInstance<FormularioMetodosCerrados>();
            FormularioMetodosCerrados.Owner = this;
            FormularioMetodosCerrados.ShowDialog();
        }

        private void mETODOSABIERTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioMetodosAbiertos FormularioMetodosAbiertos = Program.container.GetInstance<FormularioMetodosAbiertos>();
            FormularioMetodosAbiertos.Owner = this;
            FormularioMetodosAbiertos.ShowDialog();
        }

        private void sISTEMADEECUACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioSistemasEcuaciones FormularioSistemasEcuaciones = Program.container.GetInstance<FormularioSistemasEcuaciones>();
            FormularioSistemasEcuaciones.Owner = this;
            FormularioSistemasEcuaciones.ShowDialog();
        }

        private void aJUSTEDECURVASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioMinimosCuadrados FormularioMinimosCuadrados = Program.container.GetInstance<FormularioMinimosCuadrados>();
            FormularioMinimosCuadrados.Owner = this;
            FormularioMinimosCuadrados.ShowDialog();
        }

        private void iNTEGRACIONNUMERICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioIntegracionNumerica FormularioIntegracionNumerica = Program.container.GetInstance<FormularioIntegracionNumerica>();
            FormularioIntegracionNumerica.Owner = this;
            FormularioIntegracionNumerica.ShowDialog();
        }

    }
}
