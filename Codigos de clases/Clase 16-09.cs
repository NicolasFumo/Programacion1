/* BUCLES
3 TIPOS -> for, while, do-while
2 FUNCIONAMIENTOS -> definido, indefinido

// while (indefinido)
while (true)
{
    
}

// do-while (indefinido)
do
{

} while (true);

// for (definido)
//   contador   condicion  incremento
for (int i = 0; i < 4; i++)
{

}

//-> 3 formas de sumar un valor a una variable
//variable = variable + 1;
//variable += 1;
//variable++;  
//variable--;
// */

//// sumar 3 notas y mostrar el promedio

//int sumatoriaNotas = 0; // <- Acumulador
//int resultado;
//for (int i = 0; i < 3; i++)
//{
//    Console.Write("Ingresa tu nota: ");
//    sumatoriaNotas += int.Parse(Console.ReadLine());
//}
//resultado = sumatoriaNotas / 3;
//Console.WriteLine($"El resultado es: {resultado}");




/* Problema 1
 Mostrar en pantalla los numeros de 0 al 50 
 La persona puede ingresar cuantos numeros mostrar*/

//int cantidad = 0;

//Console.Write("Hasta que numero querés que muestre? -> ");
//cantidad = int.Parse(Console.ReadLine());

//for (int i = 0; i <= cantidad; i++)
//{
//    Console.WriteLine(i);
//}


//int sumatoriaNotas = 0;
//int promedio;
//int cantidad;

//Console.Write("Cantidad de notas -> ");
//cantidad = int.Parse(Console.ReadLine());

//for (int i = 0; i < cantidad; i++)
//{
//    Console.Write("Ingresa tu nota: ");
//    sumatoriaNotas += int.Parse(Console.ReadLine());
//}

//promedio = sumatoriaNotas / cantidad;
//Console.WriteLine($"El resultado es: {promedio}");






// -------- con while en vez de for -----------

//int contador = 0;

//while (contador <= 50)
//{
//    Console.WriteLine(contador);

//    contador += 1;
//}



//int sumatoriaNotas = 0;
//int promedio;
//int cantidad = 0;
//int notaIndividual;

//do
//{
//    Console.Write("Ingresa tu nota: ");
//    notaIndividual = int.Parse(Console.ReadLine());

//    if(notaIndividual >= 0)
//    {
//        sumatoriaNotas += notaIndividual;
//        cantidad += 1;
//    }
//} while (notaIndividual >= 0);

//promedio = sumatoriaNotas / cantidad;
//Console.WriteLine($"El resultado es: {promedio}");





//// Ingresar 10 notas y mostrar la mayor y la menor

//int nota;
//int mayor = 0;
//int menor = 10;

//for (int i = 0; i < 10; i++)
//{
//    Console.Write("nota -> ");
//    nota = int.Parse(Console.ReadLine());

//    if (nota > mayor)
//    {
//        mayor = nota;
//    }

//    if(nota < menor)
//    {
//        menor = nota;
//    }
//}

//Console.WriteLine($"La nota mayor fue: {mayor}");
//Console.WriteLine($"La nota menor fue: {menor}");

// Funciones (métodos)
// declarar la funcion (crearla)
// llamar a la funcion (utilizarla)

// declarar la funcion (firma, codigo -> cuerpo)
// valor de retorno - nombre - parametros (datos que recibe)

int totalFactura1 = SumarDosNumeros(20, 40);
int totalFactura2 = SumarDosNumeros(34, 17);
int totalFactura3 = SumarDosNumeros(13, 89);

int SumarDosNumeros (int numero1, int numero2)
{
    int resultado;
    resultado = numero1 + numero2;

    return resultado;
}
