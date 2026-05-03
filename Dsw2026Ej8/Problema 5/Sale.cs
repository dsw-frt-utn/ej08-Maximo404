using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_5
{
    internal class Sale
    {
        protected string _nom = "";
        protected int _amount = 0;
        protected decimal _price = 0;
        

        public Sale(decimal price, string nom, int amount)
        {
            _price = price;
            _amount = amount;
            _nom = nom;
        }

        public virtual decimal CalculateTotal()
        {
            return _price*_amount;
        }
    }
}
