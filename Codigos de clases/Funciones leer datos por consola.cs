int SolicitarNumero(string mensaje)
{
    string? dato;
    int datoConvertido = 0;
    bool falla = false;
    
    do
    {
        Console.Write(mensaje);
        dato = Console.ReadLine();

        falla = string.IsNullOrEmpty(dato);

        if (falla)
        {
            Console.WriteLine("Valor incorrecto. Vuelva a ingresarlo");
        }
        else
        {
            try
            {
                datoConvertido = int.Parse(dato);
            }
            catch (Exception)
            {
                falla = true;
                Console.WriteLine("el valor no es un numero. Vuelva a ingresarlo");
            }
        }
        
    } while (falla);
    
    return datoConvertido;
}

string SolicitarTexto(string mensaje)
{
    string? dato;
    bool falla;
    do
    {
        Console.Write(mensaje);
        dato = Console.ReadLine();
        falla = string.IsNullOrEmpty(dato);

        if (falla)
        {
            Console.WriteLine("No se acepta un valor vacío. Vuelva a ingresarlo");
        }

    } while (falla);

    return dato;
}
