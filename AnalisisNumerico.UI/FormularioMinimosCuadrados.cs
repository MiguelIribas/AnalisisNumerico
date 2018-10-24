using AnalisisNumerico.Entidades.AjusteDeCurvas;
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
    public partial class FormularioMinimosCuadrados : Form
    {
        private readonly IMinimosCuadrados MinimosCuadrados;

        public FormularioMinimosCuadrados(IMinimosCuadrados minimoscuadrados)
        {
            InitializeComponent();
            this.MinimosCuadrados = minimoscuadrados;
            this.Grilla.Visible = false;
            this.btnCalcular.Visible = false;
            this.Resultado.Visible = false;
        }

        private void btnLimpiarPantalla_Click(object sender, EventArgs e)
        {
            this.Grilla.Visible = false;
            this.Resultado.Visible = false;
            this.btnCalcular.Visible = false;
            this.btnAplicar.Enabled = true;
            this.btnCalcular.Enabled = true;
            this.labelAjuste.Visible = false;
            this.labelRecta.Visible = false;
            this.labelResultado.Visible = false;
            this.labelResultadoAjuste.Visible = false;
            this.labelCoeficiente.Visible = false;
            this.Resultado.Visible = false;
            this.txtboxRecta.Visible = false;
            this.labelResultadoCoeficiente.Visible = false;
            this.Grilla.Rows.Clear();
            this.Grilla.Columns.Clear();
            this.labelImagenY.Visible = false;
            this.labelImagenYResultado.Visible = false;
        }

        private void FormularioMinimosCuadrados_Load(object sender, EventArgs e)
        {
            List<string> NombresMetodos = new List<string>();
            NombresMetodos.Add("REGRESION LINEAL");
            NombresMetodos.Add("REGRESION POLINOMIAL");
            NombresMetodos.Add("POLINOMIO DE LAGRANGE");

            comboMetodo.DataSource = NombresMetodos;

            this.Grilla.DefaultCellStyle.Font = new Font("Arial", 12);
            this.Grilla.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.labelResultado.Visible = false;
            this.labelResultadoAjuste.Visible = false;
            this.labelResultadoCoeficiente.Visible = false;
            this.labelCoeficiente.Visible = false;
            this.labelRecta.Visible = false;
            this.labelAjuste.Visible = false;
            this.Resultado.Visible = false;
            this.txtboxRecta.Visible = false;
            this.labelGrado.Visible = false;
            this.txtGrado.Visible = false;
            this.labelImagenY.Visible = false;
            this.labelImagenYResultado.Visible = false;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            this.Grilla.Visible = true;
            this.btnAplicar.Enabled = false;

            if (txtboxCantidadValores.Text == "")
            {
                MessageBox.Show("No se colocaron correctamente los parametros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnAplicar.Enabled = true;
                return;
            }

            this.DibujarGrilla(Convert.ToInt32(txtboxCantidadValores.Text));
            this.btnCalcular.Visible = true;
        }

        private void DibujarGrilla(int cantidadvalores)
        {
            this.Grilla.Columns.Add("X","X");
            this.Grilla.Columns.Add("Y","Y");

            for (int i = 0; i < cantidadvalores; i++)
            {
                this.Grilla.Rows.Add();
            }

            Grilla.AllowUserToAddRows = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            List<decimal> ValoresX = new List<decimal>();
            List<decimal> ValoresY = new List<decimal>();

            int cantidadvalores = Convert.ToInt32(txtboxCantidadValores.Text);                  

            for (int i = 0; i <= cantidadvalores - 1; i++)
            {
                ValoresX.Add(Convert.ToDecimal(Grilla.Rows[i].Cells[0].Value));
                ValoresY.Add(Convert.ToDecimal(Grilla.Rows[i].Cells[1].Value));
            }
          
            ResultadoMinimosCuadrados resultado = new ResultadoMinimosCuadrados();

            if (comboMetodo.Text == "REGRESION LINEAL")
            {
                ParametrosMinimosCuadrados parametros = new ParametrosMinimosCuadrados();
                parametros.ValoresX = ValoresX;
                parametros.ValoresY = ValoresY;

                resultado = MinimosCuadrados.ResolverCurvaLineal(parametros);

                this.labelResultado.Visible = true;
                this.labelResultadoAjuste.Visible = true;
                this.labelResultadoCoeficiente.Visible = true;
                this.labelCoeficiente.Visible = true;
                this.labelRecta.Visible = true;
                this.labelAjuste.Visible = true;
                this.Resultado.Visible = true;
                this.txtboxRecta.Visible = true;

                this.labelResultadoAjuste.Text = resultado.Ajuste;
                this.txtboxRecta.Text = resultado.RectaMejorAjuste;
                this.Resultado.Text = "SE ENCONTRO LA RECTA DE MEJOR AJUSTE";
                this.labelResultadoCoeficiente.Text = Convert.ToString(resultado.CoeficientedeCorrelacion)+" %";
            }
            else
            {
                if (comboMetodo.Text == "REGRESION POLINOMIAL")
                {
                    ParametrosMinimosCuadrados parametros = new ParametrosMinimosCuadrados();
                    parametros.ValoresX = ValoresX;
                    parametros.ValoresY = ValoresY;

                    if (txtGrado.Text == "")
                    {
                        MessageBox.Show("No se colocaron correctamente los parametros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnCalcular.Enabled = true;
                        return;
                    }

                    parametros.Grado = Convert.ToInt32(txtGrado.Text);
                    if (textBoxValorX.Text!="")
                    {
                        parametros.ValorX = Convert.ToDecimal(textBoxValorX.Text);
                    }
                    
                    resultado = MinimosCuadrados.ResolverCurvaPolinomial(parametros);

                    this.labelResultado.Visible = true;
                    this.labelResultadoAjuste.Visible = true;
                    this.labelResultadoCoeficiente.Visible = true;
                    this.labelCoeficiente.Visible = true;
                    this.labelRecta.Visible = true;
                    this.labelAjuste.Visible = true;
                    this.Resultado.Visible = true;
                    this.txtboxRecta.Visible = true;
                    if (textBoxValorX.Text == "")
                    {
                        this.labelImagenY.Visible = false;
                        this.labelImagenYResultado.Visible = false;
                    }
                    else
                    {
                        this.labelImagenY.Visible = true;
                        this.labelImagenYResultado.Visible = true;
                    }

                    this.labelResultadoAjuste.Text = resultado.Ajuste;
                    this.txtboxRecta.Text = resultado.RectaMejorAjuste;
                    this.Resultado.Text = "SE ENCONTRO LA RECTA DE MEJOR AJUSTE";
                    this.labelResultadoCoeficiente.Text = Convert.ToString(resultado.CoeficientedeCorrelacion)+" %";
                    this.labelImagenYResultado.Text = Convert.ToString(resultado.Imagen);
                }
                else
                {
                    ParametrosMinimosCuadrados parametros = new ParametrosMinimosCuadrados();
                    parametros.ValoresX = ValoresX;
                    parametros.ValoresY = ValoresY;
                    if (textBoxValorX.Text != "")
                    {
                        parametros.ValorX = Convert.ToDecimal(textBoxValorX.Text);
                    }

                    resultado = MinimosCuadrados.ResolverPolinomioLagrange(parametros);

                    this.labelResultado.Visible = true;
                    this.labelResultadoAjuste.Visible = false;
                    this.labelResultadoCoeficiente.Visible = false;
                    this.labelCoeficiente.Visible = false;
                    this.labelRecta.Visible = true;
                    this.labelAjuste.Visible = false;
                    this.Resultado.Visible = true;
                    this.txtboxRecta.Visible = true;
                    if (textBoxValorX.Text=="")
                    {
                        this.labelImagenY.Visible = false;
                        this.labelImagenYResultado.Visible = false;
                    }
                    else
                    {
                        this.labelImagenY.Visible = true;
                        this.labelImagenYResultado.Visible = true;
                    }
                    
                    this.labelResultadoAjuste.Text = Convert.ToString(resultado.Imagen);
                    this.txtboxRecta.Text = resultado.RectaMejorAjuste;
                    this.Resultado.Text = "SE ENCONTRO LA RECTA DE MEJOR AJUSTE";
                    this.labelResultadoCoeficiente.Text = Convert.ToString(resultado.CoeficientedeCorrelacion);
                    this.labelImagenYResultado.Text = Convert.ToString(resultado.Imagen);
                }
               
            }



        }

        private void comboMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMetodo.Text == "REGRESION LINEAL")
            {
                this.labelLineal.Visible = true;
                this.labelPolinomial.Visible = false;
                this.labelLagrange.Visible = false;
                this.labelGrado.Visible = false;
                this.txtGrado.Visible = false;
                this.labelValorX.Visible = false;
                this.textBoxValorX.Visible = false;

            }
            else
            {
                if (comboMetodo.Text=="REGRESION POLINOMIAL")
                {
                    this.labelLineal.Visible = false;
                    this.labelPolinomial.Visible = true;
                    this.labelLagrange.Visible = false;
                    this.labelGrado.Visible = true;
                    this.txtGrado.Visible = true;
                    this.labelValorX.Visible = true;
                    this.textBoxValorX.Visible = true;
                }
                else
                {
                    this.labelLineal.Visible = false;
                    this.labelPolinomial.Visible = false;
                    this.labelLagrange.Visible = true;
                    this.labelGrado.Visible = false;
                    this.txtGrado.Visible = false;
                    this.labelValorX.Visible = true;
                    this.textBoxValorX.Visible = true;
                }
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
