//Persona secretario = new Persona();
Persona secretario;
secretario = new Persona(); //instanciar una clase (crear el objeto)

secretario.Nombre = "Pepe";
secretario.Edad = 22;

secretario.Cargar();
secretario.Mostrar();

class Persona
{
    public string Nombre;
    public int Edad;

    public void Cargar() {
        Console.WriteLine("Funcion cargar desde Clase persona");
    }
    public void Mostrar() {
        Console.WriteLine("Funcion mostrar desde Clase persona");
    }
}
