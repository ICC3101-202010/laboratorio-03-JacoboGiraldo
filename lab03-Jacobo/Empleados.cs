using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public abstract class Empleados:Persona
    { 
        protected int Nivel_Cargo { get; set; }
        protected int Sueldo { get; set; }
        protected string Horario_Trabajo { get; set; }

        public Empleados()
        {
         

        }
        List<string> empleados = new List<string>();
        public void Info_Empleados()
        {
            empleados.Add(Nombre);
            empleados.Add(RUT);
            empleados.Add(Nivel_Cargo.ToString());
            empleados.Add(Sueldo.ToString());
            empleados.Add(Horario_Trabajo);

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
