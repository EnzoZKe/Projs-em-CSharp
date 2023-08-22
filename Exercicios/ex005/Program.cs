/*
Tinha feito isso separado, por que não sabia que era pra fazer tudo junto no ex004
é o mesmo codigo que está lá, so que separado
*/


using System.Reflection.Metadata.Ecma335;
class Prog
{
    public static void Main()
    {
        Console.WriteLine("Tabuada, por favor, insira o numero que você quer saber a tabuada");
        int numero = Convert.ToInt32(Console.ReadLine());
        Tabua(0, numero);
    }

   public static void Tabua(int contador, int numero)
    {
        Console.WriteLine("Contador");
        while (contador <= 10)
        {
            int tabuadas = contador * numero;
            Console.WriteLine($"{contador} X {numero} = {tabuadas}");
            contador++;
            System.Threading.Thread.Sleep(100);
        }

    }
}