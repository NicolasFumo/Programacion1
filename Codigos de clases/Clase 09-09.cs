//-------------------- CLASE 09/09/2023 ----------------------------------------------

/* Pedir dos numeros, sumarlos y mostrar el resultado en pantalla
 Necesitamos:
 - 2 variables
 - pedir de a uno los datos (convertirlo antes de guardarlo)
 - hacer la suma
 - mostrar la suma
 */

//int numero1;
//int numero2;
//int resultado;

//Console.Write("Ingresa el primer numero a sumar: ");
//numero1 = int.Parse( Console.ReadLine() );

//Console.Write("Ingresa el segundo numero a sumar: ");
//numero2 = int.Parse(Console.ReadLine());

//// opcion 1 : por separado
//Console.Write("El resultado es: ");
//Console.WriteLine(numero1 + numero2);

//// opcion 2 : con interpolacion
//Console.WriteLine($"El resultado es: {numero1 + numero2}");

//// opcion 3 : variable a parte
//resultado = numero1 + numero2;
//Console.WriteLine($"El resultado es: {resultado}");


/*  -------------------- CONDICIONALES --------------------------
  FUNCIONAMIENTO DEL CONDICIONAL
Si nota es mayor que 6?
    entonces muestro "Aprobado"
sino
    entonces muestro "Reprobado"
 */

int nota1;
int nota2;
int resultado;

Console.Write("Ingresa tu nota: ");
nota1 = int.Parse(Console.ReadLine());

Console.Write("Ingresa tu nota: ");
nota2 = int.Parse(Console.ReadLine());

resultado = (nota1 + nota2) / 2; // con promedio de 2 notas

if (resultado >= 6)  // si nota es mayor o igual que 6
{ // hago esto
    Console.WriteLine("Aprobado");
}
else // sinó
{ // hago esto otro
    Console.WriteLine("Reprobado");
}

// PROBLEMA 2
// Pedir el nombre y la edad a dos personas
// Mostrar en pantalla el nombre de la persona de mayor edad

string nombre1;
string nombre2;
int edad1;
int edad2;

Console.Write("Ingrese el primer nombre: ");
nombre1 = Console.ReadLine();
Console.Write("Ingrese la edad: ");
edad1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo nombre: ");
nombre2 = Console.ReadLine();
Console.Write("Ingrese la edad: ");
edad2 = int.Parse(Console.ReadLine());

// || (pleca) -> "o" / "or"
// && (ampersand) -> "y" / "and"
if (nombre1 == nombre2 || edad1 == edad2)
{
    Console.WriteLine("No se puede calcular");
}
else
{
    if (edad1 < edad2)
    {
        Console.WriteLine($"El mayor es: {nombre1}");
    }
    else
    {
        Console.WriteLine($"El mayor es: {nombre2}");
    }
}

/* Bucles (repeticiones)
2 formas -> definidos / indefinidos

definidos -> bucle for
indefinidos -> while / do-while

----------- BUCLE INDEFINIDO WHILE (MIENTRAS) ----------------------
while (condicion) // mientras la condicion es verdadera, repito
{

}

do
{

} while (condicion);// mientras la condicion es verdadera, repito


---------------- BUCLE DEFINIDO (SE CUANTAS VECES REPETIR) --------------------
int cantidadIntentos = 40;

for (int i = 0; i < cantidadIntentos; i++)
{
    
}

------------------------------ TAREA -------------------------------
volver a ocupar el problema del promedio de dos notas
"reprobado", "aprobado" , "promocionado"
reprobado < 6
aprobado nota >= 6
promocionado nota > 8
 ---------------------------------------------------------------- */

