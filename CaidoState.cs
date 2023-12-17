using System.Net.Sockets;

class CaidoState : BancoState
{
    public override void Deposito()
    {
        Console.WriteLine("Sistema OFFLINE");
        Console.WriteLine("No se puede realizar el depósito");
    }
}