﻿using System;
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
    }
}
