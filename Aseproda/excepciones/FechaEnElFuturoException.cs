using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseproda.excepciones
{
    public class FechaEnElFuturoException : Exception
    {
        public FechaEnElFuturoException() : base("La fecha y hora de realización no pueden estar en el futuro.")
        {
        }

        public FechaEnElFuturoException(string? message) : base(message)
        {
        }
    }
}
