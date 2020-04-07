using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Cajeros:Empleados
    {
        protected int NivelCajeros = 3;

        public Cajeros(string Nombre, string Apellido, string RUT,int Sueldo, string Horario_Trabajo, string Fecha_Nacimiento, string Nacionalidad)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.RUT = RUT;
            this.Sueldo = Sueldo;
            this.Horario_Trabajo = Horario_Trabajo;
            this.Fecha_Nacimiento = Fecha_Nacimiento;
            this.Nacionalidad = Nacionalidad;
        }
   

    






    }
}
