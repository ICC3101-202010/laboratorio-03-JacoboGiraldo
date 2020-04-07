using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Cliente:Persona
    {
        protected List<string> MetodosDePago = new List<string>() {"Efectivo","Tarjeta de Credito","Tarjeta de Debito","Chequera","Transferencia Bancaria"};

        public Cliente(string Nombre, string Apellido, string RUT)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.RUT = RUT;
        }

        public string MetodoPago()
        {
            Random X = new Random();
            return MetodosDePago[X.Next(0, 4)];
        }
        public string NombreCliente()
        {
            return Nombre;
        }





    }
}
