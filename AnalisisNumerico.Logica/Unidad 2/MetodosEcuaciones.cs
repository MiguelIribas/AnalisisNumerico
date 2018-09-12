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

        public MetodosEcuaciones()
        {
            this.ListaOriginal = new List<List<decimal>>();
            this.Contador = 0;
            this.FilaNormalizada = new List<decimal>();
        }

        public ResultadoEcuaciones ResolverEcuacion(ParametrosEcuaciones parametros)
        {
            this.ListaOriginal = parametros.ValoresIniciales;

            for (int i = 0; i <= parametros.ValoresIniciales.Count-1; i++)
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
            for (int i = 0; i <= ListaOriginal.Count-1; i++)
            {
                if (ListaOriginal[i]!=FilaNormalizada && ListaOriginal[i][columna]!=0)
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
                FilaNueva.Add(FilaAnterior[i]-( FilaNormalizada[i] * FilaAnterior[columna] ));
            }
            ListaOriginal[fila] = FilaNueva;      
        }

        public ResultadoEcuaciones AveriguarIncognitas()
        {
            List<decimal> ValoresIncognitas = new List<decimal>();

            int Incognitas = ListaOriginal[0].Count-1;

            for (int i = 0; i <= ListaOriginal.Count-1; i++)
            {
                ValoresIncognitas.Add(ListaOriginal[i][Incognitas]);
            }

            ResultadoEcuaciones resultado = new ResultadoEcuaciones();
            resultado.ResultadosEcuaciones = ValoresIncognitas;
            resultado.TipoResultado = TipoResultado.Ecuacion;
            this.Contador = 0;

            return resultado;
        }

    }
}
