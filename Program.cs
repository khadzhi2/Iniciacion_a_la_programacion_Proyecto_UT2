// -------------------------------
//Alpine&Run: 
// -------------------------------

using System.ComponentModel;

int ventasHoy = 0;
int inventarioNuevo = 0;
double dineroGanado = 0;
double dineroGastado = 0;
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
            double importeDescuento = subtotal * descuento;
            double totalAPagar = subtotal - importeDescuento;

            Console.WriteLine();
            Console.WriteLine("--- Resumen de la Compra ---");
            Console.WriteLine("Cliente: " + nombreCliente.Trim());
            Console.WriteLine("Producto : " + marcaZapatillas + " " + modeloZapatillas);
            Console.WriteLine("Pares: " + cantidadDePares + " x " + precioPar.ToString("F2") + "€");
            Console.WriteLine("Descuento: " + importeDescuento.ToString("F2") + "€");
            Console.WriteLine("Total: " + totalAPagar.ToString("F2") + "€");

            //confirmar compra
            int opcionConfirmarCompra;

            do
            {
                Console.WriteLine("1. Confirmar Compra");
                Console.WriteLine("2. Cancelar Compra");
                Console.WriteLine("Seleccione una opcion: ");
                opcionConfirmarCompra = int.Parse(Console.ReadLine()!);

                if (opcionConfirmarCompra < 1 || opcionConfirmarCompra > 2)
                {
                    Console.WriteLine("Elija una de las opciones disponibles");
                }
            } while (opcionConfirmarCompra < 1 || opcionConfirmarCompra > 2);

            if (opcionConfirmarCompra == 2)
            {
                Console.WriteLine("Compra cancelada");
            }else
            {
                ventasHoy++;
                paresVendidos += cantidadDePares;
                dineroGanado += totalAPagar;
            }

            //disminuir el stock de producto en base a la venta
            if (codigoModelo == 1)
            {
                stockVomeroPlus -= cantidadDePares;
            }else if (codigoModelo == 2)
            {
                stockMaxfly2 -= cantidadDePares;
            }else if (codigoModelo == 3)
            {
                stockAirForce1 -= cantidadDePares;
            }else if (codigoModelo == 4)
            {
                stockAdizeroEvoSl -= cantidadDePares;
            }else if (codigoModelo == 5)
            {
                stockPrimeSp4 -= cantidadDePares;
            }else if (codigoModelo == 6)
            {
                stockCampus -= cantidadDePares;
            }else if (codigoModelo == 7)
            {
                stockFuelcellRebelV5 -= cantidadDePares;
            }else if (codigoModelo == 8)
            {
                stockSuperCompPwrX -= cantidadDePares;
            }else
            {
                stockutility1906 -= cantidadDePares;
            }

            //ticket de la venta de stock
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("            Ticket Alpine&Run");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Numero ticket: " + ventasHoy);
            Console.WriteLine("Cliente: "+ nombreCliente.Trim());
            Console.WriteLine("Producto comprado: "+ marcaZapatillas + " " + modeloZapatillas);
            Console.WriteLine("Par/es comprados: " + cantidadDePares + "x" + precioPar.ToString("F2") + "€");
            Console.WriteLine("Subtotal: " + subtotal.ToString("F2") + "€");
            Console.WriteLine("Descuento: " + (descuento * 100).ToString("F0") + "% = " + importeDescuento.ToString("F2") + "€");
            Console.WriteLine("TOTAL: " + totalAPagar.ToString("F2") + "€");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("          Gracias por su compra");
            Console.WriteLine();

            //revisar stock despues de la venta
            if (codigoModelo == 1)
            {
                stockDisponible = stockVomeroPlus;
            }else if (codigoModelo == 2)
            {
                stockDisponible = stockMaxfly2;
            }else if (codigoModelo == 3)
            {
                stockDisponible = stockAirForce1;
            }else if (codigoModelo == 4)
            {
                stockDisponible = stockAdizeroEvoSl;
            }else if (codigoModelo == 5)
            {
                stockDisponible = stockPrimeSp4;
            }else if (codigoModelo == 6)
            {
                stockDisponible = stockCampus;
            }else if (codigoModelo == 7)
            {
                stockDisponible = stockFuelcellRebelV5;
            }else if (codigoModelo == 8)
            {
                stockDisponible = stockSuperCompPwrX;
            }else
            {
                stockDisponible = stockutility1906;
            }

            if (stockDisponible <= 3)
            {
                Console.WriteLine();
                Console.WriteLine("AVISO: Stock Bajo de: " + marcaZapatillas + " " + modeloZapatillas);
            }
        }
    }
    else if (opcionPrincipal == 2)
    {
        //consultar inventario
        Console.WriteLine();
        Console.WriteLine("--- Inventario ---");
        Console.WriteLine("Nike");
        Console.WriteLine("Vomero Plus: " + stockVomeroPlus + "pares");
        Console.WriteLine("Maxfly 2: " + stockMaxfly2 + "pares");
        Console.WriteLine("Airforce 1: " + stockAirForce1 + "pares");
        Console.WriteLine("Adidas");
        Console.WriteLine("Adizero EVO SL: " + stockAdizeroEvoSl + "pares");
        Console.WriteLine("Prime SP 4: " + stockPrimeSp4 + "pares");
        Console.WriteLine("Campus: " + stockCampus + "pares");
        Console.WriteLine("NewBalence");
        Console.WriteLine("Fuelcell Rebel V5: " + stockFuelcellRebelV5 + "pares");
        Console.WriteLine("Fuelcell SuperComp PWR-X v3: " + stockSuperCompPwrX + "pares");
        Console.WriteLine("1906 Utility: " + stockutility1906 + "pares");

        //total de pares
        int totalParesEnStock = stockVomeroPlus + stockMaxfly2 + stockAirForce1 + stockAdizeroEvoSl + stockPrimeSp4 + stockCampus + stockFuelcellRebelV5 + stockSuperCompPwrX + stockutility1906;
        
        //valor total stock
        int valorTotalParesEnStock = stockVomeroPlus * 180 + stockMaxfly2 * 220 + stockAirForce1 * 120 + stockAdizeroEvoSl * 180 + stockPrimeSp4 * 220 + stockCampus * 120 + stockFuelcellRebelV5 * 120 + stockSuperCompPwrX * 170 + stockutility1906 * 120;

        //sacar por pantalla
        Console.WriteLine();
        Console.WriteLine("Total de pares en stock: " + totalParesEnStock);
        Console.WriteLine("Valor total del stock: " + valorTotalParesEnStock.ToString("F2") + "€");
    }
    else if (opcionPrincipal == 3)
    {
        //consultar ventas del dia
        Console.WriteLine();
        Console.WriteLine("--- Ventas del Dia ---");

        //hacer que no se tenga que dividir entre 0 para que no de error
        if (ventasHoy == 0)
        {
            Console.WriteLine("Hoy no ha habido ventas por el momento");
        }else
        {
            Console.WriteLine("Ventas: " + ventasHoy);
            Console.WriteLine("Pares vendidos: " + paresVendidos);
            Console.WriteLine();
            Console.WriteLine("Dinero Ganado: " + dineroGanado.ToString("F2") + "€");
            Console.WriteLine("Dinero Gastado: " + dineroGastado.ToString("F2") + "€");
        }
    }
    else if (opcionPrincipal == 4)
    {
        //reponer inventario
        Console.WriteLine();
        Console.WriteLine("--- Reponer Inventario ---");
        Console.WriteLine("1. Nike Vomero Plus (stock: " + stockVomeroPlus + ")");
        Console.WriteLine("2. Nike Maxfly 2 (stock:" + stockMaxfly2 + ")");
        Console.WriteLine("3. Nike AirForce 1 (stock" + stockAirForce1 + ")");
        Console.WriteLine("4. Adidas Adizero EVO SL (stock: 0 " + stockAdizeroEvoSl + ")");
        Console.WriteLine("5. Adidas Prime SP 4 (stock: " + stockPrimeSp4 + ")");
        Console.WriteLine("6. Adidas Campus (stock: " + stockCampus + ")");
        Console.WriteLine("7. NewBalance Fuelcell Rebel V5 (stock: " + stockFuelcellRebelV5 + ")");
        Console.WriteLine("8. NewBalance Fuelcell SuperComp PWR-X v3 (stock: " + stockSuperCompPwrX + ")");
        Console.WriteLine("9. NewBalance 1906 utility (stock: " + stockutility1906 + ")");

        int zapatillasAReponer;

        do
        {
            Console.WriteLine("Zapatillas a reponer 1 a 9:");
            zapatillasAReponer = int.Parse(Console.ReadLine()!);

            if (zapatillasAReponer < 1 || zapatillasAReponer >9)
            {
                Console.WriteLine("Elija una de las opciones");
            }
        } while (zapatillasAReponer < 1 || zapatillasAReponer > 9);

        double precioVentaZapatillas = 0;

        if (zapatillasAReponer == 1)
        {
            precioVentaZapatillas = 180;
            stockVomeroPlus += zapatillasAReponer;
        }else if (zapatillasAReponer == 2)
        {
            precioVentaZapatillas = 220;
            stockMaxfly2 += zapatillasAReponer;
        }else if (zapatillasAReponer == 3)
        {
            precioVentaZapatillas = 120;
            stockAirForce1 += zapatillasAReponer;
        }else if (zapatillasAReponer == 4)
        {
            precioVentaZapatillas = 180;
            stockAdizeroEvoSl += zapatillasAReponer;
        }else if (zapatillasAReponer == 5)
        {
            precioVentaZapatillas = 220;
            stockPrimeSp4 += zapatillasAReponer;
        }else if (zapatillasAReponer == 6)
        {
            precioVentaZapatillas = 120;
            stockCampus += zapatillasAReponer;
        }else if (zapatillasAReponer == 7)
        {
            precioVentaZapatillas = 120;
            stockFuelcellRebelV5 += zapatillasAReponer;
        }else if (zapatillasAReponer == 8)
        {
            precioVentaZapatillas = 170;
            stockSuperCompPwrX += zapatillasAReponer;
        }else
        {
            precioVentaZapatillas = 120;
            stockutility1906 += zapatillasAReponer;
        }

        inventarioNuevo += zapatillasAReponer;
        Console.WriteLine();
        Console.WriteLine("Reposicion: " + zapatillasAReponer + " pares");
    }
    else if (opcionPrincipal == 0)
    {
        //salir del programa
        Console.WriteLine();
        Console.WriteLine("Cerrando Alpine&Run. Balance a final de dia: " + (dineroGanado - dineroGastado).ToString("F2") + "€");
    }
    else
    {
        Console.WriteLine("Opcion incorrecta. seleccione 1, 2, 3, 4 o 0");
    }
} while (opcionPrincipal != 0);