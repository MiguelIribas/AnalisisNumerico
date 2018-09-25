using AnalisisNumerico.Entidades.Ecuaciones;
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
    public partial class FormularioSistemasEcuaciones : Form
    {
        private readonly IEcuaciones MetodosEcuaciones;

        public FormularioSistemasEcuaciones(IEcuaciones metodosecuaciones)
        {
            InitializeComponent();
            this.MetodosEcuaciones = metodosecuaciones;
            this.Grilla.Visible = false;
            this.GrillaResultado.Visible = false;
            this.btnCalcular.Visible = false;
            this.Resultado.Visible = false;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            this.Grilla.Visible = true;
            this.btnAplicar.Enabled = false;
            this.DibujarGrilla(Convert.ToInt32(txtboxNumeroIncognitas.Text), Convert.ToInt32(txtboxNumeroEcuaciones.Text));
            this.btnCalcular.Visible = true;
        }

        private void DibujarGrilla(int incognitas, int ecuaciones)
        {
            //preguntar como hacer listas genericas con x,y,z

            for (int i = 0; i < incognitas; i++)
            {
                this.Grilla.Columns.Add("Incognita" + Convert.ToString(i + 1), "X" + Convert.ToString(i + 1));
            }

            this.Grilla.Columns.Add("Resultado", "Resultado");

            for (int i = 0; i < ecuaciones; i++)
            {
                this.Grilla.Rows.Add();
            }

            Grilla.AllowUserToAddRows = false;            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (comboMetodo.Text=="GAUSS-SEIDEL" && !(txtboxIteraciones.Text != "" && txtboxTolerancia.Text != ""))
            {
                MessageBox.Show("No se colocaron correctamente los parametros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.btnCalcular.Enabled = false;
            List<List<decimal>> Sistema = new List<List<decimal>>();
            List<decimal> Ecuacion = new List<decimal>();

            Sistema = new List<List<decimal>>();
            int ecuaciones = Convert.ToInt32(txtboxNumeroEcuaciones.Text);
            int incognitas = Convert.ToInt32(txtboxNumeroIncognitas.Text);

            for (int i = 0; i <= ecuaciones - 1; i++)
            {
                Ecuacion = new List<decimal>();

                for (int z = 0; z <= incognitas; z++)
                {
                    Ecuacion.Add(Convert.ToDecimal(Grilla.Rows[i].Cells[z].Value));
                }
                Sistema.Add(Ecuacion);
            }

            ResultadoEcuaciones resultado = new ResultadoEcuaciones();

            if (comboMetodo.Text=="GAUSS-JORDAN")
            {
                ParametrosEcuaciones parametros = new ParametrosEcuaciones();
                parametros.ValoresIniciales = Sistema;
                 
                resultado = MetodosEcuaciones.ResolverEcuacionGaussJordan(parametros);
            }
            else
            {
                ParametrosGaussSeidel parametros = new ParametrosGaussSeidel();
                parametros.ValoresIniciales = Sistema;
                parametros.Iteraciones = Convert.ToInt32(txtboxIteraciones.Text);
                parametros.Tolerancia=Convert.ToDecimal(txtboxTolerancia.Text);
                resultado = MetodosEcuaciones.ResolverEcuacionGaussSeidel(parametros);
            }                

            switch (resultado.TipoResultado)
            {
                case TipoResultado.Ecuacion:
                    this.Resultado.Visible = true;
                    this.Resultado.Height = 40;
                    this.Resultado.Text = "SE ENCONTRARON LOS VALORES DE LAS INCOGNITAS CORRECTAMENTE";
                    this.DibujarGrillaResultado(incognitas, resultado.ResultadosEcuaciones);
                    break;
                case TipoResultado.NoDD:
                    this.Resultado.Visible = true;
                    this.Resultado.Height = 80;
                    this.Resultado.Text = "EL SISTEMA INGRESADO NO ES DIAGONALMENTE DOMINANTE. INGRESE NUEVAMENTE";
                    break;
                default:
                    break;
            }
        }

        private void DibujarGrillaResultado(int incognitas, List<decimal> Valores)
        {
            this.GrillaResultado.Visible = true;

            for (int i = 0; i < incognitas; i++)
            {
                this.GrillaResultado.Columns.Add("Incognita" + Convert.ToString(i + 1), "X" + Convert.ToString(i + 1));
            }

            this.GrillaResultado.Rows.Add();

            for (int i = 0; i <= Valores.Count-1; i++)
            {
                this.GrillaResultado[i, 0].Value = Valores[i];
            }

            GrillaResultado.AllowUserToAddRows = false;
        }

        private void btnLimpiarPantalla_Click(object sender, EventArgs e)
        {
            this.Grilla.Visible = false;
            this.GrillaResultado.Visible = false;
            this.Resultado.Visible = false;
            this.btnCalcular.Visible = false;
            this.btnAplicar.Enabled = true;
            this.btnCalcular.Enabled = true;
            this.Grilla.Rows.Clear();
            this.Grilla.Columns.Clear();
            this.GrillaResultado.Rows.Clear();
            this.GrillaResultado.Columns.Clear();

            this.txtboxNumeroEcuaciones.Text = "";
            this.txtboxNumeroIncognitas.Text = "";
            this.txtboxTolerancia.Text = "";
            this.txtboxIteraciones.Text = "";
        }

        private void comboMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMetodo.Text == "GAUSS-JORDAN")
            {
                labelGaussJordan.Visible = true;
                labelGaussSeidel.Visible = false;         
                labelIteraciones.Visible = false;
                txtboxIteraciones.Visible = false;
                labelTolerancia.Visible = false;
                txtboxTolerancia.Visible = false;
            }
            else
            {
                labelGaussJordan.Visible = false;
                labelGaussSeidel.Visible = true;
                labelIteraciones.Visible = true;
                txtboxIteraciones.Visible = true;
                labelTolerancia.Visible = true;
                txtboxTolerancia.Visible = true;
            }
        }

        private void FormularioGaussJordan_Load(object sender, EventArgs e)
        {
            List<string> NombresMetodos = new List<string>();
            NombresMetodos.Add("GAUSS-JORDAN");
            NombresMetodos.Add("GAUSS-SEIDEL");

            comboMetodo.DataSource = NombresMetodos;

            this.Grilla.DefaultCellStyle.Font = new Font("Arial", 12);
            this.GrillaResultado.DefaultCellStyle.Font = new Font("Arial", 12);
            this.Grilla.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.GrillaResultado.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
