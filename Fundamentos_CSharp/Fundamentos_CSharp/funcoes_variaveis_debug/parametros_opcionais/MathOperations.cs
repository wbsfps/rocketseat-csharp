namespace Fundamentos_CSharp.funcoes_variaveis_debug.parametros_opcionais;

public class MathOperations
{
    public static void Test(int value1, int value2 = 2)
    {
        Console.WriteLine($"{value1 + value2}");
    }
}

