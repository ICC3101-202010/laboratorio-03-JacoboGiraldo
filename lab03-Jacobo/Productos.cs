using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Productos
    {
        protected string Nombre_Producto { get; set; }
        protected int Precio { get; set; }
        protected string Marca { get; set; }
        protected int Stock { get; set; }

        public Productos()
        {
        }
    }
}
