using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Supervisores:Empleados
    {
        public Supervisores(string Nombre, int Nivel_Cargo, int Sueldo, string Horario_Trabajo)
        {
            this.Nombre = Nombre;
            this.Nivel_Cargo = Nivel_Cargo;
            this.Sueldo = Sueldo;
            this.Horario_Trabajo = Horario_Trabajo;
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
