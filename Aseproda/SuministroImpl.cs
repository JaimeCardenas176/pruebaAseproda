

using Aseproda.excepciones;

namespace Aseproda
{
    public class SuministroImpl : Suministro {
        public int NumeroSurtidor { get; }
        public DateTime FechaHoraRealizacion { get; }
        public decimal ImportePrefijado { get; }
        public decimal ImporteFinal { get; }

        public SuministroImpl(int numeroSurtidor, DateTime fechaHoraRealizacion, decimal importePrefijado, decimal importeFinal)
        {
            ValidarNumeroSurtidor(numeroSurtidor);
            ValidarFechaHoraRealizacion(fechaHoraRealizacion);
            ValidarImportePrefijado(importePrefijado);
            ValidarImporteFinal(importeFinal);
        }

        private void ValidarNumeroSurtidor(int numeroSurtidor)
        {
            if (numeroSurtidor <= 0)
            {
                throw new SurtidorNoValidoException("Número de surtidor no válido.");
            }
        }

        private void ValidarFechaHoraRealizacion(DateTime fechaHoraRealizacion)
        {
            if (fechaHoraRealizacion > DateTime.Now)
            {
                throw new FechaEnElFuturoException("La fecha y hora de realización no pueden estar en el futuro.");
            }
        }

        private void ValidarImportePrefijado(decimal importePrefijado)
        {
            if (importePrefijado < 0)
            {
                throw new ImporteNegativoException("El importe prefijado no puede ser negativo.");
            }
        }

        private void ValidarImporteFinal(decimal importeFinal)
        {
            if (importeFinal < 0)
            {
                throw new ImporteNegativoException("El importe final no puede ser negativo.");
            }
        }
    }
}
