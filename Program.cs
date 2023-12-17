using System;
using System.Threading.Tasks;
class Program
{
    static void Main (String[] args)
    {
        Console.WriteLine(@"Se simulará un sistema de deposito de un banco con 4 estados
        Presione Enter para continuar");
        Console.ReadLine();
        Console.WriteLine(@"El primer estado es rápido
        Se muestra un sistema rápido para depositar.
        Presione Enter para continuar");
        Console.ReadLine();
        int bucle1 = 2;
        for (int i = 0; i < bucle1; i++)
        {
        ContextBanco Operacion1 = new ContextBanco();
        Operacion1.State = new RapidoState();
        Operacion1.RealizarOperación();
        Console.WriteLine("\n");
        Thread.Sleep(1000);
        }

        Console.WriteLine(@"El segundo estado es lento
        Se muestra un sistema lento para depositar cuando hay muchas transacciones solicitadas.
        Presione Enter para continuar");
        Console.ReadLine();
        int bucle2 = 4;
        for (int i = 0; i < bucle2; i++)
        {
        ContextBanco Operacion2 = new ContextBanco();
        Operacion2.State = new LentoState();
        Operacion2.RealizarOperación();
        Console.WriteLine("\n");
        Thread.Sleep(1000);
        }

        Console.WriteLine(@"El tercer estado es saturado:
        Se muestra un sistema saturado por demasiadas transacciones o fallos de internet
        y procede a reiniciarse el sistema para solucionar el problema y continuar con
        la operación.
        Presione Enter para continuar");
        Console.ReadLine();
        ContextBanco Operacion3 = new ContextBanco();
        Operacion3.State = new SaturadoState();
        Operacion3.RealizarOperación();
        Console.WriteLine("\n");
        Thread.Sleep(1000);

        Console.WriteLine(@"El cuarto estado es Offline
        No habrá conexión con el sistema ya que este está fuera de línea.
        Presione Enter para continuar");
        Console.ReadLine();
        ContextBanco Operacion4 = new ContextBanco();
        Operacion4.State = new CaidoState();
        Operacion4.RealizarOperación();
    }
}