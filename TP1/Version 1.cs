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

// Solicitar fila y columna, y cambiar el valor por una "X"
int filaACargar;
int columnaACargar;

do
{
    Console.Write("Fila de asientos a vender: ");
    filaACargar = int.Parse(Console.ReadLine());

    Console.Write("Numero de asiento a vender: ");
    columnaACargar = int.Parse(Console.ReadLine());

    asientos[(filaACargar - 1), (columnaACargar - 1)] = "X";

    // mostrar todos los asientos
    for (int fila = 0; fila < 3; fila++)
    {
        for (int columna = 0; columna < 10; columna++)
        {
            Console.Write($" {asientos[fila, columna]} ");
        }
        Console.WriteLine();
    }
} while (true);
