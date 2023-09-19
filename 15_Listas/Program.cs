using System.ComponentModel;
using System;
using System.Collections.Generic;
using Student.Models;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        //# Criando a lista;
        //$ Coloca primeiro o tipo List<T> nome = new List<T>();
        List<int> numeros = new List<int>();

        //$ Adicionando os elementos na lista

        //int numer = int.Parse(Console.ReadLine());

        numeros.Add(10); //# Posição [0];
        numeros.Add(20); //# Posição [1];
        numeros.Add(30); //# Posição [2];

        //$ Acessando os itens da lista pelo indice [X];
        //% Escreve o numero da posição [0];
        Console.WriteLine(numeros[0]);

        //$ Contagem de elementos;
        Console.WriteLine("Temos: " + numeros.Count + " Elementos");

        //$ Não irá aparecer no WriteLine pq ele foi adicionado após o WL;
        numeros.Add(40); //# Posição [3];
        Console.WriteLine("Temos: " + numeros.Count + " Elementos");

//####################################################################################################################################//

        List<string> Nomes = new List<string>();

        Nomes.Add("Marcos");
        Nomes.Add("Wesley");
        Nomes.Add("Zak");

        Console.WriteLine($"O nome 3 é: {Nomes[2]}");
        Console.WriteLine($"O total de nomes é {Nomes.Count}");

        //$ Iterando sobre os itens da lista (Vulgo mostrar todos os itens);
        foreach (string i in Nomes)
        {
            Console.WriteLine("-" + i);
        }

//####################################################################################################################################//

        //$ Lista com valores atribuidos;
        List<int> Nombers = new List<int> {1, 2, 5, 6, 8, 9, 12, 15, 18, 21};
        Console.WriteLine($"Temos: {Nombers.Count} Elementos");
        Nombers.Remove(2); //# Remove o elemento 2;
        Console.WriteLine($"Temos: {Nombers.Count} Elementos");
        Nombers.RemoveAt(1); //# Remove o elemento de indice 1;
        Nombers.RemoveRange(2,2); //# Remove 2 elementos a partir do indice;

        Nombers[0] = 100;
        Nombers[1] = 99;


        int ID = 0;
        //$ Iterando sobre os itens da lista (Vulgo mostrar todos os itens);
        foreach (int i in Nombers)
        {
            Console.WriteLine($"{ID} - {i}");
            ID++;
        }

//####################################################################################################################################//

        //% Criando uma lista com objetos da classe Student;
        List<Aluno> listStudent = new List<Aluno>();

        //% Formas de fazer:
        //$ Adicionando um novo aluno na lista;
        Aluno newStudent = new Aluno("Peter", 17);
        listStudent.Add(newStudent);

        listStudent.Add(new Aluno ("Patrik", 17));
        listStudent.Add(new Aluno ("Bob", 17));


        //% Exibindo a lista de alunos;
        Console.WriteLine("Mostrando a lista:");

        //% Criando uma nova lista, ordenando por Nome
        //$ LINQ usando syntax de consulta;
        var ordenacao = from aluno in listStudent
                        where aluno.idade == 17
                        orderby aluno.Nome
                        select aluno.Nome;

        var consulta = listStudent
                        .Where(aluno => aluno.idade == 17)
                        .OrderBy(aluno => aluno.Nome);


        //% Lista com foreach sem ordenação
       /* foreach (Aluno i in listStudent)
        {
            Console.WriteLine("Nome: " + i.Nome + " " + "Idade: " + i.idade);
        } */

        //% Lista com foreach com ordenação
        foreach (var aluno in ordenacao)
        {
            Console.WriteLine(aluno);
        }

    
    }

}