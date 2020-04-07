using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Cajeros:Empleados
    {
        public Cajeros(string Nombre, int Nivel_Cargo, int Sueldo, string Horario_Trabajo)
        {
            this.Nombre = Nombre;
            this.Nivel_Cargo = Nivel_Cargo;
            this.Sueldo = Sueldo;
            this.Horario_Trabajo = Horario_Trabajo;
        }
        public void AgregarCajeros(Cajeros CajeroCualquiera)
        {
            CajerosTotal.Add(CajeroCualquiera);
        }
        public void MostrarCajeros()
        {
            for (int Z = 0; Z < CajerosTotal.Count; Z++)
            {
                Console.WriteLine(CajerosTotal[Z].InfoBasica());
            }
        }
        public string NombreCajero()
        {
            return Nombre;
        }







    }
}
