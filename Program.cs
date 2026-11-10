// -------------------------------
//Alpine&Run: 
// -------------------------------

using System.ComponentModel;

int ventasHoy = 0;
int inventarioNuevo = 0;
decimal dineroGanado = 0;
decimal dineroGastado = 0;

int opcionPrincipal = 0;

//Menu Principal

do
{
    Console.WriteLine();
    Console.WriteLine("------------------------------------");
    Console.WriteLine("              Alpine&Run");
    Console.WriteLine("------------------------------------");
    Console.WriteLine("1. Cobrar una compra");
    Console.WriteLine("2. Consultar inventario");
    Console.WriteLine("3. Consultar ventas del dia");
    Console.WriteLine("0. Salir");
    Console.Write("Selecciona una opción: ");
    opcionPrincipal = int.Parse(Console.ReadLine()!);

    if (opcionPrincipal == 1)
    {
        //Cobrar persona

        Console.WriteLine();
        Console.WriteLine("--- Cobrar Compra ---");

        string nombreCliente;

        do
        {
            Console.Write("Nombre del cliente: ");
            nombreCliente = Console.ReadLine() ?? "";

            if (nombreCliente.Trim() == "")
            {
                Console.WriteLine("Rellenar el nombre porfavor");
            }
        } while (nombreCliente.Trim() == "");
        //Elegir marca y posteriormente modelo de zapatillas

        int opcionMarcaZapatillas;
        string marcaZapatillas = "";
        int opcionModeloZapatillas;
        string modeloZapatillas = "";

        do
        {
            Console.WriteLine();
            Console.WriteLine("--- Elija la Marca de las Zapatillas deseada ---");
            Console.WriteLine("1. Nike");
            Console.WriteLine("2. Adidas");
            Console.WriteLine("3. NewBalance");
            Console.Write("Seleccione una marca: ");
            opcionMarcaZapatillas = int.Parse(Console.ReadLine()!);

            if (opcionMarcaZapatillas < 1 || opcionMarcaZapatillas > 3)
            {
                Console.WriteLine("Elija una de las opciones disponibles");
            }
        } while (opcionMarcaZapatillas < 1 || opcionMarcaZapatillas > 3);

        if (opcionMarcaZapatillas == 1)
        {
            marcaZapatillas = "Nike";
            Console.WriteLine("Marca Nike seleccionada");
            Console.WriteLine();
            do
            {
                Console.WriteLine();
                Console.WriteLine("--- Elija el Modelo de las Zapatillas Nike deseada ---");
                Console.WriteLine("1. Vomero Plus (180€)");
                Console.WriteLine("2. Maxfly 2 (220€)");
                Console.WriteLine("3. AirForce 1 (120€)");
                Console.Write("Seleccione una marca: ");
                opcionModeloZapatillas = int.Parse(Console.ReadLine()!);

                if (opcionModeloZapatillas < 1 || opcionModeloZapatillas > 3)
                {
                Console.WriteLine("Elija una de las opciones disponibles");
                }
            } while (opcionModeloZapatillas < 1 || opcionModeloZapatillas > 3);

            if (opcionModeloZapatillas == 1)
            {
                modeloZapatillas = "Vomero Plus";
                Console.WriteLine("Nike Vomero Plus seleccionadas");
            }else if (opcionModeloZapatillas == 2)
            {
                modeloZapatillas = "Maxfly 2";
                Console.WriteLine("Nike Maxfly 2 seleccionadas");
            }else
            {
                modeloZapatillas = "AirForce 1";
                Console.WriteLine("Nike AirForce 1 seleccionadas");
            }
        }else if (opcionMarcaZapatillas == 2)
        {
            marcaZapatillas = "Adidas";
            Console.WriteLine("Marca Adidas seleccionada");
            Console.WriteLine();
            do
            {
                Console.WriteLine();
                Console.WriteLine("--- Elija el Modelo de las Zapatillas Adidas deseada ---");
                Console.WriteLine("1. Adizero EVO SL (180€)");
                Console.WriteLine("2. Prime SP 4 (220€)");
                Console.WriteLine("3. Campus (120€)");
                Console.Write("Seleccione una marca: ");
                opcionModeloZapatillas = int.Parse(Console.ReadLine()!);

                if (opcionModeloZapatillas < 1 || opcionModeloZapatillas > 3)
                {
                Console.WriteLine("Elija una de las opciones disponibles");
                }
            } while (opcionModeloZapatillas < 1 || opcionModeloZapatillas > 3);

            if (opcionModeloZapatillas == 2)
            {
                modeloZapatillas = "Adizero EVO SL";
                Console.WriteLine("Adidas Adizero EVO SL seleccionadas");
            }else if (opcionModeloZapatillas == 2)
            {
                modeloZapatillas = "Prime SP 4";
                Console.WriteLine("Adidas Prime SP 4 seleccionadas");
            }else
            {
                modeloZapatillas = "Campus";
                Console.WriteLine("Adidas Campus seleccionadas");
            }
        }else
        {
            marcaZapatillas = "NewBalance";
            Console.WriteLine("Marca NewBalance seleccionada");
            Console.WriteLine();
            do
            {
                Console.WriteLine();
                Console.WriteLine("--- Elija el Modelo de las Zapatillas NewBalance deseada ---");
                Console.WriteLine("1. Fuelcell Rebel V5");
                Console.WriteLine("2. FuelCell SuperComp PWR-X v3");
                Console.WriteLine("3. 1906 utility");
                Console.Write("Seleccione una marca: ");
                opcionModeloZapatillas = int.Parse(Console.ReadLine()!);

                if (opcionModeloZapatillas < 1 || opcionModeloZapatillas > 3)
                {
                Console.WriteLine("Elija una de las opciones disponibles");
                }
            } while (opcionModeloZapatillas < 1 || opcionModeloZapatillas > 3);

            if (opcionModeloZapatillas == 1)
            {
                modeloZapatillas = "Fuelcell Rebel V5";
                Console.WriteLine("NewBalance Fuelcell Rebel V5 selecionadas");
            }else if (opcionModeloZapatillas == 2)
            {
                modeloZapatillas = "FuelCell SuperComp PWR-X v3";
                Console.WriteLine("NewBalance FuelCell SuperComp PWR-X v3 seleccionadas");
            }else
            {
                modeloZapatillas = "1906 utility";
                Console.WriteLine("NewBalance 1906 utility seleccionadas");
            }
        }
    }
    else if (opcionPrincipal == 2)
    {
        
    }
    else if (opcionPrincipal == 3)
    {
        
    }
    else if (opcionPrincipal == 0)
    {
        
    }
    else
    {
        Console.WriteLine("Opcion incorrecta. seleccione 1, 2, 3 o 0");
    }
} while (opcionPrincipal != 0);