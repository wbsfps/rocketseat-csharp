namespace HelloWorld.modificadores_de_acesso;
class Car
{

    public string Name { get; private set; }

    public Car(string name)
    {
        this.Name = name;
    }

    public void Ligar()
    {
        Console.WriteLine($"O carro {Name} está ligado!");
    }
    public void Desligar()
    {
        Console.WriteLine($"O carro {Name} está desligado!");
    }

    private void Teste1()
    {
        Console.WriteLine("Teste1");
    }

    internal void Teste2()
    {
        Teste1();
        Console.WriteLine("Teste2");
    }
}
