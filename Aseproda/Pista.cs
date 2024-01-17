
namespace Aseproda
{
    public interface Pista {
        void liberarSurtidor(uint idSurtidor);

        void prefijarSurtidor(uint idSurtidor);

        void bloquearSurtidor(uint idSurtidor);

        void obtenerEstado();

        List<Suministro> historialDeSuminnistros();
    }
}
