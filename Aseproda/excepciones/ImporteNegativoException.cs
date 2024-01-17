using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aseproda.excepciones
{
    public class ImporteNegativoException : Exception
    {
        public ImporteNegativoException() : base("El importe no puede ser negativo.")
        {
        }

        public ImporteNegativoException(string? message) : base(message)
        {
        }
    }
}
