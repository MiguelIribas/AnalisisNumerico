
namespace AnalisisNumerico.Entidades
{
    public interface IMetodosCerrados
    {
        Resultado MetodoBiseccion(ParametrosMetodosCerrados parametros);

        Resultado MetodoReglaFalsa(ParametrosMetodosCerrados parametros);
    }
}
