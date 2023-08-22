

class Prog
{

    public static void Main()
    {
        Console.WriteLine("Escreva o numero");
        float numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dobro:");
        Console.WriteLine(DobroMetade(numero1));
        Console.WriteLine("Metade:");
        Console.WriteLine(MetadeDobro(numero1));

        Console.WriteLine("Tabuada, por favor, insira o numero que você quer saber a tabuada");
        int numero = Convert.ToInt32(Console.ReadLine());
        Tabua(0, numero);
        Somas();

    }

    public static float DobroMetade(float numero1)
    {
        float Dobro = numero1 * 2;
        return Dobro;
    }

    public static float MetadeDobro(float numero1)
    {
        float Metade = numero1 / 2;
        return Metade;
    }

    public static void Tabua(int contador, int numero)
    {
        Console.WriteLine("Contador");
        while (contador <= 10)
        {
            int tabuadas = contador * numero;
            Console.WriteLine($"{contador} X {numero} = {tabuadas}");
            contador++;
            //System.Threading.Thread.Sleep(100);
        }

    }

    public static void Somas()
    {

        int soma = 0;
         int maior = 0;
        int menor = 1000000;
        int numer = 0;
        do
        {
            Console.WriteLine("Escreva um numero");
            
            numer = Convert.ToInt32(Console.ReadLine());
            if (numer > 0){
                soma = soma + numer;
                Console.WriteLine($"a soma é {soma}");
                
            }

            if (numer > maior)
            {
                maior = numer;
                //soma = soma + numer;
                Console.WriteLine($"o maior é {numer}");

            }

            if (numer < menor)
            {
                menor = numer;
                //soma = soma + numer;
                Console.WriteLine($"o menor é {numer}");

            }

        } while (numer > 0);
        Console.WriteLine($"O maior é: {maior} e o menor é {menor}");
    }
}