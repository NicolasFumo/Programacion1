// HERENCIA (de clases)
Alumno A1 = new Alumno();

A1.nombre = "alguien";
A1.apellido = "otro alguien";

class Persona
{
    protected string nombre; // se hereda pero funciona como "private" en alumno
    public string apellido; // las public se heredan normalmente
    private int edad; // las private no se heredan, y solo funcionan en la clase padre

    public void Saludar()
    {
        Console.WriteLine($"Hola soy {nombre}");
    }
}
// la herencia se hace colocando ":" y el nombre de la clase de la cual
// quiero heredar las propiedades / metodos de la clase padre
class Alumno : Persona
{
    public string CursoInscripto;
}
