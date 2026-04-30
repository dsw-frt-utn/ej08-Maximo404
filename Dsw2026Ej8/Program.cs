using Dsw2026Ej8.Problema_2;

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

        }
    }
}
