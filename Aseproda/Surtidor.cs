
namespace Aseproda
{
    public interface Surtidor {

        int Numero { get; }
        EstadoSurtidor Estado { get; }
        decimal ImportePrefijado { get; }

        void LiberarSurtidor();

        void PrefijarImporte(decimal importe);

        void BloquearSurtidor();

        EstadoSurtidor ObtenerEstado();
    }
}

