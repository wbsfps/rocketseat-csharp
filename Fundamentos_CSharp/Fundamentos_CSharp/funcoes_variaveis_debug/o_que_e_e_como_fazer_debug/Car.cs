namespace Fundamentos_CSharp.funcoes_variaveis_debug.o_que_e_e_como_fazer_debug;

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
