using Aseproda.excepciones;
using Aseproda;
namespace TestPista
{
    [TestClass]
    public class SuministroImplTests
    {
        [TestMethod]
        public void Constructor_ConNumeroSurtidorNegativo_DeberiaLanzarSurtidorNoValidoException()
        {
            // Arrange
            int numeroSurtidor = -1;
            DateTime fechaHoraRealizacion = DateTime.Now;
            decimal importePrefijado = 50;
            decimal importeFinal = 100;

            // Act y Assert
            Assert.ThrowsException<SurtidorNoValidoException>(() =>
                new SuministroImpl(numeroSurtidor, fechaHoraRealizacion, importePrefijado, importeFinal));
        }

        [TestMethod]
        public void Constructor_ConFechaEnElFuturo_DeberiaLanzarFechaEnElFuturoException()
        {
            // Arrange
            int numeroSurtidor = 1;
            DateTime fechaHoraRealizacion = DateTime.Now.AddDays(1);
            decimal importePrefijado = 50;
            decimal importeFinal = 100;

            // Act y Assert
            Assert.ThrowsException<FechaEnElFuturoException>(() =>
                new SuministroImpl(numeroSurtidor, fechaHoraRealizacion, importePrefijado, importeFinal));
        }

        [TestMethod]
        public void Constructor_ConImportePrefijadoNegativo_DeberiaLanzarImporteNegativoException()
        {
            // Arrange
            int numeroSurtidor = 1;
            DateTime fechaHoraRealizacion = DateTime.Now;
            decimal importePrefijado = -50;
            decimal importeFinal = 100;

            // Act y Assert
            Assert.ThrowsException<ImporteNegativoException>(() =>
                new SuministroImpl(numeroSurtidor, fechaHoraRealizacion, importePrefijado, importeFinal));
        }

        [TestMethod]
        public void Constructor_ConImporteFinalNegativo_DeberiaLanzarImporteNegativoException()
        {
            // Arrange
            int numeroSurtidor = 1;
            DateTime fechaHoraRealizacion = DateTime.Now;
            decimal importePrefijado = 50;
            decimal importeFinal = -100;

            // Act y Assert
            Assert.ThrowsException<ImporteNegativoException>(() =>
                new SuministroImpl(numeroSurtidor, fechaHoraRealizacion, importePrefijado, importeFinal));
        }
    }
}
