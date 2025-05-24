using Fundamentos_CSharp.funcoes_variaveis_debug.o_que_e_e_como_fazer_debug;

namespace Fundamentos_CSharp;

public class Program
{
    static void Main()
    {
        var honda = new Car("Honda", DateOnly.FromDateTime(DateTime.UtcNow), Color.RED);
        honda.ShowDetails();

        var model = Console.ReadLine()!;
        var date = Console.ReadLine()!;
        var color = Console.ReadLine()!;
        var porsche = new Car(model, DateOnly.Parse (date), (Color) Enum.Parse(typeof (Color), color, ignoreCase: true));
        
        porsche.ShowDetails();
    }
}