namespace Fundamentos_CSharp.funcoes_variaveis_debug.criando_classes_com_valores;

public class Car
{
    private string Model { get; set; }
    private DateOnly ReleasedIn { get; set; }
    private Color Color { get; set; }

    public Car(string model, DateOnly releasedIn, Color color)
    {
        this.Model = model;
        this.ReleasedIn = releasedIn;
        this.Color = color;
    }

    public void NameModel() => Console.WriteLine(this.Model);

    public void ShowDetails()
    {
        Console.WriteLine($@" {this.Model} - {this.ReleasedIn} - {this.Color} ");
    }
}
