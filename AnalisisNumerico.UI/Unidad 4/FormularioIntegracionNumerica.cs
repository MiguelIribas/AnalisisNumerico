using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisisNumerico.Entidades.IntegracionNumerica;
using AnalisisNumerico.Logica.Unidad_4;

namespace AnalisisNumerico.UI
{
    public partial class FormularioIntegracionNumerica : Form
    {
        private readonly IIntegracionNumerica integracionnumerica;
        public FormularioIntegracionNumerica(IIntegracionNumerica integracionnumerica)
        {
            InitializeComponent();
            this.integracionnumerica = integracionnumerica;
        }

        private void FormularioIntegracionNumerica_Load(object sender, EventArgs e)
        {
            List<string> NombresMetodos = new List<string>();
            NombresMetodos.Add("TRAPECIO SIMPLE");
            NombresMetodos.Add("TRAPECIO MULTIPLE");
            NombresMetodos.Add("SIMPSON 1/3 SIMPLE");
            NombresMetodos.Add("SIMPSON 1/3 MULTIPLE");

            comboMetodo.DataSource = NombresMetodos;

            labelTrapecioSimple.Visible = true;
            labelTrapecioMultiple.Visible = false;
            labelSimpsonSimple.Visible = false;
            labelSimpsonMultiple.Visible = false;
            labelSimpson38.Visible = false;
            labelValorIntegral.Visible = false;
            txtboxValorIntegral.Visible = false;
            lblSimpson13.Visible = false;
            txtSimpson13.Visible = false;
            lblSimpson38.Visible = false;
            txtSimpson38.Visible = false;
        }

        private void comboMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboMetodo.SelectedIndex)
            {
                case 0: //Trapecio Simple
                    labelTrapecioSimple.Visible = true;
                    labelTrapecioMultiple.Visible = false;
                    labelSimpsonSimple.Visible = false;
                    labelSimpsonMultiple.Visible = false;
                    labelSimpson38.Visible = false;
                    labelCantidadSubintervalos.Visible = false;
                    txtboxCantidadIntervalos.Visible = false;
                    break;
                case 1: //Trapecio Multiple
                    labelTrapecioSimple.Visible = false;
                    labelTrapecioMultiple.Visible = true;
                    labelSimpsonSimple.Visible = false;
                    labelSimpsonMultiple.Visible = false;
                    labelSimpson38.Visible = false;
                    labelCantidadSubintervalos.Visible = true;
                    txtboxCantidadIntervalos.Visible = true;
                    break;
                case 2: //Simpson 1/3 simple
                    labelTrapecioSimple.Visible = false;
                    labelTrapecioMultiple.Visible = false;
                    labelSimpsonSimple.Visible = true;
                    labelSimpsonMultiple.Visible = false;
                    labelSimpson38.Visible = false;
                    labelCantidadSubintervalos.Visible = false;
                    txtboxCantidadIntervalos.Visible = false;
                    break;
                case 3: //Simpson 1/3 Multiple
                    labelTrapecioSimple.Visible = false;
                    labelTrapecioMultiple.Visible = false;
                    labelSimpsonSimple.Visible = false;
                    labelSimpsonMultiple.Visible = true;
                    labelSimpson38.Visible = false;
                    labelCantidadSubintervalos.Visible = true;
                    txtboxCantidadIntervalos.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ParametrosIntegracionNumerica parametros = new ParametrosIntegracionNumerica();
            ResultadoIntegracionNumerica resultado = new ResultadoIntegracionNumerica();

            switch (comboMetodo.SelectedIndex)
            {               
                case 0: //Trapecio Simple
                    parametros.Funcion = txtboxFuncion.Text;
                    parametros.ValorExtremo1 =Convert.ToDouble(txtBoxExtremo1.Text);
                    parametros.ValorExtremo2 = Convert.ToDouble(txtBoxExtremo2.Text);
                    resultado = integracionnumerica.ResolverTrapecioSimple(parametros);               
                    break;
                case 1: //Trapecio Multiple
                    parametros.Funcion = txtboxFuncion.Text;
                    parametros.CantidadSubintervalos = Convert.ToInt32(txtboxCantidadIntervalos.Text);
                    parametros.ValorExtremo1 = Convert.ToDouble(txtBoxExtremo1.Text);
                    parametros.ValorExtremo2 = Convert.ToDouble(txtBoxExtremo2.Text);
                    resultado = integracionnumerica.ResolverTrapecioMultiple(parametros);
                    break;
                case 2: //Simpson 1/3 simple
                    parametros.Funcion = txtboxFuncion.Text;
                    parametros.ValorExtremo1 = Convert.ToDouble(txtBoxExtremo1.Text);
                    parametros.ValorExtremo2 = Convert.ToDouble(txtBoxExtremo2.Text);
                    resultado = integracionnumerica.ResolverSimpson13Simple(parametros);
                    break;
                case 3: //Simpson 1/3 Multiple
                    parametros.Funcion = txtboxFuncion.Text;
                    parametros.CantidadSubintervalos = Convert.ToInt32(txtboxCantidadIntervalos.Text);
                    parametros.ValorExtremo1 = Convert.ToDouble(txtBoxExtremo1.Text);
                    parametros.ValorExtremo2 = Convert.ToDouble(txtBoxExtremo2.Text);                    
                    resultado = integracionnumerica.ResolverSimpson13Multiple(parametros);
                    break;
            }

            labelValorIntegral.Visible = true;
            txtboxValorIntegral.Visible = true;
            txtboxValorIntegral.Text = Convert.ToString(Math.Abs(Math.Round(resultado.ValorIntegral,4)));
            if (parametros.CantidadSubintervalos%2!=0)
            {
                lblSimpson13.Visible = true;
                txtSimpson13.Visible = true;
                lblSimpson38.Visible = true;
                txtSimpson38.Visible = true;

                txtSimpson13.Text= Convert.ToString(Math.Abs(Math.Round(resultado.Simpson13, 4)));
                txtSimpson38.Text = Convert.ToString(Math.Abs(Math.Round(resultado.Simpson38, 4)));
            }        
        }

        private void btnLimpiarPantalla_Click(object sender, EventArgs e)
        {
            labelValorIntegral.Visible = false;
            txtboxValorIntegral.Visible = false;
            lblSimpson38.Visible = false;
            lblSimpson13.Visible = false;
            txtSimpson13.Visible = false;
            txtSimpson38.Visible = false;
            txtboxValorIntegral.Text = "";
        }
    }
}
