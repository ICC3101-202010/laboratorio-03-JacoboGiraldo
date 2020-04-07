using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Auxiliares : Empleados
    {
        protected int NivelAuxiliares = 4;

        public Auxiliares(string Nombre, string Apellido, string RUT, int Sueldo, string Horario_Trabajo, string Fecha_Nacimiento, string Nacionalidad)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.RUT = RUT;
            this.Sueldo = Sueldo;
            this.Horario_Trabajo = Horario_Trabajo;
            this.Fecha_Nacimiento = Fecha_Nacimiento;
            this.Nacionalidad = Nacionalidad;
        }
        public void AgregarAuxiliares(Auxiliares AuxiliareCualquiera)
        {
            AuxiliaresTotal.Add(AuxiliareCualquiera);
        }
        public void MostrarAuxiliares()
        {
            for (int Z = 0; Z<AuxiliaresTotal.Count;Z++)
            {
                Console.WriteLine(AuxiliaresTotal[Z].InfoBasica());
            }
        }








    }




}
