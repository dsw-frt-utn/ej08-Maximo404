using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_2
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            if(quantity < 0)
            {
                quantity = 0;
            }

            var producto = new { Code = productCode, Description = productDescription, Quantity = quantity, Total = quantity * unitPrice };
            return $"{producto.Code} - {producto.Description} - {producto.Total:C}";
        }
    }
}
