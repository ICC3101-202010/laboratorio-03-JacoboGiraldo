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
        protected List<int> ActualizacionStock = new List<int>();
        protected List<string> ActualizacionProducto = new List<string>();

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
        public string SacarStock()
        {
            return Stock.ToString();
        }
        public string SacarNombre()
        {
            return Nombre_Producto;
        }
        public string SacarMarca()
        {
            return Marca;
        }

      
        
        public List<string> MostrarTodoActualizado(List<Productos> Productos, List<int> ActualStock)
        {
            for (int i = 0;i<Productos.Count;i++)
            {
                string Inf = Productos[i].SacarNombre() + "-" + Productos[i].SacarMarca() + "- Stock: " + ActualStock[i].ToString();
                ActualizacionProducto.Add(Inf);
            }
            
            return ActualizacionProducto;
        }

      
    }
}
