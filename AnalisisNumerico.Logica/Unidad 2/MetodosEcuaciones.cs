using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisNumerico.Entidades.Ecuaciones;
using org.mariuszgromada.math.mxparser;


namespace AnalisisNumerico.Logica.Unidad_2
{
    public class MetodosEcuaciones:IEcuaciones
    {
        public List<List<int>> ListaResultante { get; set; }
        public List<List<int>> ListaOriginal { get; set; }
        public int Contador { get; set; }

        public MetodosEcuaciones()
        {           
            this.ListaResultante = new List<List<int>>();
            this.Contador = 0;
        }

        public ResultadoEcuaciones ResolverEcuacion(ParametrosEcuaciones parametros)
        {
            this.ListaOriginal = parametros.ValoresIniciales;

            for (int i = 0; i < parametros.ValoresIniciales.Count-1; i++)
            {
                this.Contador += 1;
                this.Ordenar();
            }
            return new ResultadoEcuaciones();
        }

        public void Ordenar()
        {
            if (ListaOriginal[Contador-1][Contador-1]==0)
            {
                var mayor = 0;
                var mayorlista = 0;

                for (int i = 0; i <= ListaOriginal.Count-1; i++)
                {
                    if (ListaOriginal[i][0]>mayor)
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

       
    }
}
