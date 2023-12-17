class RapidoState : BancoState
{
    public override void Deposito()
    {
        Console.WriteLine("Realizando depósito...");
        Console.WriteLine("Sistema Rápido");
        Thread.Sleep(1000);
        Console.WriteLine("Deposito realizado correctamente");
    }
}