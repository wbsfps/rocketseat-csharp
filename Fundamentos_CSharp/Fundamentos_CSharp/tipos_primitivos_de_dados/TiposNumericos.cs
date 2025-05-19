namespace Fundamentos_CSharp.tipos_primitivos_de_dados;

public class TiposNumericos
{
    public static void Run()
    {
        int number = 8;
        uint anotherNumber = 9;
        long longNumber = 10;
        //sbyte sbyteNumber = 400;

        double doubleNumber = 11.2;
        float floatNumber = 2.21f;
        decimal decimalNumber = 3.1m;

        number = 1_000;

        Console.WriteLine($"{number}, {anotherNumber}, {longNumber}");
    }
}
