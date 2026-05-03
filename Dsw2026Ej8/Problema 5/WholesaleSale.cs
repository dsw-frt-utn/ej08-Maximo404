using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_5
{
    internal class WholesaleSale : Sale
    {
        protected decimal _descuento = 0;

        public WholesaleSale(decimal descuento, string nom, int amount, decimal price) : base(price, nom, amount)
        {
            _descuento =descuento;            
        }
        public override decimal CalculateTotal()
        {
            return base._price - (base._price * _descuento); ;
        }
    }
}
