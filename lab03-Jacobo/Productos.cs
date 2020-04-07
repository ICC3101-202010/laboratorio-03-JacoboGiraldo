﻿using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Productos
    {
        protected string Nombre_Producto;
        protected int Precio;
        protected string Marca;
        protected int Stock;

        protected List<Productos> ProductosTotal = new List<Productos>();
        protected List<string> Boletas = new List<string>();

        public Productos(string Nombre_Producto, int Precio, string Marca, int Stock)
        {
            this.Nombre_Producto = Nombre_Producto;
            this.Precio = Precio;
            this.Marca = Marca;
            this.Stock = Stock;
        }
        public void AgregarProductos(Productos ProductoCualquiera)
        {
            ProductosTotal.Add(ProductoCualquiera);
        }
        public string PYPYM()
        {
            string Inf = "Producto: " + Nombre_Producto + "- Marca: " + Marca + "- Precio: " + Precio.ToString()+"\n";
            return Inf;
        }
        public int SacarPrecio()
        {
            return Precio;
        }
        
        

      
    }
}
