using Fundamentos_CSharp.funcoes_variaveis_debug.funcoes_devolvendo_valores;

namespace Fundamentos_CSharp;

public class Program
{
    static void Main()
    {
        var operation = new MathOperations();

        Console.WriteLine(operation.Operation('-', 2, 1));
        Console.WriteLine(operation.Operation('+', 2, 1));
        Console.WriteLine(operation.ReturnTwoValues(10, 1));

        var result = operation.ReturnTwoValues(20, 20).result;
        var author = operation.ReturnTwoValues(20, 20).author;
        var op = operation.ReturnTwoValues(20, 20);
        Console.WriteLine($"{op} // {result}, {author}");

        (double result2, string author2) = operation.ReturnTwoValues(30, 20);

        var op2 = operation.ReturnTwoValues(30, 20);
        Console.WriteLine($"{op2} // {result2}, {author2}");
    }
}