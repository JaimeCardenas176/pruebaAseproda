
namespace Aseproda.excepciones
{
    public class SurtidorNoValidoException : Exception
    {
        public SurtidorNoValidoException() : base("Número de surtidor no válido.")
        {
        }

        public SurtidorNoValidoException(string? message) : base(message)
        {
        }
    }
}
