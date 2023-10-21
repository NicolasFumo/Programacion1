
// TP1 -> Software de reservas de cine
using System.Runtime.CompilerServices;

string[,] asientos = new string[3, 10];

// Cargamos todos los asientos con "L" (libre)
for (int fila = 0; fila < 3; fila++)
{
    for (int columna = 0; columna < 10; columna++)
    {
        asientos[fila, columna] = "L";
    }
}
Menu();

void Menu()
{
    int opcion;
    
    Console.WriteLine("-- Sistema de reservas de asientos --");
    Console.WriteLine();

    Console.WriteLine("1- Ver asientos disponibles");
    Console.WriteLine("2- Reservar un asiento");
    Console.WriteLine("3- Salir");
    Console.WriteLine();

    Console.Write("Ingrese su opcion: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            // OPCION DE VER ASIENTOS LIBRES
            Console.Clear();
            MostrarAsientos(asientos);
            Menu();
            break;
        case 2:
            // RESERVAR UN ASIENTO
            Console.Clear();
            ReservarAsiento();
            MostrarAsientos(asientos);
            Menu();
            break;
        case 3:
            // OPCION DE SALIR
            Environment.Exit(0);
            break;
        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("La opcion ingresada no es valida");
            Console.ForegroundColor = ConsoleColor.Gray;
            Menu();
            break;
    }
}
void ReservarAsiento()
{
    // BANDERA / SEMAFORO
    bool volverAPedir = false;
    int filaACargar;
    int columnaACargar;

    do
    {
        Console.Write("Fila de asientos a vender: ");
        filaACargar = int.Parse(Console.ReadLine());

        Console.Write("Numero de asiento a vender: ");
        columnaACargar = int.Parse(Console.ReadLine());

        // SI LA FILA O LA COLUMNA NO ES EL VALOR CORRECTO
        if(filaACargar > 3 || filaACargar < 1 || columnaACargar > 10 || columnaACargar < 1)
        {
            // LIMPIO LA CONSOLA Y MUESTRO QUE EL VALOR NO ES CORRECTO
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Gray;

            Console.WriteLine("El valor de fila o columna no es correcto");
            Console.WriteLine("Vuelva a ingresar un valor válido");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;

            // HABILITAR VOLVER A PEDIR LA FILA/COLUMNA
            volverAPedir = true;
        }
        else // ESTA DENTRO DEL RANGO DE LOS ASIENTOS DISPONIBLES
        {
            // SI EL ASIENTO NO ESTÁ OCUPADO LO RESERVO
            if (asientos[(filaACargar - 1), (columnaACargar - 1)] == "X")
            {
                Console.WriteLine();
                Console.WriteLine("Ese asiento ya fue reservado");
                Console.WriteLine();

                volverAPedir = true;
            }
            else
            {
                // EL ASIENTO ESTÁ LIBRE, POR LO QUE SE MARCA CON "X"
                asientos[(filaACargar - 1), (columnaACargar - 1)] = "X";

                volverAPedir = false;
            }
        }

    } while (volverAPedir);
}
void MostrarAsientos(string[,] sillas)
{
    Console.WriteLine();
    Console.WriteLine("--- Asientos disponibles ---");

    for (int fila = 0; fila < 3; fila++)
    {
        for (int columna = 0; columna < 10; columna++)
        {
            // CAMBIAR EL COLOR DE LAS LETRAS SEGUN SU CONTENIDO
            // L ES VERDE Y X ES ROJO
            //if(sillas[fila, columna] == "L")
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //}

            switch (sillas[fila, columna])
            {
                case "L":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "X":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            Console.Write($" {sillas[fila, columna]} ");
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine();
}
