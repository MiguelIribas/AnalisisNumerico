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
    public partial class Biseccion : Form
    {
        private readonly IMetodosRaices metodosRaices;

        public Biseccion(IMetodosRaices metodosRaices)
        {
            InitializeComponent();
            this.metodosRaices = metodosRaices;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
