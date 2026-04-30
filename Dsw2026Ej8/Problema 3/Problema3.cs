using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_3
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copyValue = originalValue++;
            Product p = product;
            p.setDescription("Coquita :)");
            return $"{originalValue} - {copyValue} - {p.getDescription()}";
        }
    }
}
