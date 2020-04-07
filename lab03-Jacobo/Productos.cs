using System;
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
        protected string InfoBoleta;
        public void Venta_Producto(Cliente ClienteX, Cajeros CajeroX, List<Productos> Productos)
        {
            //Registrar todo de la compra (Nombre Cliente, Nombre Cajero, Lista Productos, Fecha y Hora)
            int TotalPrecio = 0;
            InfoBoleta += "Fecha de la compra: " + DateTime.Now;
            InfoBoleta += "Cliente: " + ClienteX.NombreCliente() +"\n";
            InfoBoleta += "Atendido por el Cajero: " + CajeroX.NombreCajero() + "\n";
            
            for (int Cont1 = 0; Cont1<Productos.Count;Cont1++)
            {
                InfoBoleta += Productos[Cont1].PYPYM() +"\n";

            }
            for (int Cont2 = 0;Cont2<Productos.Count;Cont2++)
            {
                TotalPrecio += Productos[Cont2].SacarPrecio();
            }
            InfoBoleta += "Total a Pagar: $" + TotalPrecio.ToString()+"\n";
            InfoBoleta += ClienteX.MetodoPago();
            InfoBoleta += "-----------------------------------------" + "\n";

        }

        public string InfoBoletas()
        {
            return InfoBoleta;
        }


    }
}
