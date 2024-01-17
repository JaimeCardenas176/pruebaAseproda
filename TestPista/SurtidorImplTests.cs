using Aseproda.excepciones;
using Aseproda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPista
{
    [TestClass]
    public class SurtidorImplTests
    {
        [TestMethod]
        public void Constructor_ConNumeroSurtidorNegativo_DeberiaLanzarSurtidorNoValidoException()
        {
            // Arrange
            int numeroSurtidor = -1;

            // Act y Assert
            Assert.ThrowsException<SurtidorNoValidoException>(() =>
                new SurtidorImpl(numeroSurtidor));
        }

        [TestMethod]
        public void LiberarSurtidor_DeberiaCambiarEstadoALibre()
        {
            // Arrange
            SurtidorImpl surtidor = new SurtidorImpl(1);

            // Act
            surtidor.LiberarSurtidor();

            // Assert
            Assert.AreEqual(EstadoSurtidor.Libre, surtidor.ObtenerEstado());
        }

        [TestMethod]
        public void PrefijarImporte_ConImporteNegativo_DeberiaLanzarImporteNegativoException()
        {
            // Arrange
            SurtidorImpl surtidor = new SurtidorImpl(1);
            decimal importeNegativo = -50;

            // Act y Assert
            Assert.ThrowsException<ImporteNegativoException>(() =>
                surtidor.PrefijarImporte(importeNegativo));
        }

        [TestMethod]
        public void PrefijarImporte_DeberiaCambiarEstadoAPrefijado()
        {
            // Arrange
            SurtidorImpl surtidor = new SurtidorImpl(1);
            decimal importePrefijado = 50;

            // Act
            surtidor.PrefijarImporte(importePrefijado);

            // Assert
            Assert.AreEqual(EstadoSurtidor.Prefijado, surtidor.ObtenerEstado());
            Assert.AreEqual(importePrefijado, surtidor.ImportePrefijado);
        }

        [TestMethod]
        public void BloquearSurtidor_DeberiaCambiarEstadoABloqueado()
        {
            // Arrange
            SurtidorImpl surtidor = new SurtidorImpl(1);

            // Act
            surtidor.BloquearSurtidor();

            // Assert
            Assert.AreEqual(EstadoSurtidor.Bloqueado, surtidor.ObtenerEstado());
        }

    }
}
