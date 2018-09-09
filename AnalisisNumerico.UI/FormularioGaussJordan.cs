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
    public partial class FormularioGaussJordan : Form
    {
        private readonly IEcuaciones MetodosEcuaciones;

        public FormularioGaussJordan(IEcuaciones metodosecuaciones)
        {
            InitializeComponent();
            this.MetodosEcuaciones = metodosecuaciones;

            this.Grilla.Visible = false;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            this.Grilla.Visible = true;
            this.DibujarGrilla(Convert.ToInt32(txtboxNumeroIncognitas.Text), Convert.ToInt32(txtboxNumeroEcuaciones.Text));
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
            List<List<int>> Sistema = new List<List<int>>();
            List<int> Ecuacion = new List<int>();

            Sistema = new List<List<int>>();
            int ecuaciones = Convert.ToInt32(txtboxNumeroEcuaciones.Text);
            int incognitas = Convert.ToInt32(txtboxNumeroIncognitas.Text);

            for (int i = 0; i <=ecuaciones-1; i++)
            {
                Ecuacion = new List<int>();

                for (int z = 0; z <= incognitas; z++)
                {
                    Ecuacion.Add(Convert.ToInt32(Grilla.Rows[i].Cells[z].Value));
                }
                Sistema.Add(Ecuacion);
            }
            ParametrosEcuaciones parametros = new ParametrosEcuaciones();
            parametros.ValoresIniciales = Sistema;

            MetodosEcuaciones.ResolverEcuacion(parametros);
        }
    }
}
