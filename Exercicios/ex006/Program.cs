
class prog
{
    public static void Main()
    {
        Console.Clear();
        listaChurras();
        listaDesejo();

    }

    public static void listaChurras()
    {
        Console.WriteLine("Coloque os produtos que iremos comprar, junto das suas quantidades");
        string[] lista = new string[6];

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Coloque o item {i}");
            lista[i] = Console.ReadLine();
        }

        Console.WriteLine("A lista ficou assim:");
        Console.WriteLine("");



        Array.Sort(lista);
        foreach (string x in lista)
        {
            Console.WriteLine($"{x}");
        }
    }

    public static void listaDesejo()
    {
        int soma = 0;
        string[] listaDesejo = new string[3];
        int[] precoDesejo = new int[3];

        Console.WriteLine("Coloque seus sonhos");
        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Coloque o que você quer");
            listaDesejo[i] = Console.ReadLine();
            Console.WriteLine("Coloque o preço");
            precoDesejo[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
        }

        Console.WriteLine("");
        Console.WriteLine("Seus sonhos");

        foreach (string x in listaDesejo)
        {
            Console.WriteLine($"{x}");
        }

        foreach (int y in precoDesejo)
        {
            Console.WriteLine($"esses são os preços: {y}");
            soma += y;
        }
        Console.WriteLine($"{soma} din dins são necessarios para tais sonhos");
    }
}