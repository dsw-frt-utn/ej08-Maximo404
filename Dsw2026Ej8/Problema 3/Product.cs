using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_3
{
    internal class Product
    {
        private int _code;
        private string _name;
        private string _description;
        private decimal _price;

        public Product(int code, string name, string description, decimal price)
        {
            _code = code;
            _name = name;
            _description = description;
            _price = price;
        }

        public string getDescription()
        {
            return this._description;
        }
        public void setDescription(string description)
        {
            this._description = description;
        }
    }
}
