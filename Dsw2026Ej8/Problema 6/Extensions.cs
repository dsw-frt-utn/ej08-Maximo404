using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_6
{
    public static class Extensions
    {
        public static string ToProductCode(this string productCode)
        {
            string productCodeRedy = "SIN-CODIGO";

            if(productCode != null)
            {
                productCodeRedy = productCode.Trim().ToUpper().Replace(" ", "-");
            }

            return productCodeRedy;
            
        }
    }
}
