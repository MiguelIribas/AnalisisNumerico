namespace AnalisisNumerico.Entidades
{
    public class ParametrosRaiz
    {
        public string Funcion { get; set; }

        public double ValorInicial { get; set; }

        public double ValorFinal { get; set; }

        public int Iteraciones { get; set; }

        public double Tolerancia { get; set; }

        public TipoMetodo TipoMetodo { get; set; }
    }
}

public enum TipoMetodo
{
    Biseccion, ReglaFalsa, Tangente, Secante
}
