class Animal //?Classe que será herdada pelo filho // SuperClasse
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
        Animal animal = new Animal();

        Console.Clear();
        animal.emitirSom();

        Dog Cachorro = new Dog();
        Cachorro.emitirSom();
        Cachorro.latir();

        Cat gato = new Cat();
        gato.emitirSom();

    }

}