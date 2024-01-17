
namespace Aseproda.excepciones
{
    public class SurtidorBloqueadoException : Exception
    {
        public SurtidorBloqueadoException() : base("El surtidor está bloqueado y no se puede realizar la operación.")
        {
        }
    }
}
