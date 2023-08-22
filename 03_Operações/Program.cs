// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Digite o valor de X");
//?int X = Convert.ToInt32(Console.ReadLine()); Opção um
int X = int.Parse(Console.ReadLine()); //? Opção dois

Console.WriteLine("Digite o valor de Y");
//?int Y = Convert.ToInt32(Console.ReadLine()); Opção um
int Y = int.Parse(Console.ReadLine()); //? Opção dois

//int X = 5;
//int Y = 10;

//Operações

int soma = X + Y;
int subtracao = X - Y;
int multiplicacao = X * Y;
int divisao = X / Y;
int resto = X % Y;

int restoXDivDois = X % 2;
int restoYDivDois = X % 2;

//Console para exibir na tela as variavceis em cada linha
//soma 15

Console.WriteLine($"Soma de {X} + {Y} é: {soma}");
Console.WriteLine($"Subtração de {X} - {Y} é: {subtracao}");
Console.WriteLine($"multiplicação de {X} * {Y} é: {multiplicacao}");
Console.WriteLine($"Divisão de {X} / {Y} é: {divisao}");
Console.WriteLine($"Resto de {X} % {Y} é: {resto}");

if (restoXDivDois == 0)
{
        Console.WriteLine("==============");
        Console.WriteLine($"|  {X} é par   |");
        Console.WriteLine("==============");
}else {
        Console.WriteLine("==============");
        Console.WriteLine($"|  {X} é impar |");
        Console.WriteLine("==============");
}

/*if (restoYDivDois == 0)
{
    Console.WriteLine("==============");
    Console.WriteLine($"|  {Y} é par   |");
    Console.WriteLine("==============");
}else {
    Console.WriteLine("==============");
    Console.WriteLine($"|  {Y} é impar |");
    Console.WriteLine("==============");
}*/
//                          (Condiçã) IF TRUE "executa" : IF FALSE "não executa"
string res = (restoYDivDois == 0) ? $"O numero {Y} é par" : $"O numero {Y} é impar";
Console.WriteLine(res);


int diaSemana = 3;
//Usando Switch Case

switch (diaSemana)
{
    case 1:
        Console.WriteLine("Hoje é Domingo");
        break;
    
    case 2:
        Console.WriteLine("Hoje é Segunda");
        break;

    case 3:
        Console.WriteLine("Hoje é Terça");
        break;

    case 4:
        Console.WriteLine("Hoje é Quarta");
        break;

    case 5:
        Console.WriteLine("Hoje é Quinta");
        break;

    case 6:
        Console.WriteLine("Hoje é Sexta");
        break;

    case 7:
        Console.WriteLine("Hoje é Sabado");
        break;
    default:
        Console.WriteLine("Não é nenhum dia da semana");
        break;
}