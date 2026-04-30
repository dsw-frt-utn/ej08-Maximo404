using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        //Metodo auxilr para el metodo ObtenerEtiquetaProducto, que formatea el precio a moneda local
        private string FormatearPrecio(decimal price)
        {
            return price.ToString("C");
        }
    }
}
