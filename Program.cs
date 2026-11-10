// -------------------------------
//Alpine&Run: 
// -------------------------------

int ventasHoy = 0;
int inventarioNuevo = 0;
decimal dineroGanado = 0;
decimal dineroGastado = 0;
int paresVendidos = 0;

//Stock de tienda
int stockVomeroPlus = 23;
int stockMaxfly2 = 12;
int stockAirForce1 = 34;
int stockAdizeroEvoSl = 15;
int stockPrimeSp4 = 6;
int stockCampus = 44;
int stockFuelcellRebelV5 = 33;
int stockSuperCompPwrX = 3;
int stockutility1906 = 28;

double descuentoGrande = 0.20;
double descuentoPequeno = 0.10;

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
    Console.WriteLine("4. Reponer inventario");
    Console.WriteLine("0. Salir");
    Console.Write("Selecciona una opción: ");
    opcionPrincipal = int.Parse(Console.ReadLine()!);

    if (opcionPrincipal == 1)
    {
        //Cobrar compra

        Console.WriteLine();
        Console.WriteLine("--- Cobrar Compra ---");

        string nombreCliente;
        //Guardar nombre del cliente
        //utilizo trim para quitar los espacios en blanco y de esa manera al comprobar si no se ha escrito nada o solo espacios en blanco se volveria a pedir de nuevo el nombre
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
            do
            {
                Console.WriteLine();
                Console.WriteLine("--- Elija el Modelo de las Zapatillas Nike deseado ---");
                Console.WriteLine("1. Vomero Plus (180€)");
                Console.WriteLine("2. Maxfly 2 (220€)");
                Console.WriteLine("3. AirForce 1 (120€)");
                Console.Write("Seleccione un modelo: ");
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
                Console.WriteLine("--- Elija el Modelo de las Zapatillas Adidas deseado ---");
                Console.WriteLine("1. Adizero EVO SL (180€)");
                Console.WriteLine("2. Prime SP 4 (220€)");
                Console.WriteLine("3. Campus (120€)");
                Console.Write("Seleccione un modelo: ");
                opcionModeloZapatillas = int.Parse(Console.ReadLine()!);

                if (opcionModeloZapatillas < 1 || opcionModeloZapatillas > 3)
                {
                Console.WriteLine("Elija una de las opciones disponibles");
                }
            } while (opcionModeloZapatillas < 1 || opcionModeloZapatillas > 3);

            if (opcionModeloZapatillas == 1)
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
                Console.WriteLine("1. Fuelcell Rebel V5 (120€)");
                Console.WriteLine("2. FuelCell SuperComp PWR-X v3 (170€)");
                Console.WriteLine("3. 1906 utility (120€)");
                Console.Write("Seleccione un modelo: ");
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
        //aqui he buscado una sugerencia de como numerar todos los productos juntos para asi no tener que hacer la logica para las 3 marcas
        int codigoModelo = (opcionMarcaZapatillas - 1) * 3 + opcionModeloZapatillas;
        double precioPar = 0;
        int stockDisponible = 0;

        //aqui asigno los precios a los modelos individuales en vez de hacerlo multiples veces
        if (codigoModelo == 1)
        {
            precioPar = 180;
            stockDisponible = stockVomeroPlus;
        }else if (codigoModelo == 2)
        {
            precioPar = 220;
            stockDisponible = stockMaxfly2;
        }else if (codigoModelo == 3)
        {
            precioPar = 120;
            stockDisponible = stockAirForce1;
        }else if (codigoModelo == 4)
        {
            precioPar = 180;
            stockDisponible = stockAdizeroEvoSl;
        }else if (codigoModelo == 5)
        {
            precioPar = 220;
            stockDisponible = stockPrimeSp4;
        }else if (codigoModelo == 6)
        {
            precioPar = 120;
            stockDisponible = stockCampus;
        }else if (codigoModelo == 7)
        {
            precioPar = 120;
            stockDisponible = stockFuelcellRebelV5;
        }else if (codigoModelo == 8)
        {
            precioPar = 170;
            stockDisponible = stockSuperCompPwrX;
        }else
        {
            precioPar = 120;
            stockDisponible = stockutility1906;
        }

        //comprobar stock antes de continuar
        if (stockDisponible == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Lo sentimos " + marcaZapatillas + " " + modeloZapatillas + " no esta disponible.");
        }else
        {
            //vender par o pares dependiendo de cliente
            int cantidadDePares;

            do
            {
                Console.WriteLine("Numeero de pares disponibles: " + stockDisponible);
                cantidadDePares = int.Parse(Console.ReadLine()!);
                if (cantidadDePares < 1 || cantidadDePares > stockDisponible)
                {
                    Console.WriteLine("ERROR: Elija una cantidad entre 1 y " + stockDisponible);
                }
            } while (cantidadDePares < 1 || cantidadDePares > stockDisponible);

            // descuento a aplicar en la compra
            double descuento = 0;
            if (cantidadDePares >= 3)
            {
                descuento = descuentoGrande;
            }else if (cantidadDePares == 2)
            {
                descuento = descuentoPequeno;
            }

            double subtotal = precioPar * cantidadDePares;
            double descuento = subtotal * descuento;
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