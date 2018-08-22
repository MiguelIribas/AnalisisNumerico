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
        private readonly IMetodosCerrados metodosRaices;

        public FormularioMetodosCerrados(IMetodosCerrados metodosRaices)
        {
            InitializeComponent();
            this.metodosRaices = metodosRaices;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ParametrosMetodosCerrados parametros = new ParametrosMetodosCerrados();

            parametros.Funcion = txtboxFuncion.Text;
            parametros.Iteraciones = Convert.ToInt32(txtboxIteraciones.Text);
            parametros.Tolerancia = Convert.ToDouble(txtboxTolerancia.Text);
            parametros.ValorInicial = Convert.ToDouble(txtboxLimiteMinimo.Text);
            parametros.ValorFinal = Convert.ToDouble(txtboxLimiteMaximo.Text);

            Resultado resultado = new Resultado();
               
            if (comboMetodo.Text=="BISECCION")
            {
                parametros.TipoMetodoCerrado = TipoMetodoCerrado.Biseccion;
                resultado=this.metodosRaices.MetodoBiseccion(parametros);
            }
            else
            {
                parametros.TipoMetodoCerrado = TipoMetodoCerrado.ReglaFalsa;
                resultado= this.metodosRaices.MetodoReglaFalsa(parametros);
            }

            labelResultado.Text = resultado.Mensaje;
            txtRaiz.Text = Convert.ToString(resultado.Raiz);
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
