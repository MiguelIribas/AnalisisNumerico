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
    public partial class FormularioMetodosAbiertos : Form
    {
        private readonly IMetodosAbiertos metodosRaices;

        public FormularioMetodosAbiertos(IMetodosAbiertos metodosRaices)
        {
            InitializeComponent();
            this.metodosRaices = metodosRaices;
        }

        private void FormularioMetodosAbiertos_Load(object sender, EventArgs e)
        {
            List<string> NombresMetodos = new List<string>();
            NombresMetodos.Add("NEWTON-RAPHSON (TANGENTE)");
            NombresMetodos.Add("SECANTE");

            comboMetodo.DataSource = NombresMetodos;

            labelResultado.Visible = false;
            labelDetalles.Visible = false;
            labelRaiz.Visible = false;
            txtRaiz.Visible = false;
            labelIteraciones.Visible = false;
            labelIteracionesResultado.Visible = false;
            labelError.Visible = false;
            labelErrorResultado.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ParametrosRaiz parametros = new ParametrosRaiz();

            if (txtboxFuncion.Text != "" && txtboxIteraciones.Text != "" && txtboxLimiteMinimo.Text != "" && txtboxTolerancia.Text != "")
            {
                if (comboMetodo.Text == "SECANTE" && txtboxLimiteMaximo.Text != "")
                {
                    parametros.ValorFinal = Convert.ToDouble(txtboxLimiteMaximo.Text);
                }
                parametros.Funcion = txtboxFuncion.Text;
                parametros.Iteraciones = Convert.ToInt32(txtboxIteraciones.Text);
                parametros.Tolerancia = Convert.ToDouble(txtboxTolerancia.Text);
                parametros.ValorInicial = Convert.ToDouble(txtboxLimiteMinimo.Text);
            }
            else
            {
                MessageBox.Show("No se colocaron correctamente los parametros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Resultado resultado = new Resultado();

            if (comboMetodo.Text == "SECANTE")
            {
                parametros.TipoMetodo = TipoMetodo.Secante;
                resultado = this.metodosRaices.MetodoSecante(parametros);
            }
            else
            {
                parametros.TipoMetodo = TipoMetodo.Tangente;
                resultado = this.metodosRaices.MetodoTangente(parametros);
            }

            if (resultado.TipoResultado == TipoResultado.Raiz)
            {
                labelResultado.Height = 40;
                labelResultado.Text = resultado.Mensaje;
                labelResultado.Visible = true;
                labelDetalles.Visible = true;
                labelRaiz.Visible = true;
                txtRaiz.Visible = true;
                labelIteraciones.Visible = true;
                labelIteracionesResultado.Visible = true;
                labelError.Visible = true;
                labelErrorResultado.Visible = true;

                labelResultado.Text = resultado.Mensaje;
                labelErrorResultado.Text = Convert.ToString(resultado.Error);
                labelIteracionesResultado.Text = Convert.ToString(resultado.Iteraciones);
                txtRaiz.Text = Convert.ToString(resultado.Raiz);
            }

            if (resultado.TipoResultado == TipoResultado.FueradeLimites || resultado.TipoResultado == TipoResultado.FuncionIncorrecta)
            {
                labelResultado.Height = 40;
                labelResultado.Text = resultado.Mensaje;
                labelResultado.Visible = true;
                labelDetalles.Visible = false;
                labelRaiz.Visible = false;
                txtRaiz.Visible = false;
                labelIteraciones.Visible = false;
                labelIteracionesResultado.Visible = false;
                labelError.Visible = false;
                labelErrorResultado.Visible = false;
            }

            if (resultado.TipoResultado==TipoResultado.Constante)
            {
                labelResultado.Text = resultado.Mensaje;
                labelResultado.Visible = true;
                labelResultado.Height = 80;
                labelDetalles.Visible = false;
                labelRaiz.Visible = false;
                txtRaiz.Visible = false;
                labelIteraciones.Visible = false;
                labelIteracionesResultado.Visible = false;
                labelError.Visible = false;
                labelErrorResultado.Visible = false;
            }
        }

        private void comboMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMetodo.Text == "SECANTE")
            {
                labelSecante.Visible = true;
                labelTangente.Visible = false;
                labelLimiteMaximo.Visible = true;
                txtboxLimiteMaximo.Visible = true;
            }
            else
            {
                labelSecante.Visible = false;
                labelTangente.Visible = true;
                labelLimiteMaximo.Visible = false;
                txtboxLimiteMaximo.Visible = false;
            }
        }

        private void btnLimpiarPantalla_Click(object sender, EventArgs e)
        {
            labelResultado.Visible = false;
            labelDetalles.Visible = false;
            labelRaiz.Visible = false;
            txtRaiz.Visible = false;
            labelIteraciones.Visible = false;
            labelIteracionesResultado.Visible = false;
            labelError.Visible = false;
            labelErrorResultado.Visible = false;

            txtboxFuncion.Text = "";
            txtboxIteraciones.Text = "";
            txtboxLimiteMaximo.Text = "";
            txtboxLimiteMinimo.Text = "";
            txtboxTolerancia.Text = "";
        }
    }
}
