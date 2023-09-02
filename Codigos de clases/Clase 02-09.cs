/* comentario de una sola linea

comentario
multi
linea

 Tipos de datos
texto -> string <_
numero entero -> int <_
numero con decimales -> float
si/no -> bool (booleano)
 

//Console.Write("Parametro"); // mostramos un texto
//Console.WriteLine( 70+20 ); // mostramos un numero

*/

// ------- VARIABLES ---------
// Sirven para guardar datos para que el programa los use
// 1- Crearla (definirla / declararlo)
// 2- Guardar un dato en su interior
// 3- Usarlo (leer - guardar uno nuevo)

// 1- Declarar una variable
// El tipo de dato / Nombre

// No empezar con un numero
// no espacios (todo junto)
// Sin - medio (permitido _)
//string Palabra; // declare una variable
// Guardar un dato
//Palabra = "Un texto";

//Console.WriteLine(Palabra);

//Palabra = "Otro texto";

//Console.WriteLine(Palabra);

//Guardar en dos variables su nombre y apellido
// Mostrar en pantalla "Hola soy" -nombre- -apellido-
//string nombre = "Nicolas";
//string apellido;

//Console.WriteLine("Hola soy");

//Console.WriteLine(nombre);
//apellido = "Fumo";
//Console.WriteLine(apellido);



//int totalFactura = 70;
//int IVA = 20;
//int resultado;

//resultado = totalFactura + IVA;

//Console.WriteLine( totalFactura);
//Console.WriteLine( IVA);
//Console.WriteLine( resultado );



// Concatenación (solamente con textos)
//string nombre = "Nicolas";
//string apellido = "Fumo";

////Console.WriteLine("Hola soy" + " " + nombre + " " + apellido);

//// Interpolacion de strings
//// $ antes de la primer " (habilitar la interpolacion)
//// Las variables a colocar van dentro de {} {nombre_variable}

//Console.WriteLine($"Hola soy {nombre} y mi apellido es {apellido}");

//string NombreCompleto = $"Nombre completo: {nombre} {apellido}";

// Pedir datos por pantalla

//string NombreCompleto;
//string Direccion;

//// Siempre un Write para que el cliente sepa que ingresar
//Console.Write("Ingresa tu nombre: ");
////Console.ReadLine() Sirve para leer TEXTO  de la consola
//NombreCompleto = Console.ReadLine();

//Console.Write("Ingre tu direccion: ");
//Direccion = Console.ReadLine();

//Console.WriteLine($"El nombre es: {NombreCompleto} y vivis en {Direccion}");




string NombreCompleto;
int Edad;

Console.Write("Ingresa tu nombre: ");
NombreCompleto = Console.ReadLine();

Console.Write("Ingresa tu edad: ");
// para leer un numero entero de la consola
Edad = int.Parse( Console.ReadLine() );

Console.WriteLine($"El nombre es: {NombreCompleto}");

// 2 tipos de errores -> De compilacion / De ejecucion


// Convertir tipos de datos
// tipo de dato de destino.Parse("dato original")
