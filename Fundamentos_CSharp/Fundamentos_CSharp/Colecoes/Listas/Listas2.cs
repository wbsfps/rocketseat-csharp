namespace Fundamentos_CSharp.Colecoes.Listas;

public class Listas2
{
    public static void Run()
    {
        List<string> strings = new List<string>();
        strings.Add("I");
        strings.Add("am");
        strings.Add("from");
        strings.Add("Brazil");

        strings.Remove("am");
        
        foreach (var text in strings)
        {
            Console.WriteLine(text);
        }

        List<int> ints = new List<int>();
        ints.Add(0);
        ints.Add(1);
        List<decimal> decimals = new List<decimal>();
        List<bool> bools = new List<bool>();

        List<object> obejcts = new List<object>();
        obejcts.Add("Hello");
        obejcts.Add(1);
        obejcts.Add(true);

        string result = string.Join(" ", strings);
        Console.WriteLine(result);

        result = string.Join("-", ints);
        Console.WriteLine(result);
    }
}
