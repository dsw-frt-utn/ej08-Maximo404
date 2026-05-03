using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_5
{
    internal class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            decimal importeFinal = sale.CalculateTotal();
            return importeFinal;
        }
    }
}
