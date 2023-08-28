//? pega bibliotecas ou classes já feitas / usa USING
using Sesi.Model;

class program
{
    public static void Main()
    {
        //?Criando uma var aluno1 e instanciando da classe Aluno ou seja, estamos criando nosso obj
        var aluno1 = new Aluno();
        //?Atribuindo valor ao atributo nome do aluno1
        aluno1.nome = "Enzo";
        aluno1.idade = 16;
        aluno1.turma = "2° EM";
        aluno1.Apresentar();
        aluno1.addFaltas(10);
        aluno1.addFaltas(7);
        aluno1.resumirFalta();
        aluno1.justFaltas(8);
        aluno1.resumirFalta();


        //?Criando uma var aluno1 e instanciando da classe Aluno ou seja, estamos criando nosso obj
        var aluno2 = new Aluno();
        //?Atribuindo valor ao atributo nome do aluno1
        aluno2.nome = "Cesar";
        aluno2.idade = 16;
        aluno2.turma = "2° EM";

        aluno2.Apresentar();
    }
}


