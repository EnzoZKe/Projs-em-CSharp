using System.ComponentModel;
using System;
using System.Dynamic;
using System.Security.AccessControl;
class program
{
    public static void Main()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("I = " + i);
            //System.Threading.Thread.Sleep(100);
        }

        for (int sesi = 10; sesi >= 0; sesi--)
        {
            Console.WriteLine($"a var sesi vale {sesi}");
        }

        int num = 87;
        for (int cont = 1; cont <= 10; cont++)
        {
            Console.WriteLine($"{num} X {cont} = {num*cont}");
        }
        
        //?     Declarando vetor com 34 posições;
        string[] alunos = new string[34];

        //?     Atribuindo valores ao vetor;
        alunos[1] = "Abner";
        alunos[2] = "Adalberto";
        alunos[3] = "Ana";
        alunos[33] = "Samuel";
        
        foreach (string aluno in alunos)
        {    
            Console.WriteLine(aluno);
        }

        int[] cadeiras = new int[5];
        cadeiras[0] = 5;
        cadeiras[4] = 34;
        cadeiras[1] = 69;
        cadeiras[2] = 99;
        cadeiras[3] = 50;

        int soma = 0; //soma
        int maior = 0; //maior
        int menor = 100; //menor

        foreach (int nmr in cadeiras)
        {
            soma = soma + nmr;
            if(maior < nmr)
            {
                maior = nmr;
            }

            if(menor > nmr)
            {
                menor = nmr;
            }
        }
            Console.WriteLine($"Soma = {soma}, Maior = {maior}, Menor = {menor}");

            Array.Sort(cadeiras);

            for (int x = 0; x < cadeiras.Length; x++)
            {
                Console.WriteLine($"pos {x} - valor {cadeiras[x]}");
                
            }


    }

}
