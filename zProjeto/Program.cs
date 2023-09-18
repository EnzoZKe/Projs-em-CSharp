using System.Security.AccessControl;
using Produtos;

public class Program
{
    public static void Main()
    {
        Console.Clear();

        Produto ProdutoDados = new Produto();
        Console.WriteLine("Insira um input");
        Console.WriteLine("1- olhar e colocar produtos");
        Console.WriteLine("0- Sair");
        string inp = "";
        do
        {
            inp = Console.ReadLine();
            switch (inp)
            {
                case "1":
                    ProdutoDados.nomesID();
                    break;
                
                case "2":
                    ProdutoDados.mostrarLista();
                    break;

                case "0":
                    Console.WriteLine("Saindo");
                    System.Threading.Thread.Sleep(1000);
                    break;                    
                default:
                    Console.WriteLine("Input não esperado");
                    break;
            }
        } while (inp != "0");
    }
    
}