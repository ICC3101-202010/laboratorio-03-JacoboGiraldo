using System;
using System.Collections.Generic;
namespace lab03Jacobo
{
    public class Ventas
    {
        public Ventas()
        {
        }
        protected string InfoBoleta;
        public string Venta_Producto(Clientes ClienteX, Cajeros CajeroX, List<Productos> Productos, int CantidadProductos)
        {
            //Registrar todo de la compra (Nombre Cliente, Nombre Cajero, Lista Productos, Fecha y Hora)
            int TotalPrecio = 0;
            InfoBoleta += "Fecha de la compra: " + DateTime.Now + "\n";
            InfoBoleta += "Cliente: " + ClienteX.NombreCliente() + "\n";
            InfoBoleta += "Atendido por el Cajero: " + CajeroX.NombreCajero() + "\n";

            for (int Cont1 = 0; Cont1 < CantidadProductos; Cont1++)
            {
                Random random = new Random();
                int X = random.Next(0, Productos.Count);
                InfoBoleta += Productos[X].PYPYM() + "\n";
                

            }
            for (int Cont2 = 0; Cont2 < Productos.Count; Cont2++)
            {
                TotalPrecio += Productos[Cont2].SacarPrecio();
            }
            InfoBoleta += "Total a Pagar: $" + TotalPrecio.ToString() + "\n";
            InfoBoleta += "Paga con: "+ClienteX.MetodoPago()+"\n" ;
            InfoBoleta += "-----------------------------------------" + "\n";
            return InfoBoleta;
        }
        public void InfoBoletas(List<string> IB)
        {
            string InfoBoletasTotal = "";
            foreach(string ELEMENT in IB)
            {
                InfoBoletasTotal += ELEMENT;
                
            }
            Console.WriteLine(InfoBoletasTotal);
            
        }














    }









}
