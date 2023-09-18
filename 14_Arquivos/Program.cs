using System.Net;
using System.IO;

public class Prg
{
    public static void Main()
    {
        //t Chama as funções
        GravarArquivo();
        LerArquivo();
    }

    //# Cria uma string com o nome do caminho e arquivo a ser criado, para quando mudar o nome dela
    public static string path = "Arquivo/arquivo.txt";


    public static void GravarArquivo()
    {
        try
        {
            //# Instanciando um obj da classe StreanWriter para gravar em arquivo
            using (StreamWriter arquivo = new StreamWriter(path, true))
            {
                Console.Clear();
                Console.WriteLine("escreva algo para gravarmos");
                arquivo.WriteLine(Console.ReadLine());

                //# outro metodo de fazer ^^^^^^
                /**
                Console.Clear();
                Console.WriteLine("escreva algo para gravarmos");
                string texto = Console.ReadLine();
                arquivo.WriteLine(texto);
                */
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro! {ex.Message}");
        }
    }

    public static void LerArquivo()
    {

        //t Verificar Se O Arquivo Existe
        if (File.Exists(path) == false)
        {
            //# Executa quando o IF for falso
            //# Ele cria o arquivo
            File.Create(path);
        }

        try
        {
            //# Obj pra ler o arquivo (StreamReader)
            using (StreamReader arquivo = new StreamReader(path))
            {
                Console.Clear();
                string linha;
                //# While para ler linha por linha no arquivo
                while ((linha = arquivo.ReadLine()) != null)
                {
                    //# Escreve no console o conteudo da linha
                    Console.WriteLine(linha);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro! {ex.Message}");
        }


    }

}