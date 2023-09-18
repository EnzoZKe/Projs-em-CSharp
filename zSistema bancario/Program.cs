using System.Net;
using System.ComponentModel;
using ContaCorrente;

public class program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Coloque seu nome para mostar seus dados");
        Conta titular = new Conta
        (
            Console.ReadLine()
        );

        string inp = "";

        do
        {
            Console.WriteLine("| Menu |");
            Console.WriteLine("--------");
            Console.WriteLine("1 - Consultar Saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("0 - Sair");

            inp = Console.ReadLine();
            switch (inp)
            {
                case "0":
                    Console.Clear();
                    Console.WriteLine("| Volte sempre |");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "1":
                    titular.consultarSalto();
                    break;
                case "2":
                    Console.WriteLine("Coloque o quanto você quer depositar");
                    int Deposito = int.Parse(Console.ReadLine());
                    titular.Deositar(Deposito);
                    break;
                case "3":
                    Console.WriteLine("Coloque o quanto quer sacar");
                    int saque = int.Parse(Console.ReadLine());
                    titular.Sacar(saque);
                    break;
                default:
                    Console.WriteLine("Insira uma das opções acima");
                    break;
            }

        } while (inp != "0");

    }

}