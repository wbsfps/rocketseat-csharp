namespace Fundamentos_CSharp.funcoes_variaveis_debug.funcoes_com_parametros;

public class MathOperations
{
    public void Operation(char symbol, double x, double y)
    {
        switch(symbol)
        {
            case '+':
                Add(x, y);
                break;
            case '-':
                Subtraction(x, y);
                break;
            default: 
                Console.WriteLine("Invalid Operation");
                break;
        }
    }

    public void Add(double x, double y) => Console.WriteLine(x + y);
    public void Subtraction(double x, double y) => Console.WriteLine(x - y);

}

