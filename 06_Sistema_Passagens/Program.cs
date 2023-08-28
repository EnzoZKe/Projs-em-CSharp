
using System.Security.AccessControl;
using System;
class prog
{

    public static string[] poltronas = new string[43];
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("_____________________");
        Console.WriteLine("| BEM VINDO AO SESBUS |");
        Console.WriteLine("|---------------------|");
        Console.WriteLine("| _____________________`");
        Console.WriteLine("| Contamos com 42 lugares |");
        Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
        Console.WriteLine("");


        Menu();
    }

    public static void Menu()
    {
        string option = "";

        do
        {
            Console.WriteLine("| MENU |");
            Console.WriteLine(" =========================================");
            Console.WriteLine("| 1 - Para comprar passagem               |");
            Console.WriteLine("| 2 - Para comprar poltronas disponiveis  |");
            Console.WriteLine("| 0 - Fechar o sistema                    |");
            Console.WriteLine(" =========================================");

            option = Console.ReadLine();
            Console.Clear();
            switch (option)
            {
                case "0":
                    Console.WriteLine("| Volte sempre |");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "1":
                    ComprarPassagem();
                    break;

                case "2":
                    PoltronasDisponiveis();
                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    break;

            }



        } while (option != "0");
    }

    public static void ComprarPassagem()
    {
        Console.WriteLine(" |Quantas passagens você quer comprar?| ");
        int numPassagens = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numPassagens; i++)
        {
            Console.WriteLine($"Digite a poltrona da {i}° Passagem");
            int numPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do passageiro");
            string nomePassageiro = Console.ReadLine();
            MarcarPoltrona(numPoltrona, nomePassageiro);
        }
    }

    public static void MarcarPoltrona(int numPoltrona, string nomePassageiro)
    {
        poltronas[numPoltrona] = nomePassageiro;
    }

    public static void PoltronasDisponiveis()
    {
        Console.WriteLine("| Lista de poltronas disponiveis |");
        for (int i = 1; i <= 42; i++)
        {
            if (poltronas[i] == null)
            {
                Console.WriteLine($"A poltrona {i} está disponivel");
            }
        }
    }
    
}

