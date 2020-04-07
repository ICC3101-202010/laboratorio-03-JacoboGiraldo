using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Empleados:Persona
    { 
        protected int Nivel_Cargo { get; set; }
        protected int Sueldo { get; set; }
        protected string Horario_Trabajo { get; set; }

        protected List<Jefes> JefesTotal = new List<Jefes>();
        protected List<Supervisores> SupervisoresTotal = new List<Supervisores>();
        protected List<Cajeros> CajerosTotal = new List<Cajeros>();
        protected List<Auxiliares> AuxiliaresTotal = new List<Auxiliares>();
        
        public Empleados()
        {
         
        }

        List<Empleados> EmpleadosTotal = new List<Empleados>();
        public void AgregarEmpleados(Empleados EmpleadoX)
        {
            EmpleadosTotal.Add(EmpleadoX);

        }
        public string InfoBasica()
        {
            string Info = "Nombre: " + Nombre + ", RUT: " + RUT + ", Sueldo: " + Sueldo.ToString() + ", Horario Trabajo: " + Horario_Trabajo + "\n";
            return Info;
        }
        public void MostrarEmpleados()
        {
            for (int Z = 0; Z < EmpleadosTotal.Count; Z++)
            {
                Console.WriteLine(EmpleadosTotal[Z].InfoBasica());
            }
        }




        public bool Ascenso(int Nivel_Cargo)
        {
            this.Nivel_Cargo = Nivel_Cargo;
            if (Nivel_Cargo>1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Descenso(int Nivel_Cargo)
        {
            this.Nivel_Cargo = Nivel_Cargo;
            if (Nivel_Cargo<4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
