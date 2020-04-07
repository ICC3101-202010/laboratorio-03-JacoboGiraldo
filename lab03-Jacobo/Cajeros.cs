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
