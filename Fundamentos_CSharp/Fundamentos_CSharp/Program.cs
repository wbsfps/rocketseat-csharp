using Fundamentos_CSharp.funcoes_variaveis_debug.o_que_e_um_static;

namespace Fundamentos_CSharp;

public class Program
{
    static void Main()
    {
        var result = MathOperation.Add(1, 2);
        Console.WriteLine(result);
    }
}