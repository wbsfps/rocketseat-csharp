namespace HelloWorld.utilizando_outras_classes;
class CarOutrasClasses
{

    public string name { get; set; }

    public CarOutrasClasses(string name)
    {
        this.name = name;
    }

    public void Ligar()
    {
        Console.WriteLine($"O carro {name} está ligado!");
    }
    public void Desligar()
    {
        Console.WriteLine($"O carro {name} está desligado!");
    }
}
