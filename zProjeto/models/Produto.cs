using System;
namespace Produtos;
public class Produto
{
    private string ProdutoNome { get; set; }
    private decimal ProdutoValor { get; set; }
    private int ProdutoEstoque { get; set; }
    private string ProdutoCategoria { get; set; }
    private int IDprod { get; set; }

    public Produto()
    {
        this.ProdutoNome = ProdutoNome;
        this.ProdutoValor = ProdutoValor;
        this.ProdutoEstoque = ProdutoEstoque;
        this.ProdutoCategoria = ProdutoCategoria;
        this.IDprod = 0;

    }

    public void nomesID()
    {
        Console.WriteLine("Função teste para colocar o nome e ver o ID do produto");
        Console.WriteLine("Coloque o nome do produto");
        ProdutoNome = Console.ReadLine();
        Console.WriteLine($"{ProdutoNome} - id: {IDprod}");
        IDprod++;
    }

    public void mostrarLista()
    {


        Console.WriteLine("Eis aqui a vossa lista:");
        foreach (var i in ProdutoNome)
        {
            Console.WriteLine($"{ProdutoNome} + {i}");
        }
    }
}