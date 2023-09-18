using System;
public class prg
{
    //? Serve para trarar erros nos programas
    //? Se tiver erro no try, o sistema para
    //? e vai para o catch
    public static void Main()
    {
        try
        {
            int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Seu numero:" + " " + num);
            int res = 10 / num;
            Console.WriteLine("o resultado foi" + " " + res);

        //? Tratando erro de formato
        }
        
        //? tratando exceção de overflow (numero muito grande)
        catch(OverflowException)
        {
            Console.WriteLine("Numero grande de mais");
        }
        

        catch (FormatException)
        {
            Console.WriteLine("Erro!, digite um num int");
        }

        //? catch é o que trata o erro, e normalmente coloca mensagens mais simples de se lerem
        //? as mensagens geralmente tem a ver com o tipo de erro, e são menores que as msg normais
        catch (Exception ex)
        {
            Console.WriteLine($"Zoia o erro! {ex.Message}");
        }

        //? é executado independentemente se ocorrer erro ou não
        finally
        {
            Console.WriteLine("enfim nos confins");
        }
    }
}