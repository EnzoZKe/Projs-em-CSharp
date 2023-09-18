using Models;

public class Program
{
    public static void Main()
    {
        /*Console.Clear();
        //? Criando um obj com classe pessoa
        //? Instanciando sem um metodo construtor;

        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Enzo";
        pessoa1.idade = 16;

        //? chamando o metodo cantar
        pessoa1.Cantar();

        //? Outro jeito de fazer
        Pessoa pessoa2 = new Pessoa{
            nome = "Abner",
            idade = 16
        };

        pessoa2.Cantar();*/

        Console.Clear();
        //? Com metodo construtor;
        //* com ReadLine

        Console.WriteLine("Coloque o nome da Pessoa, sua idade e email");
        Pessoa pesso1 = new Pessoa
        (   
            Console.ReadLine(), 
            int.Parse(Console.ReadLine()),
            Console.ReadLine()
        );

        //* sem ReadLine
        //Pessoa pesso1 = new Pessoa("Enzo", 17, "ebs.sarante@gmail.com");
        //Pessoa pesso2 = new Pessoa("Abner", 16, "abner.leite@gmail.com");
        //Pessoa pesso3 = new Pessoa("Cesar", 17, "cesar.souza@gmail.com");


        //? Chama o metodo
        //pesso1.Cantar();
        pesso1.infos();
        //pesso2.infos();
        //pesso3.infos();

    }
}