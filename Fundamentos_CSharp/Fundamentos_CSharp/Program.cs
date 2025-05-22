using Fundamentos_CSharp.funcoes_variaveis_debug.funcoes_com_parametros;

namespace Fundamentos_CSharp;

public class Program
{
    static void Main()
    {
        var operation = new MathOperations();

        operation.Operation('-', 2, 1);
        operation.Operation('+', 2, 1);
    }
}