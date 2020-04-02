using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    public class Empleados:Persona
    {
        protected int ID_Empleado;
        protected int Nivel_Cargo;
        protected int Sueldo;
        protected string Horario_Trabajo;

        public Empleados()
        {
            
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
