namespace Fundamentos_CSharp.funcoes_variaveis_debug.funcoes_devolvendo_valores;

public class MathOperations
{
    public double Operation(char symbol, double x, double y)
    {
        switch(symbol)
        {
            case '+':
                return Add(x, y);
            case '-':
                return Subtraction(x, y);
            default:
                return double.NaN;
        }
    }

    public double Add(double x, double y) => x + y;

    public (double result, string author) ReturnTwoValues(double x, double y)
    {
        var result = x + y;
        return (result, "Segundo valor");
    }
    public double Subtraction(double x, double y) => x - y;

}

