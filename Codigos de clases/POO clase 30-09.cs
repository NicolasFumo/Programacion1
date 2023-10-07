Alumno Alumno1 = new Alumno(); // instanciar
Alumno Alumno2 = new Alumno();

Alumno1.Nombre = "pepito";
Alumno1.Apellido = "Fernandez";
Alumno1.Saludar();

Alumno2.Nombre = "Juan carlos";
Alumno2.Apellido = "Ramua";
Alumno2.Saludar();


class Alumno
{
    // variables -> propiedades
    public string Nombre;
    public string Apellido;

    // funciones -> métodos
    public void Saludar()
    {
        Console.WriteLine($"Mi nombre es: {Nombre}");
    }
}
