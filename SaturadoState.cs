class SaturadoState : BancoState
{
    public override void Deposito()
    {
        Console.WriteLine("Realizando depósito...");
        Thread.Sleep(2000);
        Console.WriteLine("Sistema muy saturado... Procediendo a reiniciarse...");
        Thread.Sleep(10000);
        Console.WriteLine("Sistema reiniciado... Procediendo con la operación");
        Thread.Sleep(2000);
        Console.WriteLine("Realizando depósito...");
        Thread.Sleep(1000);
        Console.WriteLine("Depósito realizado correctamente");
    }
}