
using Aseproda.excepciones;

namespace Aseproda
{
    public class SurtidorImpl : Surtidor {
        public int Numero { get; }
        public EstadoSurtidor Estado { get; private set; }
        public decimal ImportePrefijado { get; private set; }

        public SurtidorImpl(int numero) {
            ValidarNumeroSurtidor(numero);
            Numero = numero;
            Estado = EstadoSurtidor.Bloqueado; // Estado inicial bloqueado
            ImportePrefijado = 0;
        }

        public void LiberarSurtidor() {
            Estado = EstadoSurtidor.Libre;
            ImportePrefijado = 0;
        }

        public void PrefijarImporte(decimal importe) {

            ValidarImportePrefijado(importe);
            Estado = EstadoSurtidor.Prefijado;
            ImportePrefijado = importe;
        }

        public void BloquearSurtidor() {
            Estado = EstadoSurtidor.Bloqueado;
            ImportePrefijado = 0;
        }

        public EstadoSurtidor ObtenerEstado() {
            return Estado;
        }

        private void ValidarNumeroSurtidor(int numeroSurtidor)
        {
            if (numeroSurtidor <= 0)
            {
                throw new SurtidorNoValidoException("Número de surtidor no válido.");
            }
        }

        private void ValidarImportePrefijado(decimal importe)
        {
            if (importe < 0)
            {
                throw new ImporteNegativoException("El importe prefijado no puede ser negativo.");
            }
        }
    }
}
