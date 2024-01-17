

namespace Aseproda
{
    public interface Suministro
    {
        int NumeroSurtidor { get; }
        DateTime FechaHoraRealizacion { get; }
        decimal ImportePrefijado { get; }
        decimal ImporteFinal { get; }
    }
}
