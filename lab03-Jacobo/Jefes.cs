using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Jefes:Empleados
    {
        

        public Jefes(string Nombre, string RUT,int Sueldo, string Horario_Trabajo)
        {
            this.Nombre = Nombre;
            this.RUT = RUT;
            this.Sueldo = Sueldo;
            this.Horario_Trabajo = Horario_Trabajo;
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
