using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Clientes:Persona
    {
        protected List<string> MetodosDePago = new List<string>() {"Efectivo","Tarjeta de Credito","Tarjeta de Debito","Chequera","Transferencia Bancaria"};

        public Clientes(string Nombre, string Apellido, string RUT, string Fecha_Nacimiento, string Nacionalidad)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.RUT = RUT;
            this.Fecha_Nacimiento = Fecha_Nacimiento;
            this.Nacionalidad = Nacionalidad;
        }

        public string MetodoPago()
        {
            Random X = new Random();
            return MetodosDePago[X.Next(0, 4)];
        }

       





    }
}
