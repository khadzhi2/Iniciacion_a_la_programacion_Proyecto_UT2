// -------------------------------
//Alpine&Run: 
// -------------------------------

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