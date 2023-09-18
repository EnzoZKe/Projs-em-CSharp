namespace ContaCorrente;
public class Conta
{
    private string Titular { get; set; }
    private decimal Saldo { get; set; }

    public Conta(string TitularNome)
    {
        this.Titular = TitularNome;
        this.Saldo = 0;
    }

    public void consultarSalto()
    {
        Console.WriteLine($"Olá {Titular}, você tem um saldo de R${Saldo}");
    }

    public void Deositar(decimal Deposito)
    {   
        decimal valorDeposito = Deposito;

        if (valorDeposito == 0)
        {
            Console.WriteLine($"Você não pode depositar 0 reais {Titular}");
        } else
        {

            Saldo = Saldo + valorDeposito;
            Console.WriteLine($"Você depositou {valorDeposito} reais, e está com R${Saldo}");
        }
    }

    public void Sacar(decimal saque)
    {
        decimal valorSaque = saque;

        if (valorSaque == 0 || Saldo < valorSaque)
        {
            Console.WriteLine($"Ei! {Titular}, você não pode sacar um valor mair que o presente na sua conta, ou sacar 0 reais!");
        } else 
        {
            Saldo = Saldo - valorSaque;
            Console.WriteLine($"Você sacou {valorSaque} reais e está com R${Saldo}");
        }

    }
}
