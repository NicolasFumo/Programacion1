int ladoA;
int ladoB;
int area;
int perimetro;

ladoA = SolicitarNumero("Ingrese el primer lado: ");
ladoB = SolicitarNumero("Ingrese el segundo lado: ");

area = CalcularArea(ladoA, ladoB);
perimetro = CalcularPerimetro(ladoA, ladoB);

Console.WriteLine($"El area es: {area}");
Console.WriteLine($"El perimetro es: {perimetro}");

int CalcularPerimetro(int lado1, int lado2)
{
    return lado1 + lado1 + lado2 + lado2;
}

int CalcularArea (int lado1, int lado2)
{
    int resultado;
    resultado = lado1 * lado2;
    return resultado;
}

int SolicitarNumero(string mensaje)
{
    int resultado;
    Console.Write(mensaje);
    return int.Parse(Console.ReadLine());
}
