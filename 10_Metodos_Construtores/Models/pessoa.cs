using System;
using System.Security;
namespace Models;

public class Pessoa
{
    //? Atributos da classe pessoa;
    
    private string nome { get; set; }
    private int idade { get; set; }
    private string email { get; set; }
    private int anoNasc { get; set; }

    //? Metodo construtor da classe pessoa;
    public Pessoa(string nomePessoa, int idadePessoa, string emailPessoa)
    {
        this.nome = nomePessoa;
        this.idade = idadePessoa;
        this.email = emailPessoa;
        this.anoNasc = DateTime.Now.Year - idadePessoa;
    }
    
    //? Metodo da classe pessoa;
    public void Cantar()
    {
        Console.WriteLine($"{nome} está cantando sua idade de {idade} anos");
        Console.WriteLine($"Seu email é {email}");
        Console.WriteLine($"Você nasceu em {anoNasc}");
    }

    public void infos()
    {
        Console.WriteLine($"seu nome é {nome}, você tem {idade} anos, nasceu em {anoNasc}, e seu email é {email}");
    }
    
}