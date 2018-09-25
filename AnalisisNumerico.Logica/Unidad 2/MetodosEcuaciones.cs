using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisNumerico.Entidades.Ecuaciones;
using org.mariuszgromada.math.mxparser;


namespace AnalisisNumerico.Logica.Unidad_2
{
    public class MetodosEcuaciones : IEcuaciones
    {
        public List<List<decimal>> ListaOriginal { get; set; }
        public List<decimal> FilaNormalizada { get; set; }
        public int Contador { get; set; }
        public List<List<decimal>> IncognitasDespejadas { get; set; }
        public List<decimal> Solucion { get; set; }
        public List<decimal> SolucionAnterior { get; set; }

        public MetodosEcuaciones()
        {
            this.ListaOriginal = new List<List<decimal>>();
            this.Contador = 0;
            this.FilaNormalizada = new List<decimal>();
            this.IncognitasDespejadas = new List<List<decimal>>();
            this.Solucion = new List<decimal>();
            this.SolucionAnterior = new List<decimal>();
        }

        //GAUSS-JORDAN
        public ResultadoEcuaciones ResolverEcuacionGaussJordan(ParametrosEcuaciones parametros)
        {
            this.ListaOriginal = parametros.ValoresIniciales;

            for (int i = 0; i <= parametros.ValoresIniciales.Count - 1; i++)
            {
                this.Contador += 1;
                this.Ordenar();
                this.Normalizar();
                this.Bloque(i);
            }
            return AveriguarIncognitas();
        }

        public void Ordenar()
        {
            if (ListaOriginal[Contador - 1][Contador - 1] == 0)
            {
                decimal mayor = 0;
                int mayorlista = 0;

                for (int i = 0; i <= ListaOriginal.Count - 1; i++)
                {
                    if (ListaOriginal[i][0] > mayor)
                    {
                        mayor = ListaOriginal[i][0];
                        mayorlista = i;
                    }
                }
                var Temporal = ListaOriginal[Contador - 1];
                ListaOriginal[Contador - 1] = ListaOriginal[mayorlista];
                ListaOriginal[mayorlista] = Temporal;
            }
        }

        public void Normalizar()
        {
            this.FilaNormalizada = ListaOriginal[Contador - 1];
            decimal valor = ListaOriginal[Contador - 1][Contador - 1];

            for (int i = 0; i < FilaNormalizada.Count; i++)
            {
                FilaNormalizada[i] = FilaNormalizada[i] / valor;
            }

            ListaOriginal[Contador - 1] = FilaNormalizada;
        }

        public void Bloque(int columna)
        {
            for (int i = 0; i <= ListaOriginal.Count - 1; i++)
            {
                if (ListaOriginal[i] != FilaNormalizada && ListaOriginal[i][columna] != 0)
                {
                    this.FilasNuevas(ListaOriginal[i], i, columna);
                }
            }
        }

        public void FilasNuevas(List<decimal> FilaAnterior, int fila, int columna)
        {
            List<decimal> FilaNueva = new List<decimal>();

            for (int i = 0; i < FilaAnterior.Count; i++)
            {
                FilaNueva.Add(FilaAnterior[i] - (FilaNormalizada[i] * FilaAnterior[columna]));
            }
            ListaOriginal[fila] = FilaNueva;
        }

        public ResultadoEcuaciones AveriguarIncognitas()
        {
            List<decimal> ValoresIncognitas = new List<decimal>();

            int Incognitas = ListaOriginal[0].Count - 1;

            for (int i = 0; i <= ListaOriginal.Count - 1; i++)
            {
                ValoresIncognitas.Add(Math.Round(ListaOriginal[i][Incognitas], 4));
            }

            ResultadoEcuaciones resultado = new ResultadoEcuaciones();
            resultado.ResultadosEcuaciones = ValoresIncognitas;
            resultado.TipoResultado = TipoResultado.Ecuacion;
            this.Contador = 0;

            return resultado;
        }

        //GAUSS-SEIDEL
        public ResultadoEcuaciones ResolverEcuacionGaussSeidel(ParametrosGaussSeidel parametros)
        {
            ResultadoEcuaciones resultado = new ResultadoEcuaciones();
            this.ListaOriginal = parametros.ValoresIniciales;
            bool DD = this.DiagonalmenteDominante();

            if (DD == false)
            {
                resultado.TipoResultado = TipoResultado.NoDD;
                resultado.ResultadosEcuaciones = new List<decimal>();
            }
            else
            {
                this.DespejarIncognitas();
                this.InicializarSolucion();
                bool soluciones = false;

                while (!(soluciones == true || (Contador >= parametros.Iteraciones)))
                {
                    this.AveriguarSolucion();
                    this.Contador += 1;
                    soluciones = CompararSoluciones(parametros.Tolerancia);
                }
                resultado.ResultadosEcuaciones = Solucion;
                resultado.TipoResultado = TipoResultado.Ecuacion;               
            }
            return resultado;
        }

        public bool CompararSoluciones(decimal tolerancia)
        {
            bool Ok = false; //True --> Error relativo menor a tolerancia
            int contador = 0;
            for (int i = 0; i <= Solucion.Count - 1; i++)
            {
                if (((Solucion[i] - SolucionAnterior[i]) / Solucion[i]) <= tolerancia)
                {
                    contador += 1;
                }
            }
            if (contador==Solucion.Count)
            {
                Ok = true;
            }
            return Ok;
        }

        public bool DiagonalmenteDominante()
        {
            bool resultado = true;

            for (int i = 0; i <= ListaOriginal.Count - 1; i++)
            {
                decimal suma = 0;

                for (int x = 0; x <= ListaOriginal[i].Count - 2; x++)
                {
                    if (x != i)
                    {
                        suma += Math.Abs(ListaOriginal[i][x]);
                    }
                }

                if (Math.Abs(ListaOriginal[i][i]) <= suma)
                {
                    resultado = false;
                }
            }
            return resultado;
        }

        public void DespejarIncognitas()
        {
            for (int i = 0; i <= ListaOriginal.Count - 1; i++)
            {
                List<decimal> Ecuacion = new List<decimal>();
                decimal valor = ListaOriginal[i][i];

                for (int x = 0; x <= ListaOriginal[i].Count - 1; x++)
                {
                    if (x == i)
                    {
                        Ecuacion.Add(0);
                    }
                    else
                    {
                        if (x == ListaOriginal[i].Count - 1)
                        {
                            Ecuacion.Add(ListaOriginal[i][x] / valor);
                        }
                        else
                        {
                            Ecuacion.Add((ListaOriginal[i][x] / valor) * -1);
                        }
                    }
                }
                IncognitasDespejadas.Add(Ecuacion);
            }
        }

        public void AveriguarSolucion()
        {
            this.SolucionAnterior = new List<decimal>(Solucion);

            for (int filas = 0; filas <= IncognitasDespejadas.Count - 1; filas++)
            {
                decimal total = 0;
                for (int columnas = 0; columnas <= IncognitasDespejadas[filas].Count - 2; columnas++)
                {
                    decimal resultado = IncognitasDespejadas[filas][columnas] * Solucion[columnas];
                    total += resultado;
                }
                total += IncognitasDespejadas[filas][IncognitasDespejadas.Count];
                this.Solucion[filas] = Math.Round(total, 4);
            }
        }

        public void InicializarSolucion()
        {
            for (int i = 0; i <= ListaOriginal.Count - 1; i++)
            {
                this.Solucion.Add(0);
                this.SolucionAnterior.Add(0);
            }
        }


    }
}
