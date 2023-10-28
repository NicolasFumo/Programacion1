void menu()
{
    int opcion;

    do
    {
        Console.WriteLine("Para extraer ingrese 1");
        Console.WriteLine("Para depositar ingrese 2");
        Console.WriteLine("Para ver saldo ingrese 3");
        Console.WriteLine();
        Console.Write("Ingrese la opcion: ");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                // Depositar
                break;
            case 2:
                // Extraer
                break;
            case 3:
                // Ver saldo
                break;
            default:
                // Si no es ninguna correcta, vuelvo a mostrar el menú
                menu();
                break;
        }
    } while (true);

}
