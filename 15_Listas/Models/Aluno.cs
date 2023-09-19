namespace Student.Models;
public class Aluno
{
    public string Nome { get; set; }
    public int idade { get; set; }

    public Aluno(string nomeAluno, int idadeAluno)
    {
        this.Nome = nomeAluno;
        this.idade = idadeAluno;
    }
    
}