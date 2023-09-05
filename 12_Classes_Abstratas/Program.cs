//?Classe que será herdada pelo filho // SuperClasse

class abstract Animal 
{
    public string cor { get; set; }

    public virtual void emitirSom()
    {
        Console.WriteLine($" - Animal emitindo som - ");
    }
}

class Dog : Animal //? Classe filha que herdará os atributos da super classe
{
    public void latir()
    {
        Console.WriteLine(" - Au Au - ");
    }
}

class Cat : Animal
{

    public override void emitirSom()
    {
        Console.WriteLine($" - Gato ta miando miau miau - ");
    }
}



class program
{
    public static void Main()
    {
        //? Não é permitido instanciar um obj de uma classe abstrata
        /*Animal animal = new Animal();

        Console.Clear();
        animal.emitirSom();*/

        Dog Cachorro = new Dog();
        Cachorro.emitirSom();
        Cachorro.latir();

        Cat gato = new Cat();
        gato.emitirSom();

    }

}