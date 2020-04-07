using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Menu
            string Bienvenida = "Bienvenido al SuperMercado interactivo $Jacobo&MuchoMas";
            string Interaccion1 = "Elija la opcion que mas le guste y recuerde, disfrute su experiencia!";
            string Interaccion2 = "De estas personas cuales deseas crear?";
            string Interaccion3 = "De estos empleados cuales deseas crear?";
            string CrearPersonas = " 1) Crear Personas ";
            string CrearProductos = " 2) Crear Productos ";
            string CrearVenta = " 3) Realizar una venta";
            string TerminarSuperMercado = " 4) Cerrar y Terminar Supermercado";

            string CrearEmpleados = " 1) Crear Empleados";
            string CrearClientes = " 2) Crear Clientes";

            string CrearJefes = " 1) Crear Jefes";
            string CrearSupervisores = " 2) Crear Supervisores";
            string CrearCajeros = " 3) Crear Cajeros";
            string CrearAuxiliares = " 4) Crear Auxiliares";

            string MenuEx = Interaccion1 + "\n" + CrearPersonas + "\n" + CrearProductos + "\n"+CrearVenta+"\n"+TerminarSuperMercado+ "\n";
            string MenuInt1 = Interaccion2 + "\n" + CrearEmpleados + "\n" + CrearClientes + "\n";
            string MenuInt2 = Interaccion3 + "\n" + CrearJefes + "\n" + CrearSupervisores + "\n" + CrearCajeros + "\n" + CrearAuxiliares + "\n";

            Console.WriteLine(Bienvenida);
            Empleados EmpleadosFull = new Empleados();

            while (true)
            {
                Console.WriteLine(MenuEx);
                string SeleccionEx = Console.ReadLine();
                

                if (SeleccionEx == "1")
                {
                    Console.WriteLine(MenuInt1);
                    string SeleccionInt1 = Console.ReadLine();
                    if (SeleccionInt1=="1")
                    {
                        Console.WriteLine(MenuInt2);
                        string SeleccionInt2 = Console.ReadLine();
                        Console.WriteLine("Debes ingresar los datos de tus empleados en este formato: \n");
                        Console.WriteLine("(Nombre/Apellido/RUT/Sueldo/HorarioTrabajo/FechaNacimiento/Nacionalidad)");
                        if (SeleccionInt2=="1")
                        {
                            Console.WriteLine("Ingresa a continuacion todos los datos de tu Jefe:");
                            string Nombre = Console.ReadLine();
                            string Apellido = Console.ReadLine();
                            string RUT = Console.ReadLine();
                            string Sueldo = Console.ReadLine();
                            string Horario = Console.ReadLine();
                            string FechaNacimiento = Console.ReadLine();
                            string Nacionalidad = Console.ReadLine();

                            Jefes J = new Jefes(Nombre, Apellido, RUT, Int32.Parse(Sueldo), Horario, FechaNacimiento, Nacionalidad);
                            J.AgregarJefes(J);
                            J.MostrarJefes();
                            EmpleadosFull.AgregarEmpleados(J);

                        }
                        if (SeleccionInt2=="2")
                        {
                            Console.WriteLine("Ingresa a continuacion todos los datos de tu Supervisor:");
                            string Nombre = Console.ReadLine();
                            string Apellido = Console.ReadLine();
                            string RUT = Console.ReadLine();
                            string Sueldo = Console.ReadLine();
                            string Horario = Console.ReadLine();
                            string FechaNacimiento = Console.ReadLine();
                            string Nacionalidad = Console.ReadLine();

                            Supervisores S = new Supervisores(Nombre, Apellido, RUT, Int32.Parse(Sueldo), Horario, FechaNacimiento, Nacionalidad);
                            S.AgregarSupervisores(S);
                            S.MostrarSupervisores();
                            EmpleadosFull.AgregarEmpleados(S);
                            
                        }
                        if (SeleccionInt2=="3")
                        {
                            Console.WriteLine("Ingresa a continuacion todos los datos de tu Cajero:");
                            string Nombre = Console.ReadLine();
                            string Apellido = Console.ReadLine();
                            string RUT = Console.ReadLine();
                            string Sueldo = Console.ReadLine();
                            string Horario = Console.ReadLine();
                            string FechaNacimiento = Console.ReadLine();
                            string Nacionalidad = Console.ReadLine();

                            Cajeros C = new Cajeros(Nombre, Apellido, RUT, Int32.Parse(Sueldo), Horario, FechaNacimiento, Nacionalidad);
                            C.AgregarCajeros(C);
                            C.MostrarCajeros();
                            EmpleadosFull.AgregarEmpleados(C);
                        }
                        if (SeleccionInt2=="4")
                        {
                            Console.WriteLine("Ingresa a continuacion todos los datos de tu Auxiliar:");
                            string Nombre = Console.ReadLine();
                            string Apellido = Console.ReadLine();
                            string RUT = Console.ReadLine();
                            string Sueldo = Console.ReadLine();
                            string Horario = Console.ReadLine();
                            string FechaNacimiento = Console.ReadLine();
                            string Nacionalidad = Console.ReadLine();

                            Auxiliares A = new Auxiliares(Nombre, Apellido, RUT, Int32.Parse(Sueldo), Horario, FechaNacimiento, Nacionalidad);
                            A.AgregarAuxiliares(A);
                            EmpleadosFull.AgregarEmpleados(A);
                            


                            
                        }
                    }
                    if(SeleccionInt1=="2")
                    {

                    }
                    
                }
                if(SeleccionEx == "2")
                {

                }
                if(SeleccionEx == "3")
                {

                }
                if(SeleccionEx == "4")
                {
                    break;
                }
            }
           





        }
    }
}
