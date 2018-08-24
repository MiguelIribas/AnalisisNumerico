
namespace AnalisisNumerico.Entidades
{
    public interface IMetodosCerrados
    {
        Resultado MetodoBiseccion(ParametrosRaiz parametros);

        Resultado MetodoReglaFalsa(ParametrosRaiz parametros);
    }
}
