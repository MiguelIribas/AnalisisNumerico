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
            this.Grilla.Rows.Clear();
            this.Grilla.Columns.Clear();
        }

        private void FormularioMinimosCuadrados_Load(object sender, EventArgs e)
        {
            List<string> NombresMetodos = new List<string>();
            NombresMetodos.Add("REGRESION LINEAL - MINIMOS CUADRADOS");
            NombresMetodos.Add("POLINOMIOS DE LAGRANGE");

            comboMetodo.DataSource = NombresMetodos;

            this.Grilla.DefaultCellStyle.Font = new Font("Arial", 12);
            this.Grilla.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            this.Grilla.Visible = true;
            this.btnAplicar.Enabled = false;
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
            this.btnCalcular.Enabled = false;
            List<decimal> ValoresX = new List<decimal>();
            List<decimal> ValoresY = new List<decimal>();

            int cantidadvalores = Convert.ToInt32(txtboxCantidadValores.Text);

            for (int i = 0; i <= cantidadvalores - 1; i++)
            {
                ValoresX = new List<decimal>();
                ValoresY = new List<decimal>();
                ValoresX.Add(Convert.ToDecimal(Grilla.Rows[i].Cells[0].Value));
                ValoresY.Add(Convert.ToDecimal(Grilla.Rows[i].Cells[1].Value));
            }


            ResultadoMinimosCuadrados resultado = new ResultadoMinimosCuadrados();

            if (comboMetodo.Text == "REGRESION LINEAL - MINIMOS CUADRADOS")
            {
                ParametrosMinimosCuadrados parametros = new ParametrosMinimosCuadrados();
                parametros.ValoresX = ValoresX;
                parametros.ValoresY = ValoresY;

                resultado = MinimosCuadrados.ResolverCurva(parametros);
            }
            else
            {
            }



        }
    }
}
