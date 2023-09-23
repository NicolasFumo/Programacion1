/* PROBLEMA 3
 Mediante la medida de 5 caños de una estructura a fabricar calcular
el total de material usado y el costo total usando funciones */

int totalMetros;
int precioPorMetro;
int costoTotal;
int cantidadTramos;

precioPorMetro = SolicitarNumero("Ingrese el precio por metro: ");

cantidadTramos = SolicitarNumero("Cantidad de tramos: ");

totalMetros = CalcularMetrosMaterial(cantidadTramos);

costoTotal = totalMetros * precioPorMetro;

Console.WriteLine($"El costo total es de: {costoTotal}");

int CalcularTotal(int metros, int precio)
{
    // calcular el precio total bruto
    // si ese precio supera 10.000 -> hago un descuento
    // si es que hago el descuento, calculo el monto
    // se lo resto al total bruto y lo devuelvo
    // sino (sin descuento) devuelvo el total bruto

    int totalBruto = metros * precio;

    if(totalBruto > 10000)
    {
        // hago un descuento
    }
    else
    {
        return totalBruto; // devuelvo el valor sin descuento
    }
}

int CalcularMetrosMaterial(int cantidadTramos)
{
    int cantidadParcial = 0;

    for (int i = 0; i < cantidadTramos; i++)
    {
        cantidadParcial += SolicitarNumero("Largo del tramo: ");
    }

    return cantidadParcial;
}

int SolicitarNumero(string mensaje)
{
    int resultado;
    Console.Write(mensaje);
    return int.Parse(Console.ReadLine());
}
