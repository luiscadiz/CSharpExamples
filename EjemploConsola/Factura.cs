using System;

namespace Ejemplo
{
    public class Factura : Documento
    {
        public Factura(int numero, DateTime fecha, Cliente cliente)
            : base(numero,fecha,cliente) {}
    }
}