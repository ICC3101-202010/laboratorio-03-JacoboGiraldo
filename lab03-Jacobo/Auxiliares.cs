using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Auxiliares:Empleados
    {
        public Auxiliares(string Nombre, int Nivel_Cargo, int Sueldo, string Horario_Trabajo)
        {
            this.Nombre = Nombre;
            this.Nivel_Cargo = Nivel_Cargo;
            this.Sueldo = Sueldo;
            this.Horario_Trabajo = Horario_Trabajo;
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
