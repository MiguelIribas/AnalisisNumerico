using AnalisisNumerico.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico.UI
{
    public partial class FormularioMetodosCerrados : Form
    {
        private readonly IMetodosRaices metodosRaices;

        public FormularioMetodosCerrados(IMetodosRaices metodosRaices)
        {
            InitializeComponent();
            this.metodosRaices = metodosRaices;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void MetodosCerrados_Load(object sender, EventArgs e)
        {
            List<string> NombresMetodos = new List<string>();
            NombresMetodos.Add("BISECCION");
            NombresMetodos.Add("REGLA FALSA");

            comboMetodo.DataSource = NombresMetodos;

        }

        private void comboMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMetodo.Text=="BISECCION")
            {
                labelBiseccion.Visible = true;
                labelReglaFalsa.Visible = false;  
            }
            else
            {
                labelBiseccion.Visible = false;
                labelReglaFalsa.Visible = true;
            }
        }
    }
}
