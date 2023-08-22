Console.Clear();

Console.WriteLine("Olá, coloque a placa do seu carro, para saber se você pode andar com ele!");
string placa = Console.ReadLine();
string ultimoDigito = placa.Substring(6);
Console.WriteLine($"sua placa é {placa} e o ultimo digito é {ultimoDigito}");

switch (ultimoDigito)
{   
    case "1":
        Console.WriteLine("Você não poderá andar de carro na segunda");
        break;

    case "2":
        Console.WriteLine("Você não poderá andar de carro na segunda");
        break;
    
    case "3":
        Console.WriteLine("Você não poderá andar de carro na terça");
        break;
    
    case "4":
        Console.WriteLine("Você não poderá andar de carro na terça");
        break;

    case "5":
        Console.WriteLine("Você não poderá andar de carro na quarta");
        break;

    case "6":
        Console.WriteLine("Você não poderá andar de carro na quarta");
        break;

    case "7":
        Console.WriteLine("Você não poderá andar de carro na quinta");
        break;

    case "8":
        Console.WriteLine("Você não poderá andar de carro na quinta");
        break;

    case "9":
        Console.WriteLine("Você não poderá andar de carro na sexta");
        break;

    case "0":
        Console.WriteLine("Você não poderá andar de carro na sexta");
        break;
    
    default:
        Console.WriteLine("Placa invalida");
        break;
        
}