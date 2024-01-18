using Aseproda.excepciones;

namespace Aseproda
{
    public class PistaImpl {

        private readonly List<Surtidor> surtidores;
        private readonly List<Suministro> historialSuministros;

        public PistaImpl(int cantidadSurtidores)    {
            surtidores = new List<Surtidor>();
            for (int i = 1; i <= cantidadSurtidores; i++) {
                Surtidor surtidor = new SurtidorImpl(i);
                surtidores.Add(surtidor);
            }
            historialSuministros = new List<Suministro>();
        }

        public void LiberarSurtidor(int numeroSurtidor)
        {
            var surtidor = encuentraSurtidor(numeroSurtidor);
            surtidor?.LiberarSurtidor();
        }

        public void PrefijarImporte(int numeroSurtidor, decimal importe)
        {
            var surtidor = encuentraSurtidor(numeroSurtidor);
            surtidor?.PrefijarImporte(importe);
        }

        public void BloquearSurtidor(int numeroSurtidor)
        {
            var surtidor = encuentraSurtidor(numeroSurtidor);
            surtidor?.BloquearSurtidor();
        }

        public List<EstadoSurtidor> ObtenerEstadoSurtidores()
        {
            return surtidores.Select(s => s.ObtenerEstado()).ToList();
        }

        public void RegistrarSuministro(int numeroSurtidor, decimal importeFinal)
        {
            var surtidor = encuentraSurtidor(numeroSurtidor);
            if (surtidor != null)
            {
                  
                  var suministro = new SuministroImpl(surtidor.Numero, DateTime.Now, surtidor.ImportePrefijado, importeFinal);
                  historialSuministros.Add(suministro);
                  surtidor.BloquearSurtidor();
            }
        }

        public List<Suministro> ObtenerHistorialSuministros()
        {
            return historialSuministros
                .OrderByDescending(s => s.ImporteFinal)
                .ThenByDescending(s => s.FechaHoraRealizacion)
                .ToList();
        }

        public Surtidor encuentraSurtidor(int numeroSurtidor)
        {
            if (numeroSurtidor <= 0 || numeroSurtidor > surtidores.Count)
            {
                throw new SurtidorNoValidoException();
            }

            var surtidor = surtidores.Find(s => s.Numero == numeroSurtidor);
            if (surtidor != null)
            {
                return surtidor;
            }
            else
            {
                throw new SurtidorNoValidoException();
            }
        }
    }
}
