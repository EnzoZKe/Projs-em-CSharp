using System.Security.AccessControl;
using System.Text.RegularExpressions;
using System;
class SESI
{
    public static void Main()
    {
        //chamando metodos sem retorno
        mostrarMensagem("tchau mundo");
        mostrarMensagem("tchau mundo the second");
        imprimeDataHora();
        double Potencia = Potenciacao(4);
        Console.WriteLine($"Potenciação {Potencia}");
        contagemRegressiva(10);
        advinha();

    }
    //função com parametro e sem retorno
    public static void mostrarMensagem(string msg)
    {
        Console.WriteLine(msg);
    }

    //metodo sem parametro e sem retorno
    public static void imprimeDataHora()
    {
        Console.WriteLine(DateTime.Now.ToString());

    }

    public static double Potenciacao(int num)
    {
        double res = Math.Pow(num, 2);
        return res;
    }

    public static void contagemRegressiva(int contador)
    {
        Console.WriteLine("Contador");
        while (contador >= 0)
        {
            Console.WriteLine(contador);
            contador--;
            System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine("KABOOOOOOOM");

    }

    public static void advinha()
    {
        Console.WriteLine("******************************************");
        Console.WriteLine("*|            Bem-Vidn ao Jogo          |*");
        Console.WriteLine("*|--------------------------------------|*");
        Console.WriteLine("*|        Sorteie um numero até 20      |*");
        Console.WriteLine("******************************************");
        Console.WriteLine("******************************************");

        Random rng = new Random();
        int nrsorteio = rng.Next(20);
        int nrDigitado = -1;

        do
        {
            Console.WriteLine("Digite um nomero");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado < nrsorteio)
            {
                Console.WriteLine("O numero é Maior!!!");
            }
            else if (nrDigitado > nrsorteio)
            {
                Console.WriteLine("O numero é Menor!!!");
            }
        } while (nrDigitado != nrsorteio);
        Console.WriteLine("Uhul, você acertou!!");
        
    }

}

