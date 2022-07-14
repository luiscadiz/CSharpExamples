using System;
using System.Collections.Generic;

namespace Ejemplo
{
    public abstract class Documento
    {
        //Relación de agragación
        private Cliente _cliente;
        //Relación de composición
        private List<Item> _items;
        public int Numero {get; set;}
        public DateTime Fecha {get; set;}
        public Sucursal sucursal {get; set;}
        public Cliente Cliente
        {
            get{
                return _cliente;
            }
            set{
                _cliente = value;
            }
        }

        public Documento(int numero, DateTime fecha, Cliente cliente)
        {
            if(cliente == null) 
                throw new Exception("Imposible crear una factura sin un cliente asociado");
            Numero = numero;
            Fecha = fecha;
            //El cliente que llega es una referencia que llega desde afuera, por 
            //lo que si destruye el documento no se destruira el cliente.
            Cliente = cliente;
            //Esto permite asegurarnos que la referencia a items este dentro del documento para asi
            // si se destruye el documento tambien se destruye la lista de items
            _items = new List<Item>();  
        }

        public void AgregarItems(string descripcion, double precio, int cantidad)
        {
            //Referencia de Item dentro del mismo objeto
            //Con esto nos aseguramos que los ciclos de vida de ambos objetos esten atados.
            Item item = new Item(descripcion,precio,cantidad);
            _items.Add(item);
        }

        //No es aconsejable exponer Una lista a travez de un get ya que este devuelve una referencia 
        //al objeto por lo que se estaria violando el encapsulamiento.
        // public List<Item> Items
        // {
        //     get{
        //         return _items;
        //     }
        // }

        //Para solucionar el problema del rompimiento del encapsulamiento, se puede usar
        //Una interfaz del tipo IReadonlyCollectión que nos garantiza que sera de solo lectura.

        public IReadonlyCollectión<Item> Items
        {
            get{
                return _items.AsReadOnly();
            }
        }
    }
}