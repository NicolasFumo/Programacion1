
// METODOS (FUNCIONES)

// declarar (crear) una funcion (que hacer)
// llamar a la funcion (darle la orden que se ejecute)

//algo(10, "hola");
//algo(25, "otro texto");
// valor de retorno / nombre / parámetros
// retorno -> void (nada) -> algun tipo de dato
// nombre -> cualquiera como en las variables (1er letra en mayusculas)
// parametros -> datos que le doy a la funcion para que trabaje ()
//void algo (int dato1, string dato2) // <-- Firma del metodo (funcion)
//{
//    Console.WriteLine("Desde adentro de la funcion");
//}

//MostrarNumeros(25, 5);
//Console.WriteLine("Esta es otra secuencia de numeros");
//MostrarNumeros(27, 12);


//int mayor;

//mayor = CalcularMayorDeDosNumeros(17, 9);

//Console.WriteLine(mayor);

//int CalcularMayorDeDosNumeros (int numero1, int numero2)
//{
//    if(numero1 > numero2)
//    {
//        Console.WriteLine("Antes de devolver el valor");
//        return numero1;
//    }
//    else
//    {
//        // devuelvo N2
//        return numero2;
//    }
//}

//void MostrarNumeros(int cantidadNumeros, int inicio)
//{
//	for (int i = inicio; i <= cantidadNumeros; i++)
//	{
//        Console.WriteLine($"Numero: {i}");
//        //Console.WriteLine(i);
//    }
//}

//int resultado;
//int nro1;
//int nro2;
//nro1 = SolicitarNumero("Ingrese el primer numero ");
//nro2 = SolicitarNumero("Ingrese el segundo numero ");

//resultado = nro1 + nro2;
//Console.WriteLine($"El resutlado es {resultado}");

//int SolicitarNumero(string mensaje)
//{
//    Console.Write(mensaje);
//    return int.Parse(Console.ReadLine());
//}

///* un programa para calcular el sueldo de un empleado
// el sueldo es -> cantidad de horas semanal * pago por hora 
//-> Hacer una funcion para calcular el monto a pagar */

//int cantidadHorasDelEmpleado;
//int PrecioPorHora;
//int MontoTotalAPagar;

//cantidadHorasDelEmpleado = SolicitarNumero("Ingrese cantidad de horas: ");
//PrecioPorHora = SolicitarNumero("Ingrese el precio por hora: ");

//MontoTotalAPagar = CalcularSueldo(cantidadHorasDelEmpleado, PrecioPorHora);

//Console.WriteLine($"Debes abonar ${MontoTotalAPagar} al empleado");

//int CalcularSueldo (int horasTrabajadas, int precioHora)
//{
//   return horasTrabajadas * precioHora; 
//}

//int SolicitarNumero(string mensaje)
//{
//    Console.Write(mensaje);
//    return int.Parse(Console.ReadLine());
//}

/* Pedir dos lados de un rectangulo
 Calcular el area y el perimetro
(area = lado1 * lado2)
(perimetro = lado1 + lado1 + lado2 + lado2) 
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
*/


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
        // hago un descuento del 10%
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
