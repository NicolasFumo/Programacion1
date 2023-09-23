int resultado;
int nro1;
int nro2;
nro1 = SolicitarNumero("Ingrese el primer numero ");
nro2 = SolicitarNumero("Ingrese el segundo numero ");

resultado = nro1 + nro2;
Console.WriteLine($"El resutlado es {resultado}");

int SolicitarNumero(string mensaje)
{
    Console.Write(mensaje);
    return int.Parse(Console.ReadLine());
}

/* un programa para calcular el sueldo de un empleado
 el sueldo es -> cantidad de horas semanal * pago por hora 
-> Hacer una funcion para calcular el monto a pagar */

int cantidadHorasDelEmpleado;
int PrecioPorHora;
int MontoTotalAPagar;

cantidadHorasDelEmpleado = SolicitarNumero("Ingrese cantidad de horas: ");
PrecioPorHora = SolicitarNumero("Ingrese el precio por hora: ");

MontoTotalAPagar = CalcularSueldo(cantidadHorasDelEmpleado, PrecioPorHora);

Console.WriteLine($"Debes abonar ${MontoTotalAPagar} al empleado");

int CalcularSueldo (int horasTrabajadas, int precioHora)
{
   return horasTrabajadas * precioHora; 
}

int SolicitarNumero(string mensaje)
{
    Console.Write(mensaje);
    return int.Parse(Console.ReadLine());
}
