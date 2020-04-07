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
        public string Venta_Producto(Clientes ClienteX, Cajeros CajeroX, List<Productos> Productos)
        {
            //Registrar todo de la compra (Nombre Cliente, Nombre Cajero, Lista Productos, Fecha y Hora)
            int TotalPrecio = 0;
            InfoBoleta += "Fecha de la compra: " + DateTime.Now;
            InfoBoleta += "Cliente: " + ClienteX.NombreCliente() + "\n";
            InfoBoleta += "Atendido por el Cajero: " + CajeroX.NombreCajero() + "\n";

            for (int Cont1 = 0; Cont1 < Productos.Count; Cont1++)
            {
                InfoBoleta += Productos[Cont1].PYPYM() + "\n";

            }
            for (int Cont2 = 0; Cont2 < Productos.Count; Cont2++)
            {
                TotalPrecio += Productos[Cont2].SacarPrecio();
            }
            InfoBoleta += "Total a Pagar: $" + TotalPrecio.ToString() + "\n";
            InfoBoleta += ClienteX.MetodoPago();
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
