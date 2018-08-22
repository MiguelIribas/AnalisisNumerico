namespace AnalisisNumerico.Entidades
{
    public class ParametrosMetodosCerrados
    {
        public string Funcion { get; set; }

        public double ValorInicial { get; set; }

        public double ValorFinal { get; set; }

        public int Iteraciones { get; set; }

        public double Tolerancia { get; set; }

        public TipoMetodoCerrado TipoMetodoCerrado { get; set; }
    }
}

public enum TipoMetodoCerrado
{
    Biseccion, ReglaFalsa
}
