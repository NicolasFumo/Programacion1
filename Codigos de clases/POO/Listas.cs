// Listas de objetos
// Una cantidad "ilimitada" de elementos
// tiene funciones para manipular esos elementos
// elementos SIEMPRE del mismo tipo

Alumno a1 = new Alumno();
a1.Nombre = "Nicolas";
a1.Edad = 25;

Alumno a2 = new Alumno();
a2.Nombre = "Pepe";
a2.Edad = 25;

Alumno a3 = new Alumno();
a3.Nombre = "Ricardo";
a3.Edad = 32;

Alumno a4 = new Alumno();
a4.Nombre = "Ricardo";
a4.Edad = 80;

// Listas
List<Alumno> listadoAlumnos = new List<Alumno>();

listadoAlumnos.Add(a1); // añadir una copia del objeto a la caja
listadoAlumnos.Add(a2);
listadoAlumnos.Add(a3);
listadoAlumnos.Add(a4);

// Saber cuantos elementos hay dentro de la lista          _____
Console.WriteLine($"Cantidad de elementos: {listadoAlumnos.Count}");

//listadoAlumnos.Remove(a1); // remuevo una copia de la caja
//listadoAlumnos.Clear(); // Vaciar la lista (dejarla sin elementos)


// Recorrer una lista
//foreach (var item in listadoAlumnos)
//{
//    Console.WriteLine(item.Nombre);
//}

// Buscar la primer coincidencia
//Alumno busqueda = listadoAlumnos.Find(a => a.Nombre == "Ricardo");

// Buscar la ultima coincidencia
//Alumno busqueda = listadoAlumnos.FindLast(a => a.Nombre == "Ricardo");
//Console.WriteLine(busqueda.Edad);

// Busca varios elementos que coincidan con la busqueda
List<Alumno> busqueda = listadoAlumnos.FindAll(a => a.Nombre == "Ricardo");

// como son varios elementos, para poderlos ver uno a uno uso un foreach
foreach (var item in busqueda)
{
    // muestro la edad de cada item dentro de la lista
    Console.WriteLine(item.Edad);
}


class Alumno
{
    public string Nombre;
    public int Edad;
}
