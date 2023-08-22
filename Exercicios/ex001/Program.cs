using System.Threading;
Console.Clear();

Console.WriteLine("------------Seja bem vindo, coloque as notas dos Alunos---------");
Console.WriteLine("Nome do estudante:----------------------------------------------");
string aluno1 = Console.ReadLine();

Console.WriteLine($"----------Coloque as notas do estudante {aluno1}.--------------");
Console.WriteLine("Nota 1:----------------------------------------------------------");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Nota 2:----------------------------------------------------------");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("Nota 3:----------------------------------------------------------");
int nota3 = int.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3) / 3;

/*if (nota1 > 10 || nota2 > 10 || nota3 > 10)
{
    Console.WriteLine("Hey, o limite de nota é 10");
    Thread.Sleep(100);
}*/

Console.WriteLine($"O estudante {aluno1} tem média {media}");
Console.WriteLine("");


string aprovado = (media >= 7) ? $"O estudante {aluno1} tem média {media} e está aprovado" : $"O estudante {aluno1} tem média {media} e está reprovado";
Console.WriteLine(aprovado);
Console.WriteLine("");








