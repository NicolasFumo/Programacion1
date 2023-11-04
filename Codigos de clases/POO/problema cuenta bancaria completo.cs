/* 1ra ->   Desarrollar un sistema para administrar una cuenta bancaria
 *          De la cuenta se puede extraer dinero, depositar y ver el saldo restante
 * 2da ->   Desarrollar un menú para usar la cuenta
 * 3ra ->   No se puede extraer un monto mayor al que tengo
 *          en la cuenta */

Cuenta cuenta1 = new Cuenta();
cuenta1.Nombre = "Nicolas";

menu();

void menu()
{
    int opcion;
    int cantidad;

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

                Console.Write("Ingrese la cantidad a extraer: ");
                cantidad = int.Parse(Console.ReadLine());

                bool PudoExtraer = cuenta1.Extraer(cantidad);

                if (PudoExtraer)
                {
                    Console.WriteLine("Se pudo extraer el monto solicitado");
                }
                else
                {
                    Console.WriteLine("No tenes fondos suficientes");
                }

                menu();
                break;

            case 2:

                Console.Write("Ingrese la cantidad a depositar: ");
                cantidad = int.Parse(Console.ReadLine());

                cuenta1.Depositar(cantidad);
                menu();
                break;

            case 3:
                cuenta1.VerSaldo();
                menu();
                break;

            default:
                // Si no es ninguna correcta, vuelvo a mostrar el menú
                menu();
                break;
        }
    } while (true);

}

class Cuenta
{
    private int Saldo;
    public string Nombre;

    public bool Extraer(int cantidad)
    {
        if (Saldo >= cantidad)
        {
            Saldo -= cantidad;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Depositar(int cantidad)
    {
        Saldo += cantidad;
    }

    public void VerSaldo()
    {
        Console.WriteLine($"El saldo disponible de {Nombre} es: {Saldo}");
    }
}
