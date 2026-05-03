using Dsw2026Ej8.Problema_2;
using Dsw2026Ej8.Problema_3;
using Dsw2026Ej8.Problema_4;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una instancia de ProductHelper
            ProductHelper producto1 = new ProductHelper();
            Console.WriteLine($"{producto1.ObtenerEtiquetaProducto(111, "Jugo Ades", 3000)}");

            //Problema 2
            Problema2 producto2 = new Problema2();
            Console.WriteLine($"{producto2.CrearResumenVenta(112, "Bon o Bon", 10, 600)}");

            //Problema 3
            Problema3 producto3 = new Problema3();
            Console.WriteLine($"{producto3.CompararCopias(15, new Product(113, "Bagio", "Jugo Bagio", 1800))}");

            //Problema 4 
            Problema4 promedio1 = new Problema4();
            Console.WriteLine($"{promedio1.CalcularPromedio(8, 10, 9)}");
            Console.WriteLine($"{promedio1.CalcularPromedio(8, 6, null)}");
            Console.WriteLine($"{promedio1.CalcularPromedio(-1, 11, 8)}");

            
        }
    }
}
