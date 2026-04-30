namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper producto1 = new ProductHelper();

            Console.WriteLine($"{producto1.ObtenerEtiquetaProducto(111, "Jugo Ades", 3000)}");

        }
    }
}
