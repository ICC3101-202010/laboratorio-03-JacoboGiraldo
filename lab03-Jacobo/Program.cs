using System;
using System.Collections.Generic;

namespace lab03Jacobo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Menu
            string Bienvenida = "Bienvenido al SuperMercado interactivo $Jacobo&Mas Distribuidores S.A.";
            string ChamulloSimula = "Recuerda que si no desesas interactuar puedes correr una simulacion!";
            string Interaccion1 = "Elija la opcion que mas le guste y recuerde, disfrute su experiencia!";
            string Interaccion2 = "De estas personas cuales deseas crear?";
            string Interaccion3 = "De estos empleados cuales deseas crear?";
            string CrearPersonas = " 1) Crear Personas ";
            string CrearProductos = " 2) Crear Productos ";
            string CrearVenta = " 3) Realizar una venta";
            string TerminarSuperMercado = " 4) Cerrar y Terminar Supermercado";
            string Simulacion = " 5) Generar Simulacion";

            string CrearEmpleados = " 1) Crear Empleados";
            string CrearClientes = " 2) Crear Clientes";

            string CrearJefes = " 1) Crear Jefes";
            string CrearSupervisores = " 2) Crear Supervisores";
            string CrearCajeros = " 3) Crear Cajeros";
            string CrearAuxiliares = " 4) Crear Auxiliares";

            string MenuEx = Interaccion1 + "\n" + CrearPersonas + "\n" + CrearProductos + "\n"+CrearVenta+"\n"+TerminarSuperMercado+ "\n"+Simulacion+"\n";
            string MenuInt1 = Interaccion2 + "\n" + CrearEmpleados + "\n" + CrearClientes + "\n";
            string MenuInt2 = Interaccion3 + "\n" + CrearJefes + "\n" + CrearSupervisores + "\n" + CrearCajeros + "\n" + CrearAuxiliares + "\n";

            //Elementos Interaccion
            Console.WriteLine(Bienvenida);
            Console.WriteLine(ChamulloSimula);
            Empleados EmpleadosFull = new Empleados();
            List<Jefes> GuardarJefes = new List<Jefes>();
            List<Supervisores> GuardarSupervisores = new List<Supervisores>();
            List<Cajeros> GuardarCajeros = new List<Cajeros>();
            List<Auxiliares> GuardarAuxiliares = new List<Auxiliares>();
            List<Clientes> GuardaClientes = new List<Clientes>();
            List<Productos> GuardaProductos = new List<Productos>();
            List<string> GuardaBoletas = new List<string>();

            //Elementos Simulacion
            List<string> NombresSim = new List<string>() {"Jacobo","Juanita","Jose","Julieta","Jana","Gustavo","Corina","Domingo","Felipe","Fernando","Daniel","Camilo","Pablo","Tomas","Emilio","Alejandro","Adriana","Diego","Lucas","Margarita","Daniela","Manuel"};
            List<string> ApellidosSim = new List<string>() {"Giraldo","Rodriguez","Vasquez","Colomer","Montana","Blanco","Machado","Cuadra","Ruiz","Palma","Rodriguez","Betancourt","Escobar","Gil","Galvis","Arias","Mendez","Pinochet","Caliri","Olbertz","Torres","Serrano"};
            List<string> RutsSim = new List<string>() { "198007084","248007087","265008975","213007889","248006677","226007098", "192507084", "242007587", "257009695", "215004489", "248506607", "212509898", "187687052", "242009007", "246789089", "156798790", "163458760", "178009055", "185009874", "232006457", "213908793", "226008009" };
            List<string> FechasSim = new List<string>() { "10/10/1999","12/09/1987","21/09/1997","26/04/2001","13/01/1987","11/11/1964","17/08/1974","12/08/2000","31/01/1995","28/02/1991","13/12/1945","24/12/1998","31/12/1999","27/04/1954","19/05/1968","10/07/1989","03/09/1988","06/02/1977","21/12/1938","08/03/2000","19/05/1966","20/01/1978"};
            List<string> NacionalidadesSim = new List<string>() {"Colombiana", "Colombiana", "Chilena", "Chilena","Alemana", "Alemana","Mexicana", "Mexicana","Española", "Española","Canadiense", "Canadiense","Uruguaya", "Uruguaya","Argentina", "Argentina","Panameña", "Panameña","Cubana", "Cubana","Brasileña", "Brasileña"};
            List<string> HorariosSim = new List<string>() { "7AM-7PM", "8AM-6PM", "7AM-5PM", "9AM-3PM", "9AM-6PM", "7AM-9PM", "10AM-8PM" };
            List<string> NompreProSim = new List<string>() {"Pasta","Lentejas","Carne","Pollo","Galletas","Arroz","Frutillas","Lechuga","Jugo","Jamon","Queso","Yogur","Leche","Alfajores","Bebida","Pizza","Chorizo","Ketchup","Mostaza","Salchichas","Mayonesa","Pan","Papas Fritas","Brownies","Mentas","Frijoles","Cerveza","Pisco","Agua","Camarones"};
            List<string> MarcasSim = new List<string>() { "Jumbo", "Tottus", "Lider", "Artesanal", "Jacobo&Mas", "VeganLabs", "DeTodito", "Rapido&Facil", "100Calidad", "Rikolino" };

            List<Clientes> GuardaClientesSIM = new List<Clientes>();
            List<Jefes> GuardaJefesSIM = new List<Jefes>();
            List<Supervisores> GuardaSupervisoresSIM = new List<Supervisores>();
            List<Cajeros> GuardaCajerosSIM = new List<Cajeros>();
            List<Auxiliares> GuardaAuxiliaresSIM = new List<Auxiliares>();

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
                        Console.WriteLine("Debes ingresar los datos de tus empleados en este formato:");
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
                            GuardarJefes.Add(J);
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
                            GuardarSupervisores.Add(S);                           
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
                            GuardarCajeros.Add(C);                            
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
                            GuardarAuxiliares.Add(A);
                            EmpleadosFull.AgregarEmpleados(A);
                            
                            
                        }
                    }
                    if(SeleccionInt1=="2")
                    {
                        Console.WriteLine("Debes ingresar los datos de tus clientes en este formato:");
                        Console.WriteLine("(Nombre/Apellido/RUT/FechaNacimiento/Nacionalidad)");
                        Console.WriteLine("Ingresa a continuacion todos los datos de tu Cliente:");
                        string Nombre = Console.ReadLine();
                        string Apellido = Console.ReadLine();
                        string RUT = Console.ReadLine();
                        string FechaNacimiento = Console.ReadLine();
                        string Nacionalidad = Console.ReadLine();

                        Clientes Cliente = new Clientes(Nombre, Apellido, RUT, FechaNacimiento, Nacionalidad);
                        GuardaClientes.Add(Cliente);
                        foreach (Clientes X in GuardaClientes)
                        {
                            Console.WriteLine(X.InfoCliente());
                            Console.WriteLine(X.NombreCliente());
                        }
                    }                    
                }
                if(SeleccionEx == "2")
                {
                    Console.WriteLine("Debes ingresar los datos de tus productos en este formato:");
                    Console.WriteLine("(NombreProducto/Precio/Marca/Stock)");
                    string NombreProducto = Console.ReadLine();
                    string Precio = Console.ReadLine();
                    string Marca = Console.ReadLine();
                    string Stock = Console.ReadLine();

                    Productos PROX = new Productos(NombreProducto, Int32.Parse(Precio), Marca, Int32.Parse(Stock));
                    GuardaProductos.Add(PROX);
                }
                if(SeleccionEx == "3")
                {
                    Console.WriteLine("Cuantos prodcutos desea comprar el cliente?");
                    string CantProCompra = Console.ReadLine();
                    Random Number1 = new Random();
                    int NumCliente = Number1.Next(0, GuardaClientes.Count);
                    Random Number2 = new Random();
                    int NumCajero = Number2.Next(0, GuardarCajeros.Count);

                    Ventas Venta1 = new Ventas();

                    string BoletaSingle = Venta1.Venta_Producto(GuardaClientes[NumCliente], GuardarCajeros[NumCajero], GuardaProductos, int.Parse(CantProCompra));
                    GuardaBoletas.Add(BoletaSingle);
                    Venta1.InfoBoletas(GuardaBoletas);
                }
                if(SeleccionEx == "4")
                {
                    break;
                }
                Random random = new Random();
                if (SeleccionEx == "5")
                {
                    //Clientes
                    for (int Cont = 0; Cont<15;Cont++)
                    {
                        int V = random.Next(0, NombresSim.Count);
                        int W = random.Next(0, ApellidosSim.Count);
                        int X = random.Next(0, RutsSim.Count);
                        int Y = random.Next(0, FechasSim.Count);
                        int Z = random.Next(0, NacionalidadesSim.Count);
                        Clientes ClienteX = new Clientes(NombresSim[V],ApellidosSim[W],RutsSim[X],FechasSim[Y],NacionalidadesSim[Z]);
                        GuardaClientesSIM.Add(ClienteX);

                    }
                    //Empleados
                    for (int Cont = 0; Cont < 1; Cont++) ;
                    {
                        //JEFES
                        int V = random.Next(0, NombresSim.Count);
                        int W = random.Next(0, ApellidosSim.Count);
                        int X = random.Next(0, RutsSim.Count);
                        int Y = random.Next(0, FechasSim.Count);
                        int Z = random.Next(0, NacionalidadesSim.Count);
                        int Sueldo = random.Next(1200000, 1500000);
                        int A = random.Next(0, HorariosSim.Count);

                        Jefes JefeX = new Jefes(NombresSim[V],ApellidosSim[W],RutsSim[X],Sueldo,HorariosSim[A],FechasSim[Y],NacionalidadesSim[Z]);
                        GuardaJefesSIM.Add(JefeX);
                    }
                    for (int Cont = 0; Cont < 1; Cont++) ;
                    {
                        //SUPERVISORES
                        int V = random.Next(0, NombresSim.Count);
                        int W = random.Next(0, ApellidosSim.Count);
                        int X = random.Next(0, RutsSim.Count);
                        int Y = random.Next(0, FechasSim.Count);
                        int Z = random.Next(0, NacionalidadesSim.Count);
                        int Sueldo = random.Next(1000000, 1200000);
                        int A = random.Next(0, HorariosSim.Count);

                        Supervisores SupervisorX = new Supervisores(NombresSim[V], ApellidosSim[W], RutsSim[X], Sueldo, HorariosSim[A], FechasSim[Y], NacionalidadesSim[Z]);
                        GuardaSupervisoresSIM.Add(SupervisorX);
                    }
                    for (int Cont = 0; Cont < 3; Cont++) ;
                    {
                        //CAJEROS
                        int V = random.Next(0, NombresSim.Count);
                        int W = random.Next(0, ApellidosSim.Count);
                        int X = random.Next(0, RutsSim.Count);
                        int Y = random.Next(0, FechasSim.Count);
                        int Z = random.Next(0, NacionalidadesSim.Count);
                        int Sueldo = random.Next(800000, 1000000);
                        int A = random.Next(0, HorariosSim.Count);

                        Cajeros CajeroX = new Cajeros(NombresSim[V], ApellidosSim[W], RutsSim[X], Sueldo, HorariosSim[A], FechasSim[Y], NacionalidadesSim[Z]);
                        GuardaCajerosSIM.Add(CajeroX);
                    }
                    for (int Cont = 0; Cont < 2; Cont++) ;
                    {
                        //AUXILIARES
                        int V = random.Next(0, NombresSim.Count);
                        int W = random.Next(0, ApellidosSim.Count);
                        int X = random.Next(0, RutsSim.Count);
                        int Y = random.Next(0, FechasSim.Count);
                        int Z = random.Next(0, NacionalidadesSim.Count);
                        int Sueldo = random.Next(550000, 800000);
                        int A = random.Next(0, HorariosSim.Count);

                        Auxiliares AuxiliarX = new Auxiliares(NombresSim[V], ApellidosSim[W], RutsSim[X], Sueldo, HorariosSim[A], FechasSim[Y], NacionalidadesSim[Z]);
                        GuardaAuxiliaresSIM.Add(AuxiliarX);
                    }




                }
            }
           





        }
    }
}
