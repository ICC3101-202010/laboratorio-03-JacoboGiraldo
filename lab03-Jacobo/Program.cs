using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int Cont = 3;

            Jefes jefe1 = new Jefes("Jacobo", "248007086", 178000, "9AM-8PM");
            jefe1.AgregarJefes(jefe1);
            jefe1.MostrarJefes();






        }
    }
}
