Console.Clear();

Console.WriteLine("Te direi quantos dias tem os meses (coloque em numero)");
int mes = Convert.ToInt32(Console.ReadLine());

switch (mes)
{
    case 1:
        Console.WriteLine("O mês é janeiro e tem 31 dias");
        break;

    case 2:
        Console.WriteLine("O mês é Fevereiro e tem 28 dias");
        break;
    
    case 3:
        Console.WriteLine("O mês é Março e tem 31 dias");++++++
        break;

    case 4:
        Console.WriteLine("O mês é Abril e tem 30 dias");
        break;

    case 5:
        Console.WriteLine("O mês é Maio e tem 31 dias");
        break;
    
    case 6:
        Console.WriteLine("O mês é Junho e tem 30 dias");
        break;

    case 7:
        Console.WriteLine("O mês é Julho e tem 31 dias");
        break;

    case 8:
        Console.WriteLine("O mês é Agosto e tem 31 dias");
        break;
    
    case 9:
        Console.WriteLine("O mês é Setembro e tem 30 dias");
        break;

    case 10:
        Console.WriteLine("O mês é Outubro e tem 31 dias");
        break;

    case 11:
        Console.WriteLine("O mês é Novembro e tem 30 dias");
        break;
    
    case 12:
        Console.WriteLine("O mês é Dezembro e tem 31 dias");
        break;

    default:
        Console.WriteLine("Mês invalido");
        break;
}