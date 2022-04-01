namespace console6
{
  internal class Pedido
  {
    public string Codigo { get; set; }
    public Cliente Cliente { get; set; }
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }
    public double ValorTotal { get; set; }
  }
}