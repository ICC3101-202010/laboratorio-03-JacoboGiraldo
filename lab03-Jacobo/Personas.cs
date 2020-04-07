using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Persona
    {
        protected string RUT { get; set; }
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected string Fecha_Nacimiento { get; set; }
        protected string Nacionalidad { get; set; }


        

        public string NombreCliente()
        {
            return Nombre;
        }
        public string InfoCliente()
        {
            string Info = "Nombre: " + Nombre + ", Apellido: " + Apellido + ", RUT: " + RUT + "\n";
            return Info;
        }

        List<Persona> ClientesTotal = new List<Persona>();
        public void MostrarClientes()
        {
            for (int Z = 0; Z < ClientesTotal.Count; Z++)
            {
                Console.WriteLine(ClientesTotal[Z].InfoCliente());
            }
        }
    }
}
