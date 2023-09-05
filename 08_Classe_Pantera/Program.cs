using Paantera.Model;
class program
{

    public static void Main()
    {
        var pantera = new Pantera();
        pantera.Tamanho = 20;
        pantera.Peso = 30;
        pantera.cor = "preta";
        pantera.especie = "Panthera onca";
        pantera.alimentação = "Carne";
        Console.Clear();
        pantera.mostrarPantera();
        pantera.Correr();
        pantera.cacar();
        pantera.Reproduzir();
    }



}