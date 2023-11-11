public class Persona
{
    public string Nombre;
    public string Apellido;

    public bool Validar()
    {
        if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellido))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
