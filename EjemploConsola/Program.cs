using System;

namespace Ejemplo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = "Luis";
            cliente.Apellido = "Cadiz";

            Documento doc = new Factura(100, DateTime.Now, cliente);

            Documento doc2 = new Factura(200, DateTime.Now, cliente);

            Sucursal sucursal = new Sucursal("Jujuy al 100");

            doc.AgregarItems("ina descripción de prueba,",100,10);

            doc.Items.Add(new Item("Otra descripción de prueba",10,11));

            Console.ReadKey();
        }
    }
}
