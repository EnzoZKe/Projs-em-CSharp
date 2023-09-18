public class program
{
    public static void Main()
    {
        //? Criando uma classe anonima (Classe sem definição inicial);
        Console.WriteLine("Coloque o nome da pessoa 1");
        var pessoa1 = new
        {
            Nome = Console.ReadLine(),
            Idade = 17
        };
        var pessoa2 = new
        {
            Nome = "Maraia",
            Idade = 17,
            Email = "maraia.estudanterealofc@gmail.com"
        };

        Console.WriteLine($"A pessoa 1 se chama {pessoa1.Nome} e tem {pessoa1.Idade} anos");
        Console.WriteLine($"A pessoa 2 se chama {pessoa2.Nome} e tem {pessoa2.Email} como email");

        var carro1 = new
        {
            nome = "Camaro Amarelo",
            marca = "Chevrolet",
            ano = 2011
        };

        var carro2 = new
        {
            nome = "Fuscão vermelho",
            marca = "VolksWagen",
            ano = 1970
        };

        var carro3 = new
        {
            nome = "Opala Marrom",
            marca = "Chevrolet",
            ano = 1980
        };

        Console.WriteLine($"carro 1: {carro1.nome} // marca: {carro1.marca} // ano: {carro1.ano}");
        Console.WriteLine($"carro 2: {carro2.nome} // marca: {carro2.marca} // ano: {carro2.ano}");
        Console.WriteLine($"carro 3: {carro3.nome} // marca: {carro3.marca} // ano: {carro3.ano}");


    }
}
