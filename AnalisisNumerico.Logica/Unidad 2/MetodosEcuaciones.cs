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
        public List<List<decimal>> ListaResultante { get; set; }
        public List<List<decimal>> ListaOriginal { get; set; }
        public List<decimal> ListaNormalizada { get; set; }
        public int Contador { get; set; }

        public MetodosEcuaciones()
        {
            this.ListaResultante = new List<List<decimal>>();
            this.Contador = 0;
            this.ListaNormalizada = new List<decimal>();
        }

        public ResultadoEcuaciones ResolverEcuacion(ParametrosEcuaciones parametros)
        {
            this.ListaOriginal = parametros.ValoresIniciales;

            for (int i = 0; i < parametros.ValoresIniciales.Count - 1; i++)
            {
                this.Contador += 1;
                this.Ordenar();
                this.Normalizar();
                this.FilasNuevas();

            }
            return new ResultadoEcuaciones();
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
            this.ListaNormalizada = ListaOriginal[Contador - 1];
            decimal valor = ListaOriginal[Contador - 1][Contador - 1];

            for (int i = 0; i < ListaNormalizada.Count; i++)
            {
                ListaNormalizada[i] = ListaNormalizada[i] / valor;
            }
          
            ListaOriginal[Contador - 1] = ListaNormalizada;
        }

        public void FilasNuevas()
        {
            for (int i = 0; i < ListaOriginal.Count; i++)
            {
                if (i!=Contador-1)
                {
                    List<decimal> FilaAnterior = ListaOriginal[i];

                    var ValorFilaAnterior = FilaAnterior[0];

                    List<decimal> FilaNormalizada = new List<decimal>();

                    for (int z = 0; z < ListaNormalizada.Count; z++)
                    {
                        FilaNormalizada.Add(ListaNormalizada[z] * ValorFilaAnterior);
                    }

                    List<decimal> FilaNueva = new List<decimal>();
                    for (int x = 0; x < FilaNormalizada.Count; x++)
                    {
                        FilaNueva.Add(FilaAnterior[x] - FilaNormalizada[x]);
                    }
                    ListaOriginal[i] = FilaNueva;

                }
            }
        }

    }
}
