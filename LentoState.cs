class LentoState : BancoState
{
    public override void Deposito()
    {
        Console.WriteLine("Realizando depósito...");
        Thread.Sleep(3000);
        Console.WriteLine("Sistema lento...");
        Thread.Sleep(2000);
        Console.WriteLine("Depósito realizado correctamente");
    }
}