// MATRICES
//                 filas, columnas
int[,] datos = new int[2, 3];

//datos[0, 0] = 1;
//datos[0, 1] = 2;
//datos[0, 2] = 3;
//datos[1, 0] = 4;
//datos[1, 1] = 5;
//datos[1, 2] = 6;
for (int fila = 0; fila < 2; fila++)
{
    for (int columna = 0; columna < 3; columna++)
    {
        Console.Write($"Dato para F{fila} C{columna}: ");
        datos[fila, columna] = int.Parse(Console.ReadLine());
    }
}

for (int fila = 0; fila < 2; fila++)
{
    for (int columna = 0; columna < 3; columna++)
    {
        Console.WriteLine($"Dato en F{fila} C{columna}: {datos[fila, columna]}");
    }
}
