﻿namespace AnalisisNumerico.Entidades
{
    public class Resultado
    {
        public double? Raiz { get; set; }

        public int Iteraciones { get; set; }

        public double? Error { get; set; }

        public string Mensaje { get; set; }

        public TipoResultado TipoResultado { get; set; }
    }

    public enum TipoResultado
    {
        Raiz,Constante,FueradeLimites,FuncionIncorrecta,MasRaices
    }
}
