//todo o namespace é o nome que usaremos pra fazer referencia qunado usarmos em outras classes
namespace Sesi.Model
{
    //?Declarando a classe aluno
    public class Aluno
    {
        //?Declarando nossos atributos (propriedades) da classe
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }
        private int faltas { get; set; }

        //?Criando um método
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}, tenho {idade} anos, e estou na turma {turma}");
        }

        public void addFaltas(int nr)
        {
            faltas = faltas + nr;
        }

        public void resumirFalta()
        {
            Console.WriteLine($"Você tem {faltas} faltas");
        }

        public void justFaltas(int nr)
        {
            faltas = faltas - nr;
        }

    }
}