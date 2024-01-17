using Aseproda;
using Aseproda.excepciones;


namespace TestPista
{
    [TestClass]
    public class PistaImplTests
    {
        [TestMethod]
        public void LiberarSurtidor_DeberiaCambiarEstadoALibre()
        {
            // Arrange
            PistaImpl pista = new PistaImpl(5);  

            // Act
            pista.LiberarSurtidor(1);  

            Assert.AreEqual(EstadoSurtidor.Libre, pista.ObtenerEstadoSurtidores().First());
        }

        [TestMethod]
        public void PrefijarImporte_DeberiaCambiarImporteEnSurtidor()
        {
            PistaImpl pista = new PistaImpl(5);  // Cambia el número de surtidores según tu necesidad


            pista.PrefijarImporte(1, 50);  


            var estadoSurtidor = pista.ObtenerEstadoSurtidores().First();
            Assert.AreEqual(EstadoSurtidor.Prefijado, estadoSurtidor);
            Assert.AreEqual(50, pista.encuentraSurtidor(1).ImportePrefijado);
        }

        [TestMethod]
        public void RegistrarSuministro_ConImporteNegativo_DeberiaLanzarImporteNegativoException()
        {
            PistaImpl pista = new PistaImpl(5);  

            Assert.ThrowsException<ImporteNegativoException>(() => pista.RegistrarSuministro(1, -10));
        }

    }
}
