using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_5
{
    internal class RetailSale : Sale
    {
        public RetailSale(decimal price, string nom, int amount) : base(price, nom, amount)
        {
        }

        public override decimal CalculateTotal()
        {
            return base._price;
        }
    }
}
