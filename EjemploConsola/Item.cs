
namespace Ejemplo
{
    public class Item
    {
        public string Descripción { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public Item(string descripción,double precio, int cantidad)
        {
            Descripción = descripción;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}