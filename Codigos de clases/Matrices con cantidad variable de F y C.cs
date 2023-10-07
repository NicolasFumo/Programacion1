
int cantidadFilas;
int cantidadcolumnas;

Console.Write("Cantidad de filas: ");
cantidadFilas = int.Parse(Console.ReadLine());

Console.Write("Cantidad de columnas: ");
cantidadcolumnas = int.Parse(Console.ReadLine());

int[,] datos = new int[cantidadFilas, cantidadcolumnas];

datos[0, 0] = 1;
datos[0, 1] = 2;
datos[0, 2] = 3;
datos[1, 0] = 4;
datos[1, 1] = 5;
datos[1, 2] = 6;

//for (int fila = 0; fila < cantidadFilas; fila++)
//{
//    for (int columna = 0; columna < cantidadcolumnas; columna++)
//    {
//        Console.Write($"Dato para F{fila} C{columna}: ");
//        datos[fila, columna] = int.Parse(Console.ReadLine());
//    }
//}

for (int fila = 0; fila < cantidadFilas; fila++)
{
    for (int columna = 0; columna < cantidadcolumnas; columna++)
    {
        Console.Write($"{datos[fila, columna]}  |  ");
    }
    Console.WriteLine(  );
}
