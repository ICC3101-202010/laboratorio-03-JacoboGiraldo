using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Jefes:Empleados
    {
        protected int NivelJefes = 1;

        public Jefes(string Nombre, string Apellido, string RUT, int Sueldo, string Horario_Trabajo, string Fecha_Nacimiento, string Nacionalidad)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.RUT = RUT;
            this.Sueldo = Sueldo;
            this.Horario_Trabajo = Horario_Trabajo;
            this.Fecha_Nacimiento = Fecha_Nacimiento;
            this.Nacionalidad = Nacionalidad;
        }
        public void AgregarJefes(Jefes JefeCualquiera)
        {
            JefesTotal.Add(JefeCualquiera);
        }
        public void MostrarJefes()
        {
            for (int Z = 0; Z < JefesTotal.Count; Z++)
            {
                Console.WriteLine(JefesTotal[Z].InfoBasica());
            }
        }
      

        
        

    }
}
