namespace Paantera.Model
{
    public class Pantera
    {
        public decimal Tamanho { get; set; }
        public int Peso { get; set; }
        public string cor { get; set; }
        public string especie { get; set; }
        public string alimentação { get; set; }


        public void mostrarPantera()
        {
            Console.WriteLine("");
            Console.WriteLine($"Eu sou uma pantera com {Tamanho}m, {Peso}kg, com a cor {cor}, da especie {especie}, e como {alimentação}");
        }

        public void Correr()
        {   
            Console.WriteLine("");
            Console.WriteLine("Eu estou correndo");
        }

        public void cacar()
        {
            Console.WriteLine("");
            Console.WriteLine("Eu estou a caçar");
        }

        public void Reproduzir()
        {
            Console.WriteLine("");
            Console.WriteLine("Eu estou reproduzindo");
        }
    }

    
    

}