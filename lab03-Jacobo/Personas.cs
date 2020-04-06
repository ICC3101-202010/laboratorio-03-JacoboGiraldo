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


        public string[] infoPersonas()
        {
            string[] InfoPersonas = new string[5] {RUT,Nombre,Apellido,Fecha_Nacimiento,Nacionalidad};
            return InfoPersonas;
        }



    }
}
