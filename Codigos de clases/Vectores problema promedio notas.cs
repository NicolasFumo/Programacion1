// promedio de 3 notas
int cantidadDeNotas;
int promedio;
int sumatoriaNotas = 0;

Console.Write("Cantidad de notas: ");
cantidadDeNotas = int.Parse(Console.ReadLine());

int[] notas = new int[cantidadDeNotas];

for (int i = 0; i < cantidadDeNotas; i++)
{
    Console.Write("Ingrese la nota: ");
    notas[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < cantidadDeNotas; i++)
{
    sumatoriaNotas += notas[i];
}

promedio = sumatoriaNotas / cantidadDeNotas;


Console.WriteLine($"Promedio {promedio}");

// recorrer un vector
for (int indice = 0; indice < cantidadDeNotas; indice++)
{
    Console.WriteLine($"Nota: {notas[indice]}");
}
