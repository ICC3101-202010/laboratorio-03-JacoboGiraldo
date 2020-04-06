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
        private List<Jefes> JefesTotal = new List<Jefes>();

        public void AgregarJefes(Jefes JefeCualquiera)
        {
            JefesTotal.Add(JefeCualquiera);
        }
        public string InfoJefes()
        {
            string TotalJefes = "Todos los jefes son: \n";
            string InfoJefes = "Nombre: " + Nombre + ", RUT: " + RUT + ", Sueldo: " + Sueldo.ToString() + ", Horario Trabajo: " + Horario_Trabajo;

            return TotalJefes + InfoJefes;
        }

        public void MostrarJefes()
        {
            Console.WriteLine(JefesTotal[0].InfoJefes());
        }
      

        
        

    }
}
