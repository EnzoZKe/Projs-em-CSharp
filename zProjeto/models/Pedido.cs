namespace Pedidos;
public class Pedido
{
    private string Pedinte { get; set; }
    private int LocalizacaoCEP { get; set; }
    private decimal Valor { get; set; }
    private decimal ValorTotal { get; set; }
    private string LocalizacaoRua { get; set; }
    private int IDpedido { get; set; }

    public Pedido()
    {
        this.Pedinte = Pedinte;
        this.LocalizacaoCEP = LocalizacaoCEP;
        this.Valor = Valor;
        this.ValorTotal = ValorTotal;
        this.LocalizacaoRua = LocalizacaoRua;
        this.IDpedido = 0;
    }
}