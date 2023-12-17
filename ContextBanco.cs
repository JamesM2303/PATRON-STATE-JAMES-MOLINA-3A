public class ContextBanco
{
  private BancoState state;
  public BancoState State
  {
    get
    {
        return state;
    }
    set
    {
        state = value;
    }
  }
  public void RealizarOperación()
  {
    state.Deposito();
  }  
}