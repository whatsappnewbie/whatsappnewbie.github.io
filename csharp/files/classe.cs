using System;

class Animal
{
    // Propriedades
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor
    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Método virtual para ser sobrescrito
    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal faz um som.");
    }
}

class Cachorro : Animal
{
    public string Raca { get; set; }

    // Construtor que chama o construtor da classe base
    public Cachorro(string nome, int idade, string raca) : base(nome, idade)
    {
        Raca = raca;
    }

    // Sobrescreve o método EmitirSom da classe Animal
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome}, o cachorro, está latindo.");
    }
}

class Gato : Animal
{
    public string Cor { get; set; }

    public Gato(string nome, int idade, string cor) : base(nome, idade)
    {
        Cor = cor;
    }

    // Sobrescreve o método EmitirSom
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome}, o gato, está miando.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instanciando objetos das classes
        Animal meuCachorro = new Cachorro("Rex", 5, "Labrador");
        Animal meuGato = new Gato("Mimi", 3, "Branco");

        // Chamada dos métodos
        meuCachorro.EmitirSom(); // Rex, o cachorro, está latindo.
        meuGato.EmitirSom(); // Mimi, o gato, está miando.
    }
}
