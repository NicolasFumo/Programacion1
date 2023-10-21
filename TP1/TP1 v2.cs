
// TP1 -> Software de reservas de cine
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

// Solicitar fila y columna, y cambiar el valor por una "X"
int filaACargar;
int columnaACargar;
// BANDERA / SEMAFORO
bool volverAPedir = false;

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
            Console.WriteLine("La opcion ingresada no es valida");
            Menu();
            break;
    }
}
void ReservarAsiento()
{
    do
    {
        Console.Write("Fila de asientos a vender: ");
        filaACargar = int.Parse(Console.ReadLine());

        Console.Write("Numero de asiento a vender: ");
        columnaACargar = int.Parse(Console.ReadLine());

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
            Console.Write($" {sillas[fila, columna]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}
