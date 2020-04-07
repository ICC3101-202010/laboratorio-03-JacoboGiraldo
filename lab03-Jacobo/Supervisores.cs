using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Supervisores:Empleados
    {
        protected int NivelSupervisores = 2;

        public Supervisores(string Nombre, string Apellido, string RUT, int Sueldo, string Horario_Trabajo, string Fecha_Nacimiento, string Nacionalidad)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.RUT = RUT;
            this.Sueldo = Sueldo;
            this.Horario_Trabajo = Horario_Trabajo;
            this.Fecha_Nacimiento = Fecha_Nacimiento;
            this.Nacionalidad = Nacionalidad;
        }
        public void AgregarSupervisores(Supervisores SupervisorCualquiera)
        {
            SupervisoresTotal.Add(SupervisorCualquiera);
        }
        public void MostrarSupervisores()
        {
            for (int Z = 0; Z < SupervisoresTotal.Count; Z++)
            {
                Console.WriteLine(SupervisoresTotal[Z].InfoBasica());
            }
        }





    }
}
