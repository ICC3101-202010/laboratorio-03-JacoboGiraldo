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
        public string Venta_Producto(Clientes ClienteX, Cajeros CajeroX, List<Productos> Productos, int CantidadProductos, List<string> ActualSTOCK)
        {
            //Registrar todo de la compra (Nombre Cliente, Nombre Cajero, Lista Productos, Fecha y Hora)
            int TotalPrecio = 0;
            InfoBoleta += "Fecha de la compra: " + DateTime.Now + "\n";
            InfoBoleta += "Cliente: " + ClienteX.NombreCliente() + "\n";
            InfoBoleta += "Atendido por el Cajero: " + CajeroX.NombreCajero() + "\n";

            for (int Cont1 = 0; Cont1 < CantidadProductos; Cont1++)
            {
                Random random = new Random();
                int X = random.Next(0, Productos.Count - 1);
                if (ActualSTOCK[X] == "0")
                {
                    InfoBoleta += "No se puedo realizar la compra porque no hay stock suficiente del producto: " + Productos[X].SacarNombre();
                    return InfoBoleta;
                }
                InfoBoleta += Productos[X].PYPYM() + "\n";
                int Stock = Int32.Parse(ActualSTOCK[X]) - 1;
                ActualSTOCK[X] = Stock.ToString();
                TotalPrecio += Productos[X].SacarPrecio();
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
